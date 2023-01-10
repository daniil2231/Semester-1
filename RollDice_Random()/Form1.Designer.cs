
namespace Week14_PracticalAssignment6
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
            this.lblDiceAmount = new System.Windows.Forms.Label();
            this.tbDiceAmount = new System.Windows.Forms.TextBox();
            this.btnRollDice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDiceAmount
            // 
            this.lblDiceAmount.AutoSize = true;
            this.lblDiceAmount.Location = new System.Drawing.Point(25, 42);
            this.lblDiceAmount.Name = "lblDiceAmount";
            this.lblDiceAmount.Size = new System.Drawing.Size(145, 17);
            this.lblDiceAmount.TabIndex = 0;
            this.lblDiceAmount.Text = "Amount of dice to roll:";
            // 
            // tbDiceAmount
            // 
            this.tbDiceAmount.Location = new System.Drawing.Point(167, 42);
            this.tbDiceAmount.Name = "tbDiceAmount";
            this.tbDiceAmount.Size = new System.Drawing.Size(100, 22);
            this.tbDiceAmount.TabIndex = 1;
            // 
            // btnRollDice
            // 
            this.btnRollDice.Location = new System.Drawing.Point(82, 79);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(113, 37);
            this.btnRollDice.TabIndex = 2;
            this.btnRollDice.Text = "Roll dice";
            this.btnRollDice.UseVisualStyleBackColor = true;
            this.btnRollDice.Click += new System.EventHandler(this.btnRollDice_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 128);
            this.Controls.Add(this.btnRollDice);
            this.Controls.Add(this.tbDiceAmount);
            this.Controls.Add(this.lblDiceAmount);
            this.Name = "Form1";
            this.Text = "Roll";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDiceAmount;
        private System.Windows.Forms.TextBox tbDiceAmount;
        private System.Windows.Forms.Button btnRollDice;
    }
}

