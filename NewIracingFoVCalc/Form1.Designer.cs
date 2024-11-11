namespace NewIracingFoVCalc
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxScreenWidth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDistanceToScreen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxScreenAngle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMonitorCurvature = new System.Windows.Forms.TextBox();
            this.buttonCalculateFOV = new System.Windows.Forms.Button();
            this.labelFOVResult = new System.Windows.Forms.Label();
            this.comboBoxScreenSetup = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxMonitorType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Screen Width (w/o bezels in mm)";
            // 
            // textBoxScreenWidth
            // 
            this.textBoxScreenWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxScreenWidth.Location = new System.Drawing.Point(504, 191);
            this.textBoxScreenWidth.Name = "textBoxScreenWidth";
            this.textBoxScreenWidth.Size = new System.Drawing.Size(199, 30);
            this.textBoxScreenWidth.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Screen Setup (Single or Triple)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Distance to Screen (mm)";
            // 
            // textBoxDistanceToScreen
            // 
            this.textBoxDistanceToScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDistanceToScreen.Location = new System.Drawing.Point(504, 139);
            this.textBoxDistanceToScreen.Name = "textBoxDistanceToScreen";
            this.textBoxDistanceToScreen.Size = new System.Drawing.Size(199, 30);
            this.textBoxDistanceToScreen.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Screen Angle (degrees)";
            // 
            // textBoxScreenAngle
            // 
            this.textBoxScreenAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxScreenAngle.Location = new System.Drawing.Point(504, 94);
            this.textBoxScreenAngle.Name = "textBoxScreenAngle";
            this.textBoxScreenAngle.Size = new System.Drawing.Size(199, 30);
            this.textBoxScreenAngle.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(362, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Monitor Curvature (radius in mm, R):";
            // 
            // textBoxMonitorCurvature
            // 
            this.textBoxMonitorCurvature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMonitorCurvature.Location = new System.Drawing.Point(504, 286);
            this.textBoxMonitorCurvature.Name = "textBoxMonitorCurvature";
            this.textBoxMonitorCurvature.Size = new System.Drawing.Size(199, 30);
            this.textBoxMonitorCurvature.TabIndex = 9;
            // 
            // buttonCalculateFOV
            // 
            this.buttonCalculateFOV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculateFOV.Location = new System.Drawing.Point(69, 369);
            this.buttonCalculateFOV.Name = "buttonCalculateFOV";
            this.buttonCalculateFOV.Size = new System.Drawing.Size(179, 51);
            this.buttonCalculateFOV.TabIndex = 10;
            this.buttonCalculateFOV.Text = "Calculate FOV";
            this.buttonCalculateFOV.UseVisualStyleBackColor = true;
            this.buttonCalculateFOV.Click += new System.EventHandler(this.buttonCalculateFOV_Click);
            // 
            // labelFOVResult
            // 
            this.labelFOVResult.AutoSize = true;
            this.labelFOVResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFOVResult.Location = new System.Drawing.Point(499, 382);
            this.labelFOVResult.Name = "labelFOVResult";
            this.labelFOVResult.Size = new System.Drawing.Size(64, 25);
            this.labelFOVResult.TabIndex = 11;
            this.labelFOVResult.Text = "FOV:";
            // 
            // comboBoxScreenSetup
            // 
            this.comboBoxScreenSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxScreenSetup.FormattingEnabled = true;
            this.comboBoxScreenSetup.Items.AddRange(new object[] {
            "Single",
            "Triple"});
            this.comboBoxScreenSetup.Location = new System.Drawing.Point(504, 46);
            this.comboBoxScreenSetup.Name = "comboBoxScreenSetup";
            this.comboBoxScreenSetup.Size = new System.Drawing.Size(199, 33);
            this.comboBoxScreenSetup.TabIndex = 12;
            this.comboBoxScreenSetup.SelectedIndexChanged += new System.EventHandler(this.comboBoxScreenSetup_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(305, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Monitor Type (Flat or Curved):";
            // 
            // comboBoxMonitorType
            // 
            this.comboBoxMonitorType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMonitorType.FormattingEnabled = true;
            this.comboBoxMonitorType.Items.AddRange(new object[] {
            "Flat",
            "Curved"});
            this.comboBoxMonitorType.Location = new System.Drawing.Point(504, 238);
            this.comboBoxMonitorType.Name = "comboBoxMonitorType";
            this.comboBoxMonitorType.Size = new System.Drawing.Size(199, 33);
            this.comboBoxMonitorType.TabIndex = 14;
            this.comboBoxMonitorType.SelectedIndexChanged += new System.EventHandler(this.comboBoxMonitorType_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxMonitorType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxScreenSetup);
            this.Controls.Add(this.labelFOVResult);
            this.Controls.Add(this.buttonCalculateFOV);
            this.Controls.Add(this.textBoxMonitorCurvature);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxScreenAngle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDistanceToScreen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxScreenWidth);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "iRacing FoV Calculator by GenX George";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxScreenWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDistanceToScreen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxScreenAngle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMonitorCurvature;
        private System.Windows.Forms.Button buttonCalculateFOV;
        private System.Windows.Forms.Label labelFOVResult;
        private System.Windows.Forms.ComboBox comboBoxScreenSetup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxMonitorType;
    }
}

