
namespace PetAnimationApp
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.tmrAnimation = new System.Windows.Forms.Timer(this.components);
            this.pbPet = new System.Windows.Forms.PictureBox();
            this.btnAnimate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStopwatch = new System.Windows.Forms.Button();
            this.lblStopwatch = new System.Windows.Forms.Label();
            this.tmrStopwatch = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbPet)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrAnimation
            // 
            this.tmrAnimation.Interval = 10;
            this.tmrAnimation.Tick += new System.EventHandler(this.tmrAnimation_Tick);
            // 
            // pbPet
            // 
            this.pbPet.Image = global::PetAnimationApp.Properties.Resources.pokemon_go;
            this.pbPet.Location = new System.Drawing.Point(44, 58);
            this.pbPet.Margin = new System.Windows.Forms.Padding(5);
            this.pbPet.Name = "pbPet";
            this.pbPet.Size = new System.Drawing.Size(321, 157);
            this.pbPet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbPet.TabIndex = 0;
            this.pbPet.TabStop = false;
            // 
            // btnAnimate
            // 
            this.btnAnimate.Location = new System.Drawing.Point(41, 245);
            this.btnAnimate.Margin = new System.Windows.Forms.Padding(5);
            this.btnAnimate.Name = "btnAnimate";
            this.btnAnimate.Size = new System.Drawing.Size(118, 38);
            this.btnAnimate.TabIndex = 1;
            this.btnAnimate.Text = "Animate";
            this.btnAnimate.UseVisualStyleBackColor = true;
            this.btnAnimate.Click += new System.EventHandler(this.btnAnimate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(197, 245);
            this.btnReset.Margin = new System.Windows.Forms.Padding(5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(118, 38);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStopwatch
            // 
            this.btnStopwatch.Location = new System.Drawing.Point(353, 245);
            this.btnStopwatch.Margin = new System.Windows.Forms.Padding(5);
            this.btnStopwatch.Name = "btnStopwatch";
            this.btnStopwatch.Size = new System.Drawing.Size(118, 38);
            this.btnStopwatch.TabIndex = 3;
            this.btnStopwatch.Text = "Start watch";
            this.btnStopwatch.UseVisualStyleBackColor = true;
            this.btnStopwatch.Click += new System.EventHandler(this.btnStopwatch_Click);
            // 
            // lblStopwatch
            // 
            this.lblStopwatch.AutoSize = true;
            this.lblStopwatch.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStopwatch.Location = new System.Drawing.Point(514, 245);
            this.lblStopwatch.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStopwatch.Name = "lblStopwatch";
            this.lblStopwatch.Size = new System.Drawing.Size(33, 37);
            this.lblStopwatch.TabIndex = 4;
            this.lblStopwatch.Text = "0";
            // 
            // tmrStopwatch
            // 
            this.tmrStopwatch.Interval = 1000;
            this.tmrStopwatch.Tick += new System.EventHandler(this.tmrStopwatch_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 311);
            this.Controls.Add(this.lblStopwatch);
            this.Controls.Add(this.btnStopwatch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAnimate);
            this.Controls.Add(this.pbPet);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.Text = "Timer";
            ((System.ComponentModel.ISupportInitialize)(this.pbPet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrAnimation;
        private System.Windows.Forms.PictureBox pbPet;
        private System.Windows.Forms.Button btnAnimate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStopwatch;
        private System.Windows.Forms.Label lblStopwatch;
        private System.Windows.Forms.Timer tmrStopwatch;
    }
}

