namespace BankingApp
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.btnWithDraw = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.tbAccountName = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.tmrWithDraw = new System.Windows.Forms.Timer(this.components);
            this.btnEmptyMyAccount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(121, 228);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(163, 25);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Bank account info";
            // 
            // nudAmount
            // 
            this.nudAmount.Location = new System.Drawing.Point(121, 72);
            this.nudAmount.Margin = new System.Windows.Forms.Padding(5);
            this.nudAmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(189, 33);
            this.nudAmount.TabIndex = 1;
            // 
            // btnWithDraw
            // 
            this.btnWithDraw.Location = new System.Drawing.Point(121, 148);
            this.btnWithDraw.Name = "btnWithDraw";
            this.btnWithDraw.Size = new System.Drawing.Size(118, 45);
            this.btnWithDraw.TabIndex = 2;
            this.btnWithDraw.Text = "Withdraw";
            this.btnWithDraw.UseVisualStyleBackColor = true;
            this.btnWithDraw.Click += new System.EventHandler(this.btnWithDraw_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(273, 148);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(99, 47);
            this.btnDeposit.TabIndex = 3;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // tbAccountName
            // 
            this.tbAccountName.Location = new System.Drawing.Point(123, 24);
            this.tbAccountName.Name = "tbAccountName";
            this.tbAccountName.Size = new System.Drawing.Size(249, 33);
            this.tbAccountName.TabIndex = 4;
            this.tbAccountName.TextChanged += new System.EventHandler(this.tbAccountName_TextChanged);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(123, 276);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(78, 25);
            this.lblBalance.TabIndex = 5;
            this.lblBalance.Text = "Balance";
            // 
            // tmrWithDraw
            // 
            this.tmrWithDraw.Interval = 1000;
            this.tmrWithDraw.Tick += new System.EventHandler(this.tmrWithDraw_Tick);
            // 
            // btnEmptyMyAccount
            // 
            this.btnEmptyMyAccount.Location = new System.Drawing.Point(453, 148);
            this.btnEmptyMyAccount.Name = "btnEmptyMyAccount";
            this.btnEmptyMyAccount.Size = new System.Drawing.Size(289, 48);
            this.btnEmptyMyAccount.TabIndex = 6;
            this.btnEmptyMyAccount.Text = "Empty my account";
            this.btnEmptyMyAccount.UseVisualStyleBackColor = true;
            this.btnEmptyMyAccount.Click += new System.EventHandler(this.btnEmptyMyAccount_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 369);
            this.Controls.Add(this.btnEmptyMyAccount);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.tbAccountName);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnWithDraw);
            this.Controls.Add(this.nudAmount);
            this.Controls.Add(this.lblInfo);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.Text = "Banking App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.Button btnWithDraw;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.TextBox tbAccountName;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Timer tmrWithDraw;
        private System.Windows.Forms.Button btnEmptyMyAccount;
    }
}
