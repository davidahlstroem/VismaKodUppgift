namespace VismaKodUppgift
{
    partial class ParkingForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("");
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NumericParkingPlace = new System.Windows.Forms.NumericUpDown();
            this.textBoxLicenseNumber = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.PickerDate = new System.Windows.Forms.DateTimePicker();
            this.PickerTime = new System.Windows.Forms.DateTimePicker();
            this.ButtonEnterNewVehicle = new System.Windows.Forms.Button();
            this.ButtonVehicleLeaves = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.ListOfVehicles = new System.Windows.Forms.ListView();
            this.ParkingID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.License = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.LabelParkingSpace = new System.Windows.Forms.Label();
            this.comboBoxVehicleType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ListOfVehiclesHistory = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericParkingPlace)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parking Place Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "License Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Time";
            // 
            // NumericParkingPlace
            // 
            this.NumericParkingPlace.Location = new System.Drawing.Point(44, 53);
            this.NumericParkingPlace.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.NumericParkingPlace.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericParkingPlace.Name = "NumericParkingPlace";
            this.NumericParkingPlace.Size = new System.Drawing.Size(156, 20);
            this.NumericParkingPlace.TabIndex = 4;
            this.NumericParkingPlace.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxLicenseNumber
            // 
            this.textBoxLicenseNumber.Location = new System.Drawing.Point(44, 92);
            this.textBoxLicenseNumber.Name = "textBoxLicenseNumber";
            this.textBoxLicenseNumber.Size = new System.Drawing.Size(156, 20);
            this.textBoxLicenseNumber.TabIndex = 5;
            this.toolTip1.SetToolTip(this.textBoxLicenseNumber, "Format: Svenskt :)\r\n");
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.toolTip1.InitialDelay = 10;
            this.toolTip1.ReshowDelay = 10;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // PickerDate
            // 
            this.PickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PickerDate.Location = new System.Drawing.Point(44, 172);
            this.PickerDate.Name = "PickerDate";
            this.PickerDate.Size = new System.Drawing.Size(156, 20);
            this.PickerDate.TabIndex = 6;
            // 
            // PickerTime
            // 
            this.PickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.PickerTime.Location = new System.Drawing.Point(44, 211);
            this.PickerTime.Name = "PickerTime";
            this.PickerTime.ShowUpDown = true;
            this.PickerTime.Size = new System.Drawing.Size(156, 20);
            this.PickerTime.TabIndex = 7;
            // 
            // ButtonEnterNewVehicle
            // 
            this.ButtonEnterNewVehicle.Location = new System.Drawing.Point(44, 237);
            this.ButtonEnterNewVehicle.Name = "ButtonEnterNewVehicle";
            this.ButtonEnterNewVehicle.Size = new System.Drawing.Size(75, 23);
            this.ButtonEnterNewVehicle.TabIndex = 8;
            this.ButtonEnterNewVehicle.Text = "Enter ";
            this.ButtonEnterNewVehicle.UseVisualStyleBackColor = true;
            this.ButtonEnterNewVehicle.Click += new System.EventHandler(this.ButtonEnterNewVehicle_Click);
            // 
            // ButtonVehicleLeaves
            // 
            this.ButtonVehicleLeaves.Location = new System.Drawing.Point(125, 237);
            this.ButtonVehicleLeaves.Name = "ButtonVehicleLeaves";
            this.ButtonVehicleLeaves.Size = new System.Drawing.Size(75, 23);
            this.ButtonVehicleLeaves.TabIndex = 9;
            this.ButtonVehicleLeaves.Text = "Leave";
            this.ButtonVehicleLeaves.UseVisualStyleBackColor = true;
            this.ButtonVehicleLeaves.Click += new System.EventHandler(this.ButtonVehicleLeaves_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(228, 53);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(468, 23);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 10;
            // 
            // ListOfVehicles
            // 
            this.ListOfVehicles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ParkingID,
            this.License,
            this.StartTime});
            this.ListOfVehicles.HideSelection = false;
            this.ListOfVehicles.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem7});
            this.ListOfVehicles.Location = new System.Drawing.Point(228, 92);
            this.ListOfVehicles.Name = "ListOfVehicles";
            this.ListOfVehicles.Size = new System.Drawing.Size(237, 168);
            this.ListOfVehicles.TabIndex = 11;
            this.ListOfVehicles.UseCompatibleStateImageBehavior = false;
            this.ListOfVehicles.View = System.Windows.Forms.View.Details;
            // 
            // ParkingID
            // 
            this.ParkingID.Text = "ParkingID";
            // 
            // License
            // 
            this.License.Text = "License";
            this.License.Width = 56;
            // 
            // StartTime
            // 
            this.StartTime.Text = "StartTime";
            this.StartTime.Width = 115;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Parking Space";
            // 
            // LabelParkingSpace
            // 
            this.LabelParkingSpace.AutoSize = true;
            this.LabelParkingSpace.Location = new System.Drawing.Point(697, 63);
            this.LabelParkingSpace.Name = "LabelParkingSpace";
            this.LabelParkingSpace.Size = new System.Drawing.Size(30, 13);
            this.LabelParkingSpace.TabIndex = 13;
            this.LabelParkingSpace.Text = "0/45";
            // 
            // comboBoxVehicleType
            // 
            this.comboBoxVehicleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVehicleType.FormattingEnabled = true;
            this.comboBoxVehicleType.Items.AddRange(new object[] {
            "Spaceship"});
            this.comboBoxVehicleType.Location = new System.Drawing.Point(44, 132);
            this.comboBoxVehicleType.Name = "comboBoxVehicleType";
            this.comboBoxVehicleType.Size = new System.Drawing.Size(156, 21);
            this.comboBoxVehicleType.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Vehicle Type";
            // 
            // ListOfVehiclesHistory
            // 
            this.ListOfVehiclesHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4});
            this.ListOfVehiclesHistory.HideSelection = false;
            this.ListOfVehiclesHistory.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem8});
            this.ListOfVehiclesHistory.Location = new System.Drawing.Point(471, 92);
            this.ListOfVehiclesHistory.Name = "ListOfVehiclesHistory";
            this.ListOfVehiclesHistory.Size = new System.Drawing.Size(225, 168);
            this.ListOfVehiclesHistory.TabIndex = 17;
            this.ListOfVehiclesHistory.UseCompatibleStateImageBehavior = false;
            this.ListOfVehiclesHistory.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "License";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "End Time";
            this.columnHeader3.Width = 116;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total";
            this.columnHeader4.Width = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(308, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Parking Lot";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(551, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Tickets";
            // 
            // ParkingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 297);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ListOfVehiclesHistory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxVehicleType);
            this.Controls.Add(this.LabelParkingSpace);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ListOfVehicles);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.ButtonVehicleLeaves);
            this.Controls.Add(this.ButtonEnterNewVehicle);
            this.Controls.Add(this.PickerTime);
            this.Controls.Add(this.PickerDate);
            this.Controls.Add(this.textBoxLicenseNumber);
            this.Controls.Add(this.NumericParkingPlace);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ParkingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parkinglot Form";
            ((System.ComponentModel.ISupportInitialize)(this.NumericParkingPlace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NumericParkingPlace;
        private System.Windows.Forms.TextBox textBoxLicenseNumber;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DateTimePicker PickerDate;
        private System.Windows.Forms.DateTimePicker PickerTime;
        private System.Windows.Forms.Button ButtonEnterNewVehicle;
        private System.Windows.Forms.Button ButtonVehicleLeaves;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ListView ListOfVehicles;
        private System.Windows.Forms.ColumnHeader ParkingID;
        private System.Windows.Forms.ColumnHeader License;
        private System.Windows.Forms.ColumnHeader StartTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LabelParkingSpace;
        private System.Windows.Forms.ComboBox comboBoxVehicleType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView ListOfVehiclesHistory;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

