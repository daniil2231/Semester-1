namespace ManagementApp
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
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlTopLeft = new System.Windows.Forms.GroupBox();
            this.btnCreateBooking = new System.Windows.Forms.Button();
            this.lbBeeGroups = new System.Windows.Forms.ListBox();
            this.pnlTopRight = new System.Windows.Forms.GroupBox();
            this.btnViewHoneycomb = new System.Windows.Forms.Button();
            this.tbNumberOfCells = new System.Windows.Forms.TextBox();
            this.cbBeeTypes = new System.Windows.Forms.ComboBox();
            this.lbHoneycombs = new System.Windows.Forms.ListBox();
            this.btnAddHoneycomb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlTopLeft.SuspendLayout();
            this.pnlTopRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::ManagementApp.Properties.Resources.Honeycomb;
            this.pbLogo.Location = new System.Drawing.Point(13, 352);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(340, 148);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // pnlTopLeft
            // 
            this.pnlTopLeft.Controls.Add(this.btnCreateBooking);
            this.pnlTopLeft.Controls.Add(this.lbBeeGroups);
            this.pnlTopLeft.Location = new System.Drawing.Point(13, 12);
            this.pnlTopLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTopLeft.Name = "pnlTopLeft";
            this.pnlTopLeft.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTopLeft.Size = new System.Drawing.Size(415, 332);
            this.pnlTopLeft.TabIndex = 2;
            this.pnlTopLeft.TabStop = false;
            this.pnlTopLeft.Text = "Bee groups";
            // 
            // btnCreateBooking
            // 
            this.btnCreateBooking.Enabled = false;
            this.btnCreateBooking.Location = new System.Drawing.Point(25, 276);
            this.btnCreateBooking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateBooking.Name = "btnCreateBooking";
            this.btnCreateBooking.Size = new System.Drawing.Size(192, 47);
            this.btnCreateBooking.TabIndex = 15;
            this.btnCreateBooking.Text = "Create booking";
            this.btnCreateBooking.UseVisualStyleBackColor = true;
            this.btnCreateBooking.Click += new System.EventHandler(this.btnCreateBooking_Click);
            // 
            // lbBeeGroups
            // 
            this.lbBeeGroups.FormattingEnabled = true;
            this.lbBeeGroups.ItemHeight = 16;
            this.lbBeeGroups.Location = new System.Drawing.Point(25, 23);
            this.lbBeeGroups.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbBeeGroups.Name = "lbBeeGroups";
            this.lbBeeGroups.Size = new System.Drawing.Size(377, 244);
            this.lbBeeGroups.TabIndex = 1;
            this.lbBeeGroups.SelectedIndexChanged += new System.EventHandler(this.lbBeeGroups_SelectedIndexChanged);
            // 
            // pnlTopRight
            // 
            this.pnlTopRight.Controls.Add(this.btnViewHoneycomb);
            this.pnlTopRight.Controls.Add(this.tbNumberOfCells);
            this.pnlTopRight.Controls.Add(this.cbBeeTypes);
            this.pnlTopRight.Controls.Add(this.lbHoneycombs);
            this.pnlTopRight.Controls.Add(this.btnAddHoneycomb);
            this.pnlTopRight.Location = new System.Drawing.Point(456, 15);
            this.pnlTopRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTopRight.Name = "pnlTopRight";
            this.pnlTopRight.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTopRight.Size = new System.Drawing.Size(685, 457);
            this.pnlTopRight.TabIndex = 3;
            this.pnlTopRight.TabStop = false;
            this.pnlTopRight.Text = "Honeycombs";
            // 
            // btnViewHoneycomb
            // 
            this.btnViewHoneycomb.Enabled = false;
            this.btnViewHoneycomb.Location = new System.Drawing.Point(501, 271);
            this.btnViewHoneycomb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViewHoneycomb.Name = "btnViewHoneycomb";
            this.btnViewHoneycomb.Size = new System.Drawing.Size(168, 49);
            this.btnViewHoneycomb.TabIndex = 2;
            this.btnViewHoneycomb.Text = "View info";
            this.btnViewHoneycomb.UseVisualStyleBackColor = true;
            this.btnViewHoneycomb.Click += new System.EventHandler(this.btnViewHoneycomb_Click);
            // 
            // tbNumberOfCells
            // 
            this.tbNumberOfCells.Location = new System.Drawing.Point(16, 385);
            this.tbNumberOfCells.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNumberOfCells.Name = "tbNumberOfCells";
            this.tbNumberOfCells.Size = new System.Drawing.Size(344, 22);
            this.tbNumberOfCells.TabIndex = 14;
            this.tbNumberOfCells.Text = "250";
            // 
            // cbBeeTypes
            // 
            this.cbBeeTypes.FormattingEnabled = true;
            this.cbBeeTypes.Location = new System.Drawing.Point(16, 338);
            this.cbBeeTypes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbBeeTypes.Name = "cbBeeTypes";
            this.cbBeeTypes.Size = new System.Drawing.Size(344, 24);
            this.cbBeeTypes.TabIndex = 13;
            this.cbBeeTypes.Text = "Bee types";
            // 
            // lbHoneycombs
            // 
            this.lbHoneycombs.FormattingEnabled = true;
            this.lbHoneycombs.ItemHeight = 16;
            this.lbHoneycombs.Location = new System.Drawing.Point(16, 21);
            this.lbHoneycombs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbHoneycombs.Name = "lbHoneycombs";
            this.lbHoneycombs.Size = new System.Drawing.Size(652, 228);
            this.lbHoneycombs.TabIndex = 2;
            this.lbHoneycombs.SelectedIndexChanged += new System.EventHandler(this.lbHoneycombs_SelectedIndexChanged);
            // 
            // btnAddHoneycomb
            // 
            this.btnAddHoneycomb.Location = new System.Drawing.Point(16, 271);
            this.btnAddHoneycomb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddHoneycomb.Name = "btnAddHoneycomb";
            this.btnAddHoneycomb.Size = new System.Drawing.Size(180, 49);
            this.btnAddHoneycomb.TabIndex = 1;
            this.btnAddHoneycomb.Text = "Add honeycomb";
            this.btnAddHoneycomb.UseVisualStyleBackColor = true;
            this.btnAddHoneycomb.Click += new System.EventHandler(this.btnAddHoneycomb_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 517);
            this.Controls.Add(this.pnlTopRight);
            this.Controls.Add(this.pnlTopLeft);
            this.Controls.Add(this.pbLogo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "AirBeeNBee Management";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlTopLeft.ResumeLayout(false);
            this.pnlTopRight.ResumeLayout(false);
            this.pnlTopRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.GroupBox pnlTopLeft;
        private System.Windows.Forms.ListBox lbBeeGroups;
        private System.Windows.Forms.GroupBox pnlTopRight;
        private System.Windows.Forms.ListBox lbHoneycombs;
        private System.Windows.Forms.Button btnAddHoneycomb;
        private System.Windows.Forms.Button btnCreateBooking;
        private System.Windows.Forms.TextBox tbNumberOfCells;
        private System.Windows.Forms.ComboBox cbBeeTypes;
        private System.Windows.Forms.Button btnViewHoneycomb;
    }
}
