namespace Coursework2._0
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.funcBox = new System.Windows.Forms.TextBox();
            this.leftBox = new System.Windows.Forms.TextBox();
            this.rightBox = new System.Windows.Forms.TextBox();
            this.epsilonBox = new System.Windows.Forms.TextBox();
            this.fileNameBox = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.startbtn = new System.Windows.Forms.Button();
            this.filepathbtn = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.redbtn = new System.Windows.Forms.Button();
            this.indigobtn = new System.Windows.Forms.Button();
            this.linebtn = new System.Windows.Forms.Button();
            this.bluebtn = new System.Windows.Forms.Button();
            this.orangebtn = new System.Windows.Forms.Button();
            this.goldbtn = new System.Windows.Forms.Button();
            this.thickBox = new System.Windows.Forms.TextBox();
            this.graphStepBox = new System.Windows.Forms.TextBox();
            this.graphbtn = new System.Windows.Forms.Button();
            this.circlebtn = new System.Windows.Forms.Button();
            this.squarebtn = new System.Windows.Forms.Button();
            this.diamondbtn = new System.Windows.Forms.Button();
            this.starbtn = new System.Windows.Forms.Button();
            this.filePathBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // funcBox
            // 
            this.funcBox.Location = new System.Drawing.Point(151, 138);
            this.funcBox.Name = "funcBox";
            this.funcBox.Size = new System.Drawing.Size(388, 31);
            this.funcBox.TabIndex = 0;
            this.funcBox.TextChanged += new System.EventHandler(this.funcBox_TextChanged);
            // 
            // leftBox
            // 
            this.leftBox.Location = new System.Drawing.Point(151, 234);
            this.leftBox.Name = "leftBox";
            this.leftBox.Size = new System.Drawing.Size(100, 31);
            this.leftBox.TabIndex = 1;
            this.leftBox.TextChanged += new System.EventHandler(this.leftBox_TextChanged);
            // 
            // rightBox
            // 
            this.rightBox.Location = new System.Drawing.Point(151, 312);
            this.rightBox.Name = "rightBox";
            this.rightBox.Size = new System.Drawing.Size(100, 31);
            this.rightBox.TabIndex = 2;
            this.rightBox.TextChanged += new System.EventHandler(this.rightBox_TextChanged);
            // 
            // epsilonBox
            // 
            this.epsilonBox.Location = new System.Drawing.Point(151, 386);
            this.epsilonBox.Name = "epsilonBox";
            this.epsilonBox.Size = new System.Drawing.Size(100, 31);
            this.epsilonBox.TabIndex = 3;
            this.epsilonBox.TextChanged += new System.EventHandler(this.epsilonBox_TextChanged);
            // 
            // fileNameBox
            // 
            this.fileNameBox.Location = new System.Drawing.Point(151, 475);
            this.fileNameBox.Name = "fileNameBox";
            this.fileNameBox.Size = new System.Drawing.Size(178, 31);
            this.fileNameBox.TabIndex = 4;
            this.fileNameBox.TextChanged += new System.EventHandler(this.fileNameBox_TextChanged);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // startbtn
            // 
            this.startbtn.Location = new System.Drawing.Point(374, 271);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(165, 109);
            this.startbtn.TabIndex = 5;
            this.startbtn.Text = "Start!";
            this.startbtn.UseVisualStyleBackColor = true;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // filepathbtn
            // 
            this.filepathbtn.Location = new System.Drawing.Point(358, 533);
            this.filepathbtn.Name = "filepathbtn";
            this.filepathbtn.Size = new System.Drawing.Size(118, 76);
            this.filepathbtn.TabIndex = 6;
            this.filepathbtn.Text = "Where to put file";
            this.filepathbtn.UseVisualStyleBackColor = true;
            this.filepathbtn.Click += new System.EventHandler(this.filepathbtn_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(1007, 33);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Color = System.Drawing.Color.Navy;
            series2.Legend = "Legend1";
            series2.Name = "f(x)";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(725, 535);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // redbtn
            // 
            this.redbtn.BackColor = System.Drawing.Color.Red;
            this.redbtn.Location = new System.Drawing.Point(893, 33);
            this.redbtn.Name = "redbtn";
            this.redbtn.Size = new System.Drawing.Size(35, 35);
            this.redbtn.TabIndex = 8;
            this.redbtn.UseVisualStyleBackColor = false;
            this.redbtn.Click += new System.EventHandler(this.redbtn_Click);
            // 
            // indigobtn
            // 
            this.indigobtn.BackColor = System.Drawing.Color.Indigo;
            this.indigobtn.Location = new System.Drawing.Point(956, 65);
            this.indigobtn.Name = "indigobtn";
            this.indigobtn.Size = new System.Drawing.Size(35, 35);
            this.indigobtn.TabIndex = 13;
            this.indigobtn.UseVisualStyleBackColor = false;
            this.indigobtn.Click += new System.EventHandler(this.indigobtn_Click);
            // 
            // linebtn
            // 
            this.linebtn.BackColor = System.Drawing.Color.Lime;
            this.linebtn.Location = new System.Drawing.Point(893, 65);
            this.linebtn.Name = "linebtn";
            this.linebtn.Size = new System.Drawing.Size(35, 35);
            this.linebtn.TabIndex = 11;
            this.linebtn.UseVisualStyleBackColor = false;
            this.linebtn.Click += new System.EventHandler(this.linebtn_Click);
            // 
            // bluebtn
            // 
            this.bluebtn.BackColor = System.Drawing.Color.Blue;
            this.bluebtn.Location = new System.Drawing.Point(924, 65);
            this.bluebtn.Name = "bluebtn";
            this.bluebtn.Size = new System.Drawing.Size(35, 35);
            this.bluebtn.TabIndex = 14;
            this.bluebtn.UseVisualStyleBackColor = false;
            this.bluebtn.Click += new System.EventHandler(this.bluebtn_Click);
            // 
            // orangebtn
            // 
            this.orangebtn.BackColor = System.Drawing.Color.Orange;
            this.orangebtn.Location = new System.Drawing.Point(924, 33);
            this.orangebtn.Name = "orangebtn";
            this.orangebtn.Size = new System.Drawing.Size(35, 35);
            this.orangebtn.TabIndex = 15;
            this.orangebtn.UseVisualStyleBackColor = false;
            this.orangebtn.Click += new System.EventHandler(this.orangebtn_Click);
            // 
            // goldbtn
            // 
            this.goldbtn.BackColor = System.Drawing.Color.Gold;
            this.goldbtn.Location = new System.Drawing.Point(956, 33);
            this.goldbtn.Name = "goldbtn";
            this.goldbtn.Size = new System.Drawing.Size(35, 35);
            this.goldbtn.TabIndex = 16;
            this.goldbtn.UseVisualStyleBackColor = false;
            this.goldbtn.Click += new System.EventHandler(this.goldbtn_Click);
            // 
            // thickBox
            // 
            this.thickBox.Location = new System.Drawing.Point(893, 122);
            this.thickBox.Name = "thickBox";
            this.thickBox.Size = new System.Drawing.Size(98, 31);
            this.thickBox.TabIndex = 17;
            this.thickBox.TextChanged += new System.EventHandler(this.thickBox_TextChanged);
            this.thickBox.Leave += new System.EventHandler(this.thickBox_Leave);
            // 
            // graphStepBox
            // 
            this.graphStepBox.Location = new System.Drawing.Point(1288, 590);
            this.graphStepBox.Name = "graphStepBox";
            this.graphStepBox.Size = new System.Drawing.Size(165, 31);
            this.graphStepBox.TabIndex = 18;
            this.graphStepBox.TextChanged += new System.EventHandler(this.graphStepBox_TextChanged);
            // 
            // graphbtn
            // 
            this.graphbtn.Location = new System.Drawing.Point(1288, 638);
            this.graphbtn.Name = "graphbtn";
            this.graphbtn.Size = new System.Drawing.Size(165, 82);
            this.graphbtn.TabIndex = 20;
            this.graphbtn.Text = "Построить график!";
            this.graphbtn.UseVisualStyleBackColor = true;
            this.graphbtn.Click += new System.EventHandler(this.graphbtn_Click);
            // 
            // circlebtn
            // 
            this.circlebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circlebtn.BackgroundImage")));
            this.circlebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.circlebtn.Location = new System.Drawing.Point(817, 260);
            this.circlebtn.Name = "circlebtn";
            this.circlebtn.Size = new System.Drawing.Size(111, 120);
            this.circlebtn.TabIndex = 22;
            this.circlebtn.UseVisualStyleBackColor = true;
            this.circlebtn.Click += new System.EventHandler(this.circlebtn_Click);
            // 
            // squarebtn
            // 
            this.squarebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("squarebtn.BackgroundImage")));
            this.squarebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.squarebtn.Location = new System.Drawing.Point(817, 386);
            this.squarebtn.Name = "squarebtn";
            this.squarebtn.Size = new System.Drawing.Size(111, 120);
            this.squarebtn.TabIndex = 23;
            this.squarebtn.UseVisualStyleBackColor = true;
            this.squarebtn.Click += new System.EventHandler(this.squarebtn_Click);
            // 
            // diamondbtn
            // 
            this.diamondbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("diamondbtn.BackgroundImage")));
            this.diamondbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.diamondbtn.Location = new System.Drawing.Point(817, 521);
            this.diamondbtn.Name = "diamondbtn";
            this.diamondbtn.Size = new System.Drawing.Size(111, 120);
            this.diamondbtn.TabIndex = 24;
            this.diamondbtn.UseVisualStyleBackColor = true;
            this.diamondbtn.Click += new System.EventHandler(this.diamondbtn_Click);
            // 
            // starbtn
            // 
            this.starbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("starbtn.BackgroundImage")));
            this.starbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.starbtn.Location = new System.Drawing.Point(817, 657);
            this.starbtn.Name = "starbtn";
            this.starbtn.Size = new System.Drawing.Size(111, 74);
            this.starbtn.TabIndex = 25;
            this.starbtn.UseVisualStyleBackColor = true;
            this.starbtn.Click += new System.EventHandler(this.starbtn_Click);
            // 
            // filePathBox
            // 
            this.filePathBox.Location = new System.Drawing.Point(151, 537);
            this.filePathBox.Multiline = true;
            this.filePathBox.Name = "filePathBox";
            this.filePathBox.Size = new System.Drawing.Size(178, 72);
            this.filePathBox.TabIndex = 26;
            this.filePathBox.TextChanged += new System.EventHandler(this.filePathBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "f(x) =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Left border";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Right border";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "Accuracy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 478);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "File name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1193, 593);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 25);
            this.label6.TabIndex = 32;
            this.label6.Text = "Step";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(784, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 25);
            this.label7.TabIndex = 33;
            this.label7.Text = "Dot size";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1782, 862);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filePathBox);
            this.Controls.Add(this.starbtn);
            this.Controls.Add(this.diamondbtn);
            this.Controls.Add(this.squarebtn);
            this.Controls.Add(this.circlebtn);
            this.Controls.Add(this.graphbtn);
            this.Controls.Add(this.graphStepBox);
            this.Controls.Add(this.thickBox);
            this.Controls.Add(this.goldbtn);
            this.Controls.Add(this.orangebtn);
            this.Controls.Add(this.bluebtn);
            this.Controls.Add(this.indigobtn);
            this.Controls.Add(this.linebtn);
            this.Controls.Add(this.redbtn);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.filepathbtn);
            this.Controls.Add(this.startbtn);
            this.Controls.Add(this.fileNameBox);
            this.Controls.Add(this.epsilonBox);
            this.Controls.Add(this.rightBox);
            this.Controls.Add(this.leftBox);
            this.Controls.Add(this.funcBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox funcBox;
        private System.Windows.Forms.TextBox leftBox;
        private System.Windows.Forms.TextBox rightBox;
        private System.Windows.Forms.TextBox epsilonBox;
        private System.Windows.Forms.TextBox fileNameBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.Button filepathbtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button redbtn;
        private System.Windows.Forms.Button indigobtn;
        private System.Windows.Forms.Button linebtn;
        private System.Windows.Forms.Button bluebtn;
        private System.Windows.Forms.Button orangebtn;
        private System.Windows.Forms.Button goldbtn;
        private System.Windows.Forms.TextBox thickBox;
        private System.Windows.Forms.TextBox graphStepBox;
        private System.Windows.Forms.Button graphbtn;
        private System.Windows.Forms.Button circlebtn;
        private System.Windows.Forms.Button squarebtn;
        private System.Windows.Forms.Button diamondbtn;
        private System.Windows.Forms.Button starbtn;
        private System.Windows.Forms.TextBox filePathBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

