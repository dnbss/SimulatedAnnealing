namespace AnnealingWinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.maxTemperatureNumeric = new System.Windows.Forms.NumericUpDown();
            this.minTemperatureNumeric = new System.Windows.Forms.NumericUpDown();
            this.cRatioNumeric = new System.Windows.Forms.NumericUpDown();
            this.graphPictureBox = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.resultGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.animationNumeric = new System.Windows.Forms.NumericUpDown();
            this.iterationResultButton = new System.Windows.Forms.RadioButton();
            this.endedResultButton = new System.Windows.Forms.RadioButton();
            this.matrixGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.maxRandomNumeric = new System.Windows.Forms.NumericUpDown();
            this.isSimmetricCheckBox = new System.Windows.Forms.CheckBox();
            this.randomWeightsButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.countVertex = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sumWeightLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.shortestPathLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.maxTemperatureNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minTemperatureNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRatioNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphPictureBox)).BeginInit();
            this.resultGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animationNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxRandomNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countVertex)).BeginInit();
            this.SuspendLayout();
            // 
            // maxTemperatureNumeric
            // 
            this.maxTemperatureNumeric.Location = new System.Drawing.Point(158, 39);
            this.maxTemperatureNumeric.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.maxTemperatureNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxTemperatureNumeric.Name = "maxTemperatureNumeric";
            this.maxTemperatureNumeric.Size = new System.Drawing.Size(88, 27);
            this.maxTemperatureNumeric.TabIndex = 0;
            this.maxTemperatureNumeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.maxTemperatureNumeric.ValueChanged += new System.EventHandler(this.maxTemperatureNumeric_ValueChanged);
            // 
            // minTemperatureNumeric
            // 
            this.minTemperatureNumeric.Location = new System.Drawing.Point(158, 100);
            this.minTemperatureNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minTemperatureNumeric.Name = "minTemperatureNumeric";
            this.minTemperatureNumeric.Size = new System.Drawing.Size(88, 27);
            this.minTemperatureNumeric.TabIndex = 1;
            this.minTemperatureNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cRatioNumeric
            // 
            this.cRatioNumeric.Location = new System.Drawing.Point(158, 155);
            this.cRatioNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cRatioNumeric.Name = "cRatioNumeric";
            this.cRatioNumeric.Size = new System.Drawing.Size(88, 27);
            this.cRatioNumeric.TabIndex = 2;
            this.cRatioNumeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // graphPictureBox
            // 
            this.graphPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphPictureBox.Location = new System.Drawing.Point(352, 28);
            this.graphPictureBox.Name = "graphPictureBox";
            this.graphPictureBox.Size = new System.Drawing.Size(580, 504);
            this.graphPictureBox.TabIndex = 3;
            this.graphPictureBox.TabStop = false;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(111, 415);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(94, 29);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Запуск";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // resultGroupBox
            // 
            this.resultGroupBox.Controls.Add(this.label1);
            this.resultGroupBox.Controls.Add(this.animationNumeric);
            this.resultGroupBox.Controls.Add(this.iterationResultButton);
            this.resultGroupBox.Controls.Add(this.endedResultButton);
            this.resultGroupBox.Location = new System.Drawing.Point(12, 211);
            this.resultGroupBox.Name = "resultGroupBox";
            this.resultGroupBox.Size = new System.Drawing.Size(314, 165);
            this.resultGroupBox.TabIndex = 5;
            this.resultGroupBox.TabStop = false;
            this.resultGroupBox.Text = "Способ отображения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Скорость анимации";
            // 
            // animationNumeric
            // 
            this.animationNumeric.Location = new System.Drawing.Point(205, 116);
            this.animationNumeric.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.animationNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.animationNumeric.Name = "animationNumeric";
            this.animationNumeric.Size = new System.Drawing.Size(72, 27);
            this.animationNumeric.TabIndex = 2;
            this.animationNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // iterationResultButton
            // 
            this.iterationResultButton.AutoSize = true;
            this.iterationResultButton.Location = new System.Drawing.Point(6, 116);
            this.iterationResultButton.Name = "iterationResultButton";
            this.iterationResultButton.Size = new System.Drawing.Size(121, 24);
            this.iterationResultButton.TabIndex = 1;
            this.iterationResultButton.TabStop = true;
            this.iterationResultButton.Text = "По итерации";
            this.iterationResultButton.UseVisualStyleBackColor = true;
            // 
            // endedResultButton
            // 
            this.endedResultButton.AutoSize = true;
            this.endedResultButton.Location = new System.Drawing.Point(6, 43);
            this.endedResultButton.Name = "endedResultButton";
            this.endedResultButton.Size = new System.Drawing.Size(173, 24);
            this.endedResultButton.TabIndex = 0;
            this.endedResultButton.TabStop = true;
            this.endedResultButton.Text = "Конечный результат";
            this.endedResultButton.UseVisualStyleBackColor = true;
            // 
            // matrixGridView
            // 
            this.matrixGridView.AllowUserToAddRows = false;
            this.matrixGridView.AllowUserToDeleteRows = false;
            this.matrixGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.matrixGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixGridView.Location = new System.Drawing.Point(954, 28);
            this.matrixGridView.MultiSelect = false;
            this.matrixGridView.Name = "matrixGridView";
            this.matrixGridView.RowHeadersWidth = 51;
            this.matrixGridView.RowTemplate.Height = 29;
            this.matrixGridView.Size = new System.Drawing.Size(296, 250);
            this.matrixGridView.TabIndex = 17;
            this.matrixGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.matrixGridView_CellValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(954, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Максимальное значение веса";
            // 
            // maxRandomNumeric
            // 
            this.maxRandomNumeric.Location = new System.Drawing.Point(954, 379);
            this.maxRandomNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.maxRandomNumeric.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.maxRandomNumeric.Name = "maxRandomNumeric";
            this.maxRandomNumeric.Size = new System.Drawing.Size(83, 27);
            this.maxRandomNumeric.TabIndex = 24;
            this.maxRandomNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.maxRandomNumeric.ValueChanged += new System.EventHandler(this.maxRandomNumeric_ValueChanged);
            // 
            // isSimmetricCheckBox
            // 
            this.isSimmetricCheckBox.AutoSize = true;
            this.isSimmetricCheckBox.Location = new System.Drawing.Point(1212, 299);
            this.isSimmetricCheckBox.Name = "isSimmetricCheckBox";
            this.isSimmetricCheckBox.Size = new System.Drawing.Size(200, 24);
            this.isSimmetricCheckBox.TabIndex = 23;
            this.isSimmetricCheckBox.Text = "Симметричная матрица";
            this.isSimmetricCheckBox.UseVisualStyleBackColor = true;
            this.isSimmetricCheckBox.CheckedChanged += new System.EventHandler(this.isSimmetricCheckBox_CheckedChanged);
            // 
            // randomWeightsButton
            // 
            this.randomWeightsButton.Location = new System.Drawing.Point(954, 299);
            this.randomWeightsButton.Name = "randomWeightsButton";
            this.randomWeightsButton.Size = new System.Drawing.Size(238, 29);
            this.randomWeightsButton.TabIndex = 22;
            this.randomWeightsButton.Text = "Сгенерировать случайные веса";
            this.randomWeightsButton.UseVisualStyleBackColor = true;
            this.randomWeightsButton.Click += new System.EventHandler(this.randomWeightsButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1231, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Количество вершин";
            // 
            // countVertex
            // 
            this.countVertex.Location = new System.Drawing.Point(1232, 379);
            this.countVertex.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.countVertex.Name = "countVertex";
            this.countVertex.Size = new System.Drawing.Size(86, 27);
            this.countVertex.TabIndex = 20;
            this.countVertex.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.countVertex.ValueChanged += new System.EventHandler(this.countVertex_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Макс. температура";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Мин. температура";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Коеффициент C";
            // 
            // sumWeightLabel
            // 
            this.sumWeightLabel.AutoSize = true;
            this.sumWeightLabel.Location = new System.Drawing.Point(594, 585);
            this.sumWeightLabel.Name = "sumWeightLabel";
            this.sumWeightLabel.Size = new System.Drawing.Size(58, 20);
            this.sumWeightLabel.TabIndex = 35;
            this.sumWeightLabel.Text = "label13";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(352, 585);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(172, 20);
            this.label12.TabIndex = 34;
            this.label12.Text = "Суммарный вес цикла: ";
            // 
            // shortestPathLabel
            // 
            this.shortestPathLabel.AutoSize = true;
            this.shortestPathLabel.Location = new System.Drawing.Point(594, 548);
            this.shortestPathLabel.Name = "shortestPathLabel";
            this.shortestPathLabel.Size = new System.Drawing.Size(58, 20);
            this.shortestPathLabel.TabIndex = 33;
            this.shortestPathLabel.Text = "label12";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(352, 548);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(236, 20);
            this.label11.TabIndex = 32;
            this.label11.Text = "Кратчайший Гамильтонов цикл: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 621);
            this.Controls.Add(this.sumWeightLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.shortestPathLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maxRandomNumeric);
            this.Controls.Add(this.isSimmetricCheckBox);
            this.Controls.Add(this.randomWeightsButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.countVertex);
            this.Controls.Add(this.matrixGridView);
            this.Controls.Add(this.resultGroupBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.graphPictureBox);
            this.Controls.Add(this.cRatioNumeric);
            this.Controls.Add(this.minTemperatureNumeric);
            this.Controls.Add(this.maxTemperatureNumeric);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.maxTemperatureNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minTemperatureNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRatioNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphPictureBox)).EndInit();
            this.resultGroupBox.ResumeLayout(false);
            this.resultGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animationNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxRandomNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countVertex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown maxTemperatureNumeric;
        private NumericUpDown minTemperatureNumeric;
        private NumericUpDown cRatioNumeric;
        private PictureBox graphPictureBox;
        private Button startButton;
        private GroupBox resultGroupBox;
        private Label label1;
        private NumericUpDown animationNumeric;
        private RadioButton iterationResultButton;
        private RadioButton endedResultButton;
        private DataGridView matrixGridView;
        private Label label5;
        private NumericUpDown maxRandomNumeric;
        private CheckBox isSimmetricCheckBox;
        private Button randomWeightsButton;
        private Label label6;
        private NumericUpDown countVertex;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label sumWeightLabel;
        private Label label12;
        private Label shortestPathLabel;
        private Label label11;
    }
}