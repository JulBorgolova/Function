namespace FunctionPlotter
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxFunctions;
        private System.Windows.Forms.TextBox textBoxParameters;
        private System.Windows.Forms.TextBox textBoxXStart;
        private System.Windows.Forms.TextBox textBoxXEnd;
        private System.Windows.Forms.TextBox textBoxYStart;
        private System.Windows.Forms.TextBox textBoxYEnd;
        private System.Windows.Forms.Button btnPlot;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.comboBoxFunctions = new System.Windows.Forms.ComboBox();
            this.textBoxParameters = new System.Windows.Forms.TextBox();
            this.textBoxXStart = new System.Windows.Forms.TextBox();
            this.textBoxXEnd = new System.Windows.Forms.TextBox();
            this.textBoxYStart = new System.Windows.Forms.TextBox();
            this.textBoxYEnd = new System.Windows.Forms.TextBox();
            this.btnPlot = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxFunctions
            // 
            this.comboBoxFunctions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFunctions.FormattingEnabled = true;
            this.comboBoxFunctions.Items.AddRange(new object[] {
            "linear",
            "quadratic",
            "cubic",
            "sinus",
            "cosinus",
            "tangent",
            "cotangent",
            "exp",
            "log"});
            this.comboBoxFunctions.Location = new System.Drawing.Point(12, 29);
            this.comboBoxFunctions.Name = "comboBoxFunctions";
            this.comboBoxFunctions.Size = new System.Drawing.Size(121, 24);
            this.comboBoxFunctions.TabIndex = 0;
            // 
            // textBoxParameters
            // 
            this.textBoxParameters.Location = new System.Drawing.Point(139, 29);
            this.textBoxParameters.Name = "textBoxParameters";
            this.textBoxParameters.Size = new System.Drawing.Size(100, 22);
            this.textBoxParameters.TabIndex = 1;
            // 
            // textBoxXStart
            // 
            this.textBoxXStart.Location = new System.Drawing.Point(245, 29);
            this.textBoxXStart.Name = "textBoxXStart";
            this.textBoxXStart.Size = new System.Drawing.Size(50, 22);
            this.textBoxXStart.TabIndex = 2;
            // 
            // textBoxXEnd
            // 
            this.textBoxXEnd.Location = new System.Drawing.Point(301, 29);
            this.textBoxXEnd.Name = "textBoxXEnd";
            this.textBoxXEnd.Size = new System.Drawing.Size(50, 22);
            this.textBoxXEnd.TabIndex = 3;
            // 
            // textBoxYStart
            // 
            this.textBoxYStart.Location = new System.Drawing.Point(357, 29);
            this.textBoxYStart.Name = "textBoxYStart";
            this.textBoxYStart.Size = new System.Drawing.Size(50, 22);
            this.textBoxYStart.TabIndex = 4;
            // 
            // textBoxYEnd
            // 
            this.textBoxYEnd.Location = new System.Drawing.Point(413, 29);
            this.textBoxYEnd.Name = "textBoxYEnd";
            this.textBoxYEnd.Size = new System.Drawing.Size(50, 22);
            this.textBoxYEnd.TabIndex = 5;
            // 
            // btnPlot
            // 
            this.btnPlot.Location = new System.Drawing.Point(469, 27);
            this.btnPlot.Name = "btnPlot";
            this.btnPlot.Size = new System.Drawing.Size(111, 23);
            this.btnPlot.TabIndex = 6;
            this.btnPlot.Text = "Построить";
            this.btnPlot.UseVisualStyleBackColor = true;
            this.btnPlot.Click += new System.EventHandler(this.btnPlot_Click);
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart.Location = new System.Drawing.Point(12, 70);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(780, 460);
            this.chart.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Тип функции:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Параметры:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "X Start:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "X End:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Y Start:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(413, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Y End:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(586, 27);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Сохранить PNG";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(804, 541);
            this.Controls.Add(this.comboBoxFunctions);
            this.Controls.Add(this.textBoxParameters);
            this.Controls.Add(this.textBoxXStart);
            this.Controls.Add(this.textBoxXEnd);
            this.Controls.Add(this.textBoxYStart);
            this.Controls.Add(this.textBoxYEnd);
            this.Controls.Add(this.btnPlot);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Name = "Form1";
            this.Text = "Function Plotter";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
