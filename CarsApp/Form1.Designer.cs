namespace Week14_Practice
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
            this.cbbCars = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowInfo = new System.Windows.Forms.Button();
            this.btnBreak = new System.Windows.Forms.Button();
            this.btnAccelerate = new System.Windows.Forms.Button();
            this.nudSpeed = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbCars
            // 
            this.cbbCars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCars.FormattingEnabled = true;
            this.cbbCars.Location = new System.Drawing.Point(170, 12);
            this.cbbCars.Margin = new System.Windows.Forms.Padding(6);
            this.cbbCars.Name = "cbbCars";
            this.cbbCars.Size = new System.Drawing.Size(288, 33);
            this.cbbCars.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a car:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudSpeed);
            this.groupBox1.Controls.Add(this.btnShowInfo);
            this.groupBox1.Controls.Add(this.btnBreak);
            this.groupBox1.Controls.Add(this.btnAccelerate);
            this.groupBox1.Location = new System.Drawing.Point(30, 63);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(432, 192);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.Location = new System.Drawing.Point(12, 131);
            this.btnShowInfo.Margin = new System.Windows.Forms.Padding(6);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(398, 44);
            this.btnShowInfo.TabIndex = 4;
            this.btnShowInfo.Text = "Show info";
            this.btnShowInfo.UseVisualStyleBackColor = true;
            this.btnShowInfo.Click += new System.EventHandler(this.btnShowInfo_Click);
            // 
            // btnBreak
            // 
            this.btnBreak.Location = new System.Drawing.Point(12, 77);
            this.btnBreak.Margin = new System.Windows.Forms.Padding(6);
            this.btnBreak.Name = "btnBreak";
            this.btnBreak.Size = new System.Drawing.Size(398, 44);
            this.btnBreak.TabIndex = 3;
            this.btnBreak.Text = "Break";
            this.btnBreak.UseVisualStyleBackColor = true;
            this.btnBreak.Click += new System.EventHandler(this.btnBreak_Click);
            // 
            // btnAccelerate
            // 
            this.btnAccelerate.Location = new System.Drawing.Point(140, 27);
            this.btnAccelerate.Margin = new System.Windows.Forms.Padding(6);
            this.btnAccelerate.Name = "btnAccelerate";
            this.btnAccelerate.Size = new System.Drawing.Size(270, 44);
            this.btnAccelerate.TabIndex = 2;
            this.btnAccelerate.Text = "Accelerate ";
            this.btnAccelerate.UseVisualStyleBackColor = true;
            this.btnAccelerate.Click += new System.EventHandler(this.btnAccelerate_Click);
            // 
            // nudSpeed
            // 
            this.nudSpeed.Location = new System.Drawing.Point(12, 35);
            this.nudSpeed.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudSpeed.Name = "nudSpeed";
            this.nudSpeed.Size = new System.Drawing.Size(120, 31);
            this.nudSpeed.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 279);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbCars);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Car form";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbCars;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnShowInfo;
        private System.Windows.Forms.Button btnBreak;
        private System.Windows.Forms.Button btnAccelerate;
        private System.Windows.Forms.NumericUpDown nudSpeed;
    }
}

