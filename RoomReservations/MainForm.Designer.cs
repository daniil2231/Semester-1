namespace S_Week14_Reservation
{
    partial class MainForm
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
            this.tabHotelManagement = new System.Windows.Forms.TabControl();
            this.tabManage = new System.Windows.Forms.TabPage();
            this.btnAddReservation = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.rbNonSmoking = new System.Windows.Forms.RadioButton();
            this.rbSmoking = new System.Windows.Forms.RadioButton();
            this.cbRoomType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumberOfNights = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tabReservations = new System.Windows.Forms.TabPage();
            this.lvReservations = new System.Windows.Forms.ListView();
            this.columnHeaderInfo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabHotelManagement.SuspendLayout();
            this.tabManage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabReservations.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabHotelManagement
            // 
            this.tabHotelManagement.Controls.Add(this.tabManage);
            this.tabHotelManagement.Controls.Add(this.tabReservations);
            this.tabHotelManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabHotelManagement.Location = new System.Drawing.Point(12, 12);
            this.tabHotelManagement.Name = "tabHotelManagement";
            this.tabHotelManagement.SelectedIndex = 0;
            this.tabHotelManagement.Size = new System.Drawing.Size(776, 426);
            this.tabHotelManagement.TabIndex = 0;
            this.tabHotelManagement.SelectedIndexChanged += new System.EventHandler(this.tabHotelManagement_SelectedIndexChanged);
            // 
            // tabManage
            // 
            this.tabManage.Controls.Add(this.btnAddReservation);
            this.tabManage.Controls.Add(this.btnAddRoom);
            this.tabManage.Controls.Add(this.rbNonSmoking);
            this.tabManage.Controls.Add(this.rbSmoking);
            this.tabManage.Controls.Add(this.cbRoomType);
            this.tabManage.Controls.Add(this.label1);
            this.tabManage.Controls.Add(this.lblNumberOfNights);
            this.tabManage.Controls.Add(this.lblName);
            this.tabManage.Controls.Add(this.numericUpDown1);
            this.tabManage.Controls.Add(this.tbName);
            this.tabManage.Location = new System.Drawing.Point(4, 29);
            this.tabManage.Name = "tabManage";
            this.tabManage.Padding = new System.Windows.Forms.Padding(3);
            this.tabManage.Size = new System.Drawing.Size(768, 393);
            this.tabManage.TabIndex = 0;
            this.tabManage.Text = "Manage";
            this.tabManage.UseVisualStyleBackColor = true;
            // 
            // btnAddReservation
            // 
            this.btnAddReservation.Location = new System.Drawing.Point(518, 95);
            this.btnAddReservation.Name = "btnAddReservation";
            this.btnAddReservation.Size = new System.Drawing.Size(156, 37);
            this.btnAddReservation.TabIndex = 9;
            this.btnAddReservation.Text = "Add reservation";
            this.btnAddReservation.UseVisualStyleBackColor = true;
            this.btnAddReservation.Click += new System.EventHandler(this.btnAddReservation_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Location = new System.Drawing.Point(518, 272);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(156, 37);
            this.btnAddRoom.TabIndex = 8;
            this.btnAddRoom.Text = "Add room";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // rbNonSmoking
            // 
            this.rbNonSmoking.AutoSize = true;
            this.rbNonSmoking.Checked = true;
            this.rbNonSmoking.Location = new System.Drawing.Point(179, 221);
            this.rbNonSmoking.Name = "rbNonSmoking";
            this.rbNonSmoking.Size = new System.Drawing.Size(159, 24);
            this.rbNonSmoking.TabIndex = 7;
            this.rbNonSmoking.TabStop = true;
            this.rbNonSmoking.Text = "Non smoking room";
            this.rbNonSmoking.UseVisualStyleBackColor = true;
            // 
            // rbSmoking
            // 
            this.rbSmoking.AutoSize = true;
            this.rbSmoking.Location = new System.Drawing.Point(179, 278);
            this.rbSmoking.Name = "rbSmoking";
            this.rbSmoking.Size = new System.Drawing.Size(129, 24);
            this.rbSmoking.TabIndex = 6;
            this.rbSmoking.Text = "Smoking room";
            this.rbSmoking.UseVisualStyleBackColor = true;
            // 
            // cbRoomType
            // 
            this.cbRoomType.FormattingEnabled = true;
            this.cbRoomType.Location = new System.Drawing.Point(179, 160);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(320, 28);
            this.cbRoomType.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Room type";
            // 
            // lblNumberOfNights
            // 
            this.lblNumberOfNights.AutoSize = true;
            this.lblNumberOfNights.Location = new System.Drawing.Point(25, 103);
            this.lblNumberOfNights.Name = "lblNumberOfNights";
            this.lblNumberOfNights.Size = new System.Drawing.Size(130, 20);
            this.lblNumberOfNights.TabIndex = 3;
            this.lblNumberOfNights.Text = "Number of nights";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(25, 45);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(179, 101);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(84, 26);
            this.numericUpDown1.TabIndex = 1;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(179, 42);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(320, 26);
            this.tbName.TabIndex = 0;
            // 
            // tabReservations
            // 
            this.tabReservations.Controls.Add(this.lvReservations);
            this.tabReservations.Location = new System.Drawing.Point(4, 29);
            this.tabReservations.Name = "tabReservations";
            this.tabReservations.Padding = new System.Windows.Forms.Padding(3);
            this.tabReservations.Size = new System.Drawing.Size(768, 393);
            this.tabReservations.TabIndex = 1;
            this.tabReservations.Text = "Reservations";
            this.tabReservations.UseVisualStyleBackColor = true;
            // 
            // lvReservations
            // 
            this.lvReservations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderInfo,
            this.columnHeaderPrice});
            this.lvReservations.HideSelection = false;
            this.lvReservations.Location = new System.Drawing.Point(20, 19);
            this.lvReservations.Name = "lvReservations";
            this.lvReservations.Size = new System.Drawing.Size(730, 358);
            this.lvReservations.TabIndex = 0;
            this.lvReservations.UseCompatibleStateImageBehavior = false;
            this.lvReservations.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderInfo
            // 
            this.columnHeaderInfo.Text = "Info";
            this.columnHeaderInfo.Width = 400;
            // 
            // columnHeaderPrice
            // 
            this.columnHeaderPrice.Text = "Price";
            this.columnHeaderPrice.Width = 150;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabHotelManagement);
            this.Name = "MainForm";
            this.Text = "Hotel Management";
            this.tabHotelManagement.ResumeLayout(false);
            this.tabManage.ResumeLayout(false);
            this.tabManage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabReservations.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabHotelManagement;
        private System.Windows.Forms.TabPage tabManage;
        private System.Windows.Forms.TabPage tabReservations;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.RadioButton rbNonSmoking;
        private System.Windows.Forms.RadioButton rbSmoking;
        private System.Windows.Forms.ComboBox cbRoomType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumberOfNights;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Button btnAddReservation;
        private System.Windows.Forms.ListView lvReservations;
        private System.Windows.Forms.ColumnHeader columnHeaderInfo;
        private System.Windows.Forms.ColumnHeader columnHeaderPrice;
    }
}

