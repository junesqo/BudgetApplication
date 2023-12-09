namespace BudgetApplication
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
            this.nameField = new System.Windows.Forms.TextBox();
            this.costField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.GroupBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.addData = new System.Windows.Forms.Button();
            this.genReport = new System.Windows.Forms.Button();
            this.pieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.nameErrorLabel = new System.Windows.Forms.Label();
            this.costErrorLabel = new System.Windows.Forms.Label();
            this.radioButtonError = new System.Windows.Forms.Label();
            this.billsTotallbl = new System.Windows.Forms.Label();
            this.foodTotallbl = new System.Windows.Forms.Label();
            this.autoTotallbl = new System.Windows.Forms.Label();
            this.entertainmentTotallbl = new System.Windows.Forms.Label();
            this.investmentTotallbl = new System.Windows.Forms.Label();
            this.shoppingTotallbl = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the text";
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(42, 48);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(100, 20);
            this.nameField.TabIndex = 1;
            // 
            // costField
            // 
            this.costField.Location = new System.Drawing.Point(42, 106);
            this.costField.Name = "costField";
            this.costField.Size = new System.Drawing.Size(100, 20);
            this.costField.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter the cost";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton6);
            this.panel1.Controls.Add(this.radioButton5);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(42, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 172);
            this.panel1.TabIndex = 4;
            this.panel1.TabStop = false;
            this.panel1.Text = "groupBox1";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(7, 140);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(70, 17);
            this.radioButton6.TabIndex = 5;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Shopping";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(7, 116);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(82, 17);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Investments";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(7, 92);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(90, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Entertainment";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 68);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(47, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Auto";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 44);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(49, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Food";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(43, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Bills";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // addData
            // 
            this.addData.Location = new System.Drawing.Point(42, 339);
            this.addData.Name = "addData";
            this.addData.Size = new System.Drawing.Size(131, 23);
            this.addData.TabIndex = 5;
            this.addData.Text = "Add data";
            this.addData.UseVisualStyleBackColor = true;
            this.addData.Click += new System.EventHandler(this.addData_Click);
            // 
            // genReport
            // 
            this.genReport.Location = new System.Drawing.Point(42, 380);
            this.genReport.Name = "genReport";
            this.genReport.Size = new System.Drawing.Size(131, 23);
            this.genReport.TabIndex = 6;
            this.genReport.Text = "Generate Report";
            this.genReport.UseVisualStyleBackColor = true;
            this.genReport.Click += new System.EventHandler(this.genReport_Click);
            // 
            // pieChart
            // 
            chartArea1.Name = "ChartArea1";
            this.pieChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.pieChart.Legends.Add(legend1);
            this.pieChart.Location = new System.Drawing.Point(415, 48);
            this.pieChart.Name = "pieChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "s1";
            this.pieChart.Series.Add(series1);
            this.pieChart.Size = new System.Drawing.Size(300, 300);
            this.pieChart.TabIndex = 8;
            this.pieChart.Text = "chart1";
            this.pieChart.Click += new System.EventHandler(this.chart1_Click);
            // 
            // nameErrorLabel
            // 
            this.nameErrorLabel.AutoSize = true;
            this.nameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.nameErrorLabel.Location = new System.Drawing.Point(179, 54);
            this.nameErrorLabel.Name = "nameErrorLabel";
            this.nameErrorLabel.Size = new System.Drawing.Size(35, 13);
            this.nameErrorLabel.TabIndex = 9;
            this.nameErrorLabel.Text = "label3";
            // 
            // costErrorLabel
            // 
            this.costErrorLabel.AutoSize = true;
            this.costErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.costErrorLabel.Location = new System.Drawing.Point(182, 112);
            this.costErrorLabel.Name = "costErrorLabel";
            this.costErrorLabel.Size = new System.Drawing.Size(35, 13);
            this.costErrorLabel.TabIndex = 10;
            this.costErrorLabel.Text = "label4";
            this.costErrorLabel.Click += new System.EventHandler(this.CostError_Click);
            // 
            // radioButtonError
            // 
            this.radioButtonError.AutoSize = true;
            this.radioButtonError.ForeColor = System.Drawing.Color.Red;
            this.radioButtonError.Location = new System.Drawing.Point(248, 219);
            this.radioButtonError.Name = "radioButtonError";
            this.radioButtonError.Size = new System.Drawing.Size(35, 13);
            this.radioButtonError.TabIndex = 11;
            this.radioButtonError.Text = "label3";
            // 
            // billsTotallbl
            // 
            this.billsTotallbl.AutoSize = true;
            this.billsTotallbl.Location = new System.Drawing.Point(747, 54);
            this.billsTotallbl.Name = "billsTotallbl";
            this.billsTotallbl.Size = new System.Drawing.Size(28, 13);
            this.billsTotallbl.TabIndex = 12;
            this.billsTotallbl.Text = "Bills:";
            // 
            // foodTotallbl
            // 
            this.foodTotallbl.AutoSize = true;
            this.foodTotallbl.Location = new System.Drawing.Point(750, 71);
            this.foodTotallbl.Name = "foodTotallbl";
            this.foodTotallbl.Size = new System.Drawing.Size(34, 13);
            this.foodTotallbl.TabIndex = 13;
            this.foodTotallbl.Text = "Food:";
            // 
            // autoTotallbl
            // 
            this.autoTotallbl.AutoSize = true;
            this.autoTotallbl.Location = new System.Drawing.Point(750, 90);
            this.autoTotallbl.Name = "autoTotallbl";
            this.autoTotallbl.Size = new System.Drawing.Size(32, 13);
            this.autoTotallbl.TabIndex = 14;
            this.autoTotallbl.Text = "Auto:";
            // 
            // entertainmentTotallbl
            // 
            this.entertainmentTotallbl.AutoSize = true;
            this.entertainmentTotallbl.Location = new System.Drawing.Point(750, 112);
            this.entertainmentTotallbl.Name = "entertainmentTotallbl";
            this.entertainmentTotallbl.Size = new System.Drawing.Size(75, 13);
            this.entertainmentTotallbl.TabIndex = 15;
            this.entertainmentTotallbl.Text = "Entertainment:";
            // 
            // investmentTotallbl
            // 
            this.investmentTotallbl.AutoSize = true;
            this.investmentTotallbl.Location = new System.Drawing.Point(750, 138);
            this.investmentTotallbl.Name = "investmentTotallbl";
            this.investmentTotallbl.Size = new System.Drawing.Size(67, 13);
            this.investmentTotallbl.TabIndex = 16;
            this.investmentTotallbl.Text = "Investments:";
            // 
            // shoppingTotallbl
            // 
            this.shoppingTotallbl.AutoSize = true;
            this.shoppingTotallbl.Location = new System.Drawing.Point(750, 155);
            this.shoppingTotallbl.Name = "shoppingTotallbl";
            this.shoppingTotallbl.Size = new System.Drawing.Size(55, 13);
            this.shoppingTotallbl.TabIndex = 17;
            this.shoppingTotallbl.Text = "Shopping:";
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(42, 441);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(100, 20);
            this.outputBox.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.shoppingTotallbl);
            this.Controls.Add(this.investmentTotallbl);
            this.Controls.Add(this.entertainmentTotallbl);
            this.Controls.Add(this.autoTotallbl);
            this.Controls.Add(this.foodTotallbl);
            this.Controls.Add(this.billsTotallbl);
            this.Controls.Add(this.radioButtonError);
            this.Controls.Add(this.costErrorLabel);
            this.Controls.Add(this.nameErrorLabel);
            this.Controls.Add(this.pieChart);
            this.Controls.Add(this.genReport);
            this.Controls.Add(this.addData);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.costField);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.TextBox costField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox panel1;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button addData;
        private System.Windows.Forms.Button genReport;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieChart;
        private System.Windows.Forms.Label nameErrorLabel;
        private System.Windows.Forms.Label costErrorLabel;
        private System.Windows.Forms.Label radioButtonError;
        private System.Windows.Forms.Label billsTotallbl;
        private System.Windows.Forms.Label foodTotallbl;
        private System.Windows.Forms.Label autoTotallbl;
        private System.Windows.Forms.Label entertainmentTotallbl;
        private System.Windows.Forms.Label investmentTotallbl;
        private System.Windows.Forms.Label shoppingTotallbl;
        private System.Windows.Forms.TextBox outputBox;
    }
}

