using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			Button_Zapoln_Click(null, null);
			Button_Create_Diagr_Click(null, null);
		}

		#region Диаграмма

		private void Button_Zapoln_Click(object sender, EventArgs e)  // кнопка «Заполнить»
		{
			double xi = 0.1, y;
			double dx, x_max;  // переменные для шага и мах значения прогрессии Х

			// шаг и мах значение – в зависимости от типа прогрессии
			if (radioButton_arifm.Checked) { dx = 0.2; x_max = 5; } else { dx = 1.2; x_max = 50; }
			listBox_X.Items.Clear(); listBox_Y.Items.Clear(); // очистка списков с данными

			// цикл для заполнения списков
			while (xi <= x_max)
			{
				try { y = Math.Cos(xi) / (1 + xi); } // вычисление y с проверкой
				catch
				{   // сообщение об ошибке
					MessageBox.Show("Ошибка вычисления Y при Х=" + xi.ToString());
					return;  // аварийный выход
				}
				// заполнение списков
				listBox_X.Items.Add(xi.ToString());
				listBox_Y.Items.Add(y.ToString());

				// изменение xi в зависимости от типа прогрессии
				if (radioButton_arifm.Checked) xi += dx; else xi *= dx;
			}
		}

		// кнопка "Построить диаграмму"
		private void Button_Create_Diagr_Click(object sender, EventArgs e)
		{
			chart1.Titles.Clear();  // очищаем заголовки
			chart1.Legends.Clear(); // удаляем легенду

			Int16 t = Convert.ToInt16(numericUpDown_Tip.Value); // тип диаграммы

			// заголовок диаграммы
			string s = "Студент Кашафутдинова Вар.7. Диаграмма - ";
			if (radioButton_Column.Checked)
				s += "ряд. Тип " + t.ToString();
			else s += "график. Тип " + t.ToString();
			chart1.Titles.Add(s);

			int i = 0; double x = 0, y = 0;

			chart1.Series.Clear(); // удаление всех рядов данных диаграммы
			chart1.Series.Add("Series 1");  // добавление ряда «Series 1»

			// задание типа диаграммы
			chart1.Series[0].ChartType =
			(System.Windows.Forms.DataVisualization.Charting.SeriesChartType)t;

			// занесение данных в диаграмму
			for (i = 0; i < listBox_Y.Items.Count; i++)
			{
				x = Convert.ToDouble(listBox_X.Items[i]);
				y = Convert.ToDouble(listBox_Y.Items[i]);  // оцифровываем строку списка

				// добавляем точку в ряд 1 (Series[0])
				if (radioButton_Column.Checked)
					chart1.Series[0].Points.AddY(y);    // диаграмма - ряд
				else
					chart1.Series[0].Points.AddXY(x, y);   // диаграмма - график
			}
		}

		#endregion Диаграмма

		#region График

		private void Button_Picture_Back_Click(object sender, EventArgs e) // Фон окна PictureBox
		{
			colorDialog1.Color = button_Picture_Back.BackColor; // считываем текущий цвет
			colorDialog1.ShowDialog(); // вызов палитры с выбором цвета
			Graphics G = pictureBox1.CreateGraphics(); //  определяем графическое окно
			G.Clear(colorDialog1.Color); // закрашиваем графическое окно выбранным цветом
			button_Picture_Back.BackColor = colorDialog1.Color; // запоминаем цвет фона
			G.Dispose(); // удаляем объект G из памяти
		}

		// очистка графического окна
		private void Button_Picture_Clear_Click(object sender, EventArgs e)
		{
			Graphics G = pictureBox1.CreateGraphics(); //  определяем графическое окно
			G.Clear(button_Picture_Back.BackColor);     // закрашиваем графическое окно цветом фона
			G.Dispose(); // удаляем объект G из памяти
		}

		//  изменение цвета пера / заливки при построении маркеров (событие MouseClick)
		private void Label_Color_Marker_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button.ToString() == "Left") // щелчок левой кнопкой мыши
			{
				colorDialog1.Color = label_Color_Marker.ForeColor;
				colorDialog1.ShowDialog();
				label_Color_Marker.ForeColor = colorDialog1.Color;
			}
			else  // щелчок правой кнопкой мыши
			{
				colorDialog1.Color = label_Color_Marker.BackColor;
				colorDialog1.ShowDialog();
				label_Color_Marker.BackColor = colorDialog1.Color;
			}
		}

		private void Button_Draw_Fig_Click(object sender, EventArgs e)  // построить фигуру
		{
			Graphics G = pictureBox1.CreateGraphics();  // графическое окно
			Pen P = new Pen(label_Color_Marker.ForeColor); // перо для маркеров
			Brush B = new SolidBrush(label_Color_Marker.BackColor);  // кисть для заливки

			Point Center = new Point(pictureBox1.Width / 2, pictureBox1.Height / 2);
			Point[] PP = new Point[4] { Center, Center, Center, Center };  // массив из четырех точек

			// заносим координаты середин границ графической области
			//PP[0].X = pictureBox1.Width / 2; PP[0].Y = 0;
			//PP[1].X = pictureBox1.Width; PP[1].Y = pictureBox1.Height / 2;
			//PP[2].X = pictureBox1.Width / 2; PP[2].Y = pictureBox1.Height;
			//PP[3].X = 0; PP[3].Y = pictureBox1.Height / 2;
			int MaxOff = Math.Min(pictureBox1.Width, pictureBox1.Height) / 2 - 10;
			PP[0].Offset(-MaxOff, -MaxOff); PP[1].Offset(MaxOff, -MaxOff);
			PP[3].Offset(-MaxOff, MaxOff); PP[2].Offset(MaxOff, MaxOff);

			int dx = MaxOff / 10; // величина уменьшения размеров ромба
			int dy = MaxOff / 10;
			for (int i = 0; i < 10; i++)
			{
				G.DrawPolygon(P, PP);  // строим ромб
				PP[0].Offset(dx, dy); PP[1].Offset(-dx, dy);
				PP[3].Offset(dx, -dy); PP[2].Offset(-dx, -dy);
				//PP[0].Y += dy; PP[2].Y -= dy; // уменьшаем размеры ромба
				//PP[1].X -= dx; PP[3].X += dx;
			}

			G.Dispose(); P.Dispose();  // очистка памяти
		}

		private void Button_Draw_Graf_Click(object sender, EventArgs e) // построение графика
		{
			double xmin = 0.1, xmax = 5.0, dx = 0.2, xi, ymin = 0, ymax = 0, yi;
			int N = 0; // количество точек графика
					   // ищем пределы У для согласования координат
			for (xi = xmin; xi <= xmax; xi += dx)
			{
				//yi = xi / (1 + Math.Abs(Math.Sin(xi)));
				yi = Math.Cos(xi) / (1 + xi);
				if (xi == xmin)  // первая точка
				{ ymin = yi; ymax = yi; }
				else
				{
					if (yi < ymin) ymin = yi;
					if (yi > ymax) ymax = yi;
				}
				N++; // увеличиваем количество точек массива координат
			}

			// коэффициенты уравнения для согласования физических (x,y) и экранных (X,Y) координат

			double W = Convert.ToDouble(pictureBox1.Width);
			double Xmin = W / 10, Xmax = W * 0.9;

			double H = Convert.ToDouble(pictureBox1.Height);
			double Ymin = 0.9 * H, Ymax = 0.1 * H;

			double kX = (Xmax - Xmin) / (xmax - xmin);
			double kY = (Ymax - Ymin) / (ymax - ymin);

			Graphics G = pictureBox1.CreateGraphics();
			Pen P = new Pen(label_Color_Marker.ForeColor);
			Brush B = new SolidBrush(label_Color_Marker.BackColor);

			// строим маркеры и заполняем массив координат

			Point[] YX = new Point[N];

			int i = 0; // индекс массива
			for (xi = xmin; xi <= xmax; xi += dx)
			{
				//yi = xi / (1 + Math.Abs(Math.Sin(xi)));
				yi = Math.Cos(xi) / (1 + xi);
				YX[i].X = (int)(Xmin + kX * (xi - xmin));
				YX[i].Y = (int)(Ymin + kY * (yi - ymin));

				Rectangle R = new Rectangle();  // определяем прямоугольник - границу
												// маркера
				R.Width = (int)numericUpDown_Width_Marker.Value;    // ширина маркера
				R.Height = (int)numericUpDown_Width_Marker.Value;   // высота маркера
				R.X = YX[i].X - R.Width / 2; R.Y = (int)YX[i].Y - R.Height / 2;  // левый
																				 // верхний угол

				if (radioButton_Circle.Checked) // маркер - окружность
				{
					if (checkBox_Fill.Checked) // закрашиваем окружность цветом фона
					{ G.FillEllipse(B, R); }
					G.DrawEllipse(P, R); // рисуем окружность-границу цветом пера
				}

				if (radioButton_Rectangle.Checked) // маркер - квадрат
				{
					if (checkBox_Fill.Checked) // закрашиваем маркер
					{ G.FillRectangle(B, R); }
					G.DrawRectangle(P, R); // рисуем квадрат
				}

				if (radioButton_Brush.Checked) // маркер - кисть
				{
					G.FillEllipse(B, R); // закрашиваем окружность
				}

				i++; // конец цикла - увеличиваем номер точки в массива
			}

			G.DrawLines(P, YX); // строим отрезки по занесенным координатам

			G.Dispose(); P.Dispose(); B.Dispose(); // освобождаем память
		}

		// Щелчок мышью по графической зоне (режим редактора)
		private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
		{
			Graphics G = pictureBox1.CreateGraphics(); // определяем графическую зону
			Pen P = new Pen(label_Color_Marker.ForeColor);  // перо для границ маркеров
			Brush B = new SolidBrush(label_Color_Marker.BackColor);  // кисть для заливки

			if (radioButton_Pset.Checked) // маркер - точка
			{
				float x = (float)e.Location.X; float y = (float)e.Location.Y;
				G.DrawLine(P, x, y, x + 1, y + 1); // точка – отрезок длиной 1 пиксель
				return; // выход из модуля
			}

			Rectangle R = new Rectangle();  // определяем прямоугольник - границу маркера
			R.Width = (int)numericUpDown_Width_Marker.Value;    // ширина маркера
			R.Height = (int)numericUpDown_Width_Marker.Value;   // высота маркера
			R.X = e.X - R.Width / 2; R.Y = e.Y - R.Height / 2;  // левый верхний угол

			if (radioButton_Circle.Checked) // маркер - окружность
			{
				if (checkBox_Fill.Checked) // включен режим закраски
				{ G.FillEllipse(B, R); } // закрашиваем окружность
				G.DrawEllipse(P, R); // рисуем границу окружности
			}

			if (radioButton_Rectangle.Checked) // маркер - квадрат
			{
				if (checkBox_Fill.Checked) // закрашиваем маркер
				{ G.FillRectangle(B, R); }
				G.DrawRectangle(P, R); // рисуем квадрат
			}

			if (radioButton_Brush.Checked) // маркер - кисть
			{
				G.FillEllipse(B, R); // закрашиваем фон маркера
			}
			G.Dispose(); P.Dispose(); B.Dispose();  // освобождаем память
		}

		// перемещение нажатого указателя мыши
		private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button.ToString() == "Right") // нажата правая кнопка мыши
			{
				// имитируем щелчок мыши по графическому окну
				PictureBox1_MouseClick(sender, e);
			}
		}

		#endregion График
	}
}