namespace WindowsFormsApp1
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.label1 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.TP_Chart = new System.Windows.Forms.TabPage();
			this.label4 = new System.Windows.Forms.Label();
			this.button_Zapoln = new System.Windows.Forms.Button();
			this.button_Create_Diagr = new System.Windows.Forms.Button();
			this.pictureBoxVar = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.listBox_X = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.numericUpDown_Tip = new System.Windows.Forms.NumericUpDown();
			this.listBox_Y = new System.Windows.Forms.ListBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton_Column = new System.Windows.Forms.RadioButton();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton_arifm = new System.Windows.Forms.RadioButton();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.button_Picture_Clear = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button_Draw_Fig = new System.Windows.Forms.Button();
			this.button_Picture_Back = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label_Color_Marker = new System.Windows.Forms.Label();
			this.numericUpDown_Width_Marker = new System.Windows.Forms.NumericUpDown();
			this.radioButton_Brush = new System.Windows.Forms.RadioButton();
			this.checkBox_Fill = new System.Windows.Forms.CheckBox();
			this.radioButton_Rectangle = new System.Windows.Forms.RadioButton();
			this.radioButton_Circle = new System.Windows.Forms.RadioButton();
			this.radioButton_Pset = new System.Windows.Forms.RadioButton();
			this.button_Draw_Graf = new System.Windows.Forms.Button();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.tabControl1.SuspendLayout();
			this.TP_Chart.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxVar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Tip)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Width_Marker)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(162, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Группа _ _ _ Вариант 7";
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.TP_Chart);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(12, 25);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(776, 313);
			this.tabControl1.TabIndex = 1;
			// 
			// TP_Chart
			// 
			this.TP_Chart.Controls.Add(this.label4);
			this.TP_Chart.Controls.Add(this.button_Zapoln);
			this.TP_Chart.Controls.Add(this.button_Create_Diagr);
			this.TP_Chart.Controls.Add(this.pictureBoxVar);
			this.TP_Chart.Controls.Add(this.label3);
			this.TP_Chart.Controls.Add(this.listBox_X);
			this.TP_Chart.Controls.Add(this.label2);
			this.TP_Chart.Controls.Add(this.numericUpDown_Tip);
			this.TP_Chart.Controls.Add(this.listBox_Y);
			this.TP_Chart.Controls.Add(this.groupBox2);
			this.TP_Chart.Controls.Add(this.chart1);
			this.TP_Chart.Controls.Add(this.groupBox1);
			this.TP_Chart.Location = new System.Drawing.Point(4, 22);
			this.TP_Chart.Name = "TP_Chart";
			this.TP_Chart.Padding = new System.Windows.Forms.Padding(3);
			this.TP_Chart.Size = new System.Drawing.Size(768, 287);
			this.TP_Chart.TabIndex = 0;
			this.TP_Chart.Text = "Диаграммы - элемент Chart";
			this.TP_Chart.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(358, 237);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(118, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Тип диаграммы (0-10)";
			// 
			// button_Zapoln
			// 
			this.button_Zapoln.Location = new System.Drawing.Point(189, 214);
			this.button_Zapoln.Name = "button_Zapoln";
			this.button_Zapoln.Size = new System.Drawing.Size(79, 23);
			this.button_Zapoln.TabIndex = 9;
			this.button_Zapoln.Text = "Заполнить";
			this.button_Zapoln.UseVisualStyleBackColor = true;
			this.button_Zapoln.Click += new System.EventHandler(this.Button_Zapoln_Click);
			// 
			// button_Create_Diagr
			// 
			this.button_Create_Diagr.Location = new System.Drawing.Point(47, 207);
			this.button_Create_Diagr.Name = "button_Create_Diagr";
			this.button_Create_Diagr.Size = new System.Drawing.Size(96, 47);
			this.button_Create_Diagr.TabIndex = 8;
			this.button_Create_Diagr.Text = "Построить диаграмму";
			this.button_Create_Diagr.UseVisualStyleBackColor = true;
			this.button_Create_Diagr.Click += new System.EventHandler(this.Button_Create_Diagr_Click);
			// 
			// pictureBoxVar
			// 
			this.pictureBoxVar.Image = global::Lab6_2D.Properties.Resources.WINWORD_20_11_03_09_20_28;
			this.pictureBoxVar.Location = new System.Drawing.Point(6, 6);
			this.pictureBoxVar.Name = "pictureBoxVar";
			this.pictureBoxVar.Size = new System.Drawing.Size(175, 50);
			this.pictureBoxVar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxVar.TabIndex = 7;
			this.pictureBoxVar.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(302, 6);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(14, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Y";
			// 
			// listBox_X
			// 
			this.listBox_X.FormattingEnabled = true;
			this.listBox_X.Location = new System.Drawing.Point(189, 22);
			this.listBox_X.Name = "listBox_X";
			this.listBox_X.Size = new System.Drawing.Size(79, 186);
			this.listBox_X.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(221, 6);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(14, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "X";
			// 
			// numericUpDown_Tip
			// 
			this.numericUpDown_Tip.Location = new System.Drawing.Point(482, 235);
			this.numericUpDown_Tip.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDown_Tip.Name = "numericUpDown_Tip";
			this.numericUpDown_Tip.Size = new System.Drawing.Size(46, 20);
			this.numericUpDown_Tip.TabIndex = 4;
			// 
			// listBox_Y
			// 
			this.listBox_Y.FormattingEnabled = true;
			this.listBox_Y.Location = new System.Drawing.Point(276, 22);
			this.listBox_Y.Name = "listBox_Y";
			this.listBox_Y.Size = new System.Drawing.Size(79, 186);
			this.listBox_Y.TabIndex = 3;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.radioButton3);
			this.groupBox2.Controls.Add(this.radioButton_Column);
			this.groupBox2.Location = new System.Drawing.Point(6, 136);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(175, 65);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Вид диаграммы";
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.Checked = true;
			this.radioButton3.Location = new System.Drawing.Point(6, 42);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(118, 17);
			this.radioButton3.TabIndex = 1;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "Точечная (график)";
			this.radioButton3.UseVisualStyleBackColor = true;
			// 
			// radioButton_Column
			// 
			this.radioButton_Column.AutoSize = true;
			this.radioButton_Column.Location = new System.Drawing.Point(6, 19);
			this.radioButton_Column.Name = "radioButton_Column";
			this.radioButton_Column.Size = new System.Drawing.Size(93, 17);
			this.radioButton_Column.TabIndex = 0;
			this.radioButton_Column.TabStop = true;
			this.radioButton_Column.Text = "Гистограмма";
			this.radioButton_Column.UseVisualStyleBackColor = true;
			// 
			// chart1
			// 
			this.chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.FrameThin3;
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(361, 6);
			this.chart1.Name = "chart1";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.chart1.Series.Add(series1);
			this.chart1.Size = new System.Drawing.Size(401, 223);
			this.chart1.TabIndex = 1;
			this.chart1.Text = "chart1";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton_arifm);
			this.groupBox1.Location = new System.Drawing.Point(6, 62);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(175, 68);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Прогрессия аргумента X";
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Checked = true;
			this.radioButton2.Location = new System.Drawing.Point(6, 42);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(109, 17);
			this.radioButton2.TabIndex = 1;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Геометрическая";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton_arifm
			// 
			this.radioButton_arifm.AutoSize = true;
			this.radioButton_arifm.Location = new System.Drawing.Point(6, 19);
			this.radioButton_arifm.Name = "radioButton_arifm";
			this.radioButton_arifm.Size = new System.Drawing.Size(112, 17);
			this.radioButton_arifm.TabIndex = 0;
			this.radioButton_arifm.Text = "Арифметическая";
			this.radioButton_arifm.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.button_Picture_Clear);
			this.tabPage2.Controls.Add(this.pictureBox1);
			this.tabPage2.Controls.Add(this.button_Draw_Fig);
			this.tabPage2.Controls.Add(this.button_Picture_Back);
			this.tabPage2.Controls.Add(this.groupBox3);
			this.tabPage2.Controls.Add(this.button_Draw_Graf);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(768, 287);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Графика - элемент PictureBox";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// button_Picture_Clear
			// 
			this.button_Picture_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button_Picture_Clear.Location = new System.Drawing.Point(687, 251);
			this.button_Picture_Clear.Name = "button_Picture_Clear";
			this.button_Picture_Clear.Size = new System.Drawing.Size(75, 30);
			this.button_Picture_Clear.TabIndex = 6;
			this.button_Picture_Clear.Text = "Очистить";
			this.button_Picture_Clear.UseVisualStyleBackColor = true;
			this.button_Picture_Clear.Click += new System.EventHandler(this.Button_Picture_Clear_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(143, 6);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(619, 239);
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseClick);
			this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
			// 
			// button_Draw_Fig
			// 
			this.button_Draw_Fig.Location = new System.Drawing.Point(384, 251);
			this.button_Draw_Fig.Name = "button_Draw_Fig";
			this.button_Draw_Fig.Size = new System.Drawing.Size(118, 30);
			this.button_Draw_Fig.TabIndex = 4;
			this.button_Draw_Fig.Text = "Построить фигуру";
			this.button_Draw_Fig.UseVisualStyleBackColor = true;
			this.button_Draw_Fig.Click += new System.EventHandler(this.Button_Draw_Fig_Click);
			// 
			// button_Picture_Back
			// 
			this.button_Picture_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button_Picture_Back.BackColor = System.Drawing.Color.White;
			this.button_Picture_Back.Location = new System.Drawing.Point(143, 251);
			this.button_Picture_Back.Name = "button_Picture_Back";
			this.button_Picture_Back.Size = new System.Drawing.Size(75, 30);
			this.button_Picture_Back.TabIndex = 3;
			this.button_Picture_Back.Text = "Фон окна";
			this.button_Picture_Back.UseVisualStyleBackColor = false;
			this.button_Picture_Back.Click += new System.EventHandler(this.Button_Picture_Back_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.label_Color_Marker);
			this.groupBox3.Controls.Add(this.numericUpDown_Width_Marker);
			this.groupBox3.Controls.Add(this.radioButton_Brush);
			this.groupBox3.Controls.Add(this.checkBox_Fill);
			this.groupBox3.Controls.Add(this.radioButton_Rectangle);
			this.groupBox3.Controls.Add(this.radioButton_Circle);
			this.groupBox3.Controls.Add(this.radioButton_Pset);
			this.groupBox3.Location = new System.Drawing.Point(6, 6);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(116, 180);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Маркеры";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 113);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(46, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Размер";
			// 
			// label_Color_Marker
			// 
			this.label_Color_Marker.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label_Color_Marker.AutoSize = true;
			this.label_Color_Marker.BackColor = System.Drawing.Color.YellowGreen;
			this.label_Color_Marker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label_Color_Marker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label_Color_Marker.ForeColor = System.Drawing.Color.DarkGreen;
			this.label_Color_Marker.Location = new System.Drawing.Point(33, 157);
			this.label_Color_Marker.Name = "label_Color_Marker";
			this.label_Color_Marker.Size = new System.Drawing.Size(50, 15);
			this.label_Color_Marker.TabIndex = 3;
			this.label_Color_Marker.Text = " ЦВЕТ ";
			this.label_Color_Marker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label_Color_Marker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Label_Color_Marker_MouseClick);
			// 
			// numericUpDown_Width_Marker
			// 
			this.numericUpDown_Width_Marker.Location = new System.Drawing.Point(58, 111);
			this.numericUpDown_Width_Marker.Name = "numericUpDown_Width_Marker";
			this.numericUpDown_Width_Marker.Size = new System.Drawing.Size(46, 20);
			this.numericUpDown_Width_Marker.TabIndex = 4;
			this.numericUpDown_Width_Marker.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// radioButton_Brush
			// 
			this.radioButton_Brush.AutoSize = true;
			this.radioButton_Brush.Location = new System.Drawing.Point(6, 88);
			this.radioButton_Brush.Name = "radioButton_Brush";
			this.radioButton_Brush.Size = new System.Drawing.Size(55, 17);
			this.radioButton_Brush.TabIndex = 4;
			this.radioButton_Brush.Text = "Кисть";
			this.radioButton_Brush.UseVisualStyleBackColor = true;
			// 
			// checkBox_Fill
			// 
			this.checkBox_Fill.AutoSize = true;
			this.checkBox_Fill.Location = new System.Drawing.Point(10, 137);
			this.checkBox_Fill.Name = "checkBox_Fill";
			this.checkBox_Fill.Size = new System.Drawing.Size(94, 17);
			this.checkBox_Fill.TabIndex = 3;
			this.checkBox_Fill.Text = "Закрашивать";
			this.checkBox_Fill.UseVisualStyleBackColor = true;
			// 
			// radioButton_Rectangle
			// 
			this.radioButton_Rectangle.AutoSize = true;
			this.radioButton_Rectangle.Location = new System.Drawing.Point(6, 65);
			this.radioButton_Rectangle.Name = "radioButton_Rectangle";
			this.radioButton_Rectangle.Size = new System.Drawing.Size(67, 17);
			this.radioButton_Rectangle.TabIndex = 3;
			this.radioButton_Rectangle.Text = "Квадрат";
			this.radioButton_Rectangle.UseVisualStyleBackColor = true;
			// 
			// radioButton_Circle
			// 
			this.radioButton_Circle.AutoSize = true;
			this.radioButton_Circle.Location = new System.Drawing.Point(6, 42);
			this.radioButton_Circle.Name = "radioButton_Circle";
			this.radioButton_Circle.Size = new System.Drawing.Size(87, 17);
			this.radioButton_Circle.TabIndex = 2;
			this.radioButton_Circle.Text = "Окружность";
			this.radioButton_Circle.UseVisualStyleBackColor = true;
			// 
			// radioButton_Pset
			// 
			this.radioButton_Pset.AutoSize = true;
			this.radioButton_Pset.Checked = true;
			this.radioButton_Pset.Location = new System.Drawing.Point(6, 19);
			this.radioButton_Pset.Name = "radioButton_Pset";
			this.radioButton_Pset.Size = new System.Drawing.Size(55, 17);
			this.radioButton_Pset.TabIndex = 1;
			this.radioButton_Pset.TabStop = true;
			this.radioButton_Pset.Text = "Точка";
			this.radioButton_Pset.UseVisualStyleBackColor = true;
			// 
			// button_Draw_Graf
			// 
			this.button_Draw_Graf.Location = new System.Drawing.Point(3, 251);
			this.button_Draw_Graf.Name = "button_Draw_Graf";
			this.button_Draw_Graf.Size = new System.Drawing.Size(75, 30);
			this.button_Draw_Graf.TabIndex = 0;
			this.button_Draw_Graf.Text = "График";
			this.button_Draw_Graf.UseVisualStyleBackColor = true;
			this.button_Draw_Graf.Click += new System.EventHandler(this.Button_Draw_Graf_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 350);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Lab_6: 2D-графика на C#";
			this.tabControl1.ResumeLayout(false);
			this.TP_Chart.ResumeLayout(false);
			this.TP_Chart.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxVar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Tip)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Width_Marker)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage TP_Chart;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.PictureBox pictureBoxVar;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListBox listBox_X;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown numericUpDown_Tip;
		private System.Windows.Forms.ListBox listBox_Y;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton_Column;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton_arifm;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button_Zapoln;
		private System.Windows.Forms.Button button_Create_Diagr;
		private System.Windows.Forms.Button button_Picture_Clear;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button_Draw_Fig;
		private System.Windows.Forms.Button button_Picture_Back;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label_Color_Marker;
		private System.Windows.Forms.NumericUpDown numericUpDown_Width_Marker;
		private System.Windows.Forms.RadioButton radioButton_Brush;
		private System.Windows.Forms.CheckBox checkBox_Fill;
		private System.Windows.Forms.RadioButton radioButton_Rectangle;
		private System.Windows.Forms.RadioButton radioButton_Circle;
		private System.Windows.Forms.RadioButton radioButton_Pset;
		private System.Windows.Forms.Button button_Draw_Graf;
	}
}

