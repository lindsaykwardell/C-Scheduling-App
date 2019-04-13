namespace C_sharp_Advanced
{
    partial class DashboardForm
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
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new C_sharp_Advanced.databaseDataSet();
            this.userTableAdapter = new C_sharp_Advanced.databaseDataSetTableAdapters.UserTableAdapter();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.newAppointmentButton = new System.Windows.Forms.Button();
            this.manageCustomersButton = new System.Windows.Forms.Button();
            this.AppointmentView = new System.Windows.Forms.TabControl();
            this.monthTab = new System.Windows.Forms.TabPage();
            this.weekTab = new System.Windows.Forms.TabPage();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.editActiveAppointmentButton = new System.Windows.Forms.Button();
            this.deleteActiveAppointmentButton = new System.Windows.Forms.Button();
            this.appointmentGroupBox = new System.Windows.Forms.GroupBox();
            this.appointmentListBox = new System.Windows.Forms.ListBox();
            this.locationLabel = new System.Windows.Forms.Label();
            this.appointmentLocationLabel = new System.Windows.Forms.Label();
            this.appointmentContactLabel = new System.Windows.Forms.Label();
            this.contactLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.appointmentFrom = new System.Windows.Forms.DateTimePicker();
            this.appointmentTo = new System.Windows.Forms.DateTimePicker();
            this.toLabel = new System.Windows.Forms.Label();
            this.appointmentDescriptionLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.divider = new System.Windows.Forms.Label();
            this.divider2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.AppointmentView.SuspendLayout();
            this.monthTab.SuspendLayout();
            this.appointmentGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.databaseDataSetBindingSource;
            // 
            // databaseDataSetBindingSource
            // 
            this.databaseDataSetBindingSource.DataSource = this.databaseDataSet;
            this.databaseDataSetBindingSource.Position = 0;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "databaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(961, 9);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(68, 13);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "USERNAME";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // newAppointmentButton
            // 
            this.newAppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAppointmentButton.Location = new System.Drawing.Point(12, 12);
            this.newAppointmentButton.Name = "newAppointmentButton";
            this.newAppointmentButton.Size = new System.Drawing.Size(227, 44);
            this.newAppointmentButton.TabIndex = 3;
            this.newAppointmentButton.Text = "New Appointment";
            this.newAppointmentButton.UseVisualStyleBackColor = true;
            // 
            // manageCustomersButton
            // 
            this.manageCustomersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageCustomersButton.Location = new System.Drawing.Point(245, 12);
            this.manageCustomersButton.Name = "manageCustomersButton";
            this.manageCustomersButton.Size = new System.Drawing.Size(227, 44);
            this.manageCustomersButton.TabIndex = 4;
            this.manageCustomersButton.Text = "Manage Customers";
            this.manageCustomersButton.UseVisualStyleBackColor = true;
            // 
            // AppointmentView
            // 
            this.AppointmentView.Controls.Add(this.monthTab);
            this.AppointmentView.Controls.Add(this.weekTab);
            this.AppointmentView.Location = new System.Drawing.Point(13, 63);
            this.AppointmentView.Name = "AppointmentView";
            this.AppointmentView.SelectedIndex = 0;
            this.AppointmentView.Size = new System.Drawing.Size(1016, 546);
            this.AppointmentView.TabIndex = 5;
            // 
            // monthTab
            // 
            this.monthTab.Controls.Add(this.appointmentListBox);
            this.monthTab.Controls.Add(this.appointmentGroupBox);
            this.monthTab.Controls.Add(this.monthCalendar1);
            this.monthTab.Location = new System.Drawing.Point(4, 22);
            this.monthTab.Name = "monthTab";
            this.monthTab.Padding = new System.Windows.Forms.Padding(3);
            this.monthTab.Size = new System.Drawing.Size(1008, 520);
            this.monthTab.TabIndex = 0;
            this.monthTab.Text = "Month";
            this.monthTab.UseVisualStyleBackColor = true;
            // 
            // weekTab
            // 
            this.weekTab.Location = new System.Drawing.Point(4, 22);
            this.weekTab.Name = "weekTab";
            this.weekTab.Padding = new System.Windows.Forms.Padding(3);
            this.weekTab.Size = new System.Drawing.Size(1008, 520);
            this.weekTab.TabIndex = 1;
            this.weekTab.Text = "Week";
            this.weekTab.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(7, 7);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // editActiveAppointmentButton
            // 
            this.editActiveAppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editActiveAppointmentButton.Location = new System.Drawing.Point(674, 19);
            this.editActiveAppointmentButton.Name = "editActiveAppointmentButton";
            this.editActiveAppointmentButton.Size = new System.Drawing.Size(75, 23);
            this.editActiveAppointmentButton.TabIndex = 1;
            this.editActiveAppointmentButton.Text = "Edit";
            this.editActiveAppointmentButton.UseVisualStyleBackColor = true;
            // 
            // deleteActiveAppointmentButton
            // 
            this.deleteActiveAppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteActiveAppointmentButton.Location = new System.Drawing.Point(674, 48);
            this.deleteActiveAppointmentButton.Name = "deleteActiveAppointmentButton";
            this.deleteActiveAppointmentButton.Size = new System.Drawing.Size(75, 23);
            this.deleteActiveAppointmentButton.TabIndex = 2;
            this.deleteActiveAppointmentButton.Text = "Delete";
            this.deleteActiveAppointmentButton.UseVisualStyleBackColor = true;
            // 
            // appointmentGroupBox
            // 
            this.appointmentGroupBox.Controls.Add(this.divider2);
            this.appointmentGroupBox.Controls.Add(this.divider);
            this.appointmentGroupBox.Controls.Add(this.appointmentDescriptionLabel);
            this.appointmentGroupBox.Controls.Add(this.descriptionLabel);
            this.appointmentGroupBox.Controls.Add(this.appointmentTo);
            this.appointmentGroupBox.Controls.Add(this.toLabel);
            this.appointmentGroupBox.Controls.Add(this.appointmentFrom);
            this.appointmentGroupBox.Controls.Add(this.fromLabel);
            this.appointmentGroupBox.Controls.Add(this.appointmentContactLabel);
            this.appointmentGroupBox.Controls.Add(this.contactLabel);
            this.appointmentGroupBox.Controls.Add(this.appointmentLocationLabel);
            this.appointmentGroupBox.Controls.Add(this.locationLabel);
            this.appointmentGroupBox.Controls.Add(this.deleteActiveAppointmentButton);
            this.appointmentGroupBox.Controls.Add(this.editActiveAppointmentButton);
            this.appointmentGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentGroupBox.Location = new System.Drawing.Point(247, 7);
            this.appointmentGroupBox.Name = "appointmentGroupBox";
            this.appointmentGroupBox.Size = new System.Drawing.Size(755, 507);
            this.appointmentGroupBox.TabIndex = 3;
            this.appointmentGroupBox.TabStop = false;
            this.appointmentGroupBox.Text = "APPT";
            // 
            // appointmentListBox
            // 
            this.appointmentListBox.FormattingEnabled = true;
            this.appointmentListBox.Location = new System.Drawing.Point(7, 182);
            this.appointmentListBox.Name = "appointmentListBox";
            this.appointmentListBox.Size = new System.Drawing.Size(227, 329);
            this.appointmentListBox.TabIndex = 4;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.Location = new System.Drawing.Point(7, 54);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(51, 13);
            this.locationLabel.TabIndex = 3;
            this.locationLabel.Text = "Location:";
            // 
            // appointmentLocationLabel
            // 
            this.appointmentLocationLabel.AutoSize = true;
            this.appointmentLocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentLocationLabel.Location = new System.Drawing.Point(76, 54);
            this.appointmentLocationLabel.Name = "appointmentLocationLabel";
            this.appointmentLocationLabel.Size = new System.Drawing.Size(28, 13);
            this.appointmentLocationLabel.TabIndex = 4;
            this.appointmentLocationLabel.Text = "LOC";
            // 
            // appointmentContactLabel
            // 
            this.appointmentContactLabel.AutoSize = true;
            this.appointmentContactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentContactLabel.Location = new System.Drawing.Point(76, 82);
            this.appointmentContactLabel.Name = "appointmentContactLabel";
            this.appointmentContactLabel.Size = new System.Drawing.Size(58, 13);
            this.appointmentContactLabel.TabIndex = 6;
            this.appointmentContactLabel.Text = "CONTACT";
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactLabel.Location = new System.Drawing.Point(7, 82);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(47, 13);
            this.contactLabel.TabIndex = 5;
            this.contactLabel.Text = "Contact:";
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromLabel.Location = new System.Drawing.Point(7, 24);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(33, 13);
            this.fromLabel.TabIndex = 7;
            this.fromLabel.Text = "From:";
            // 
            // appointmentFrom
            // 
            this.appointmentFrom.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.appointmentFrom.Location = new System.Drawing.Point(46, 19);
            this.appointmentFrom.Name = "appointmentFrom";
            this.appointmentFrom.Size = new System.Drawing.Size(200, 20);
            this.appointmentFrom.TabIndex = 8;
            // 
            // appointmentTo
            // 
            this.appointmentTo.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.appointmentTo.Location = new System.Drawing.Point(378, 17);
            this.appointmentTo.Name = "appointmentTo";
            this.appointmentTo.Size = new System.Drawing.Size(200, 20);
            this.appointmentTo.TabIndex = 10;
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toLabel.Location = new System.Drawing.Point(339, 22);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(23, 13);
            this.toLabel.TabIndex = 9;
            this.toLabel.Text = "To:";
            // 
            // appointmentDescriptionLabel
            // 
            this.appointmentDescriptionLabel.AutoSize = true;
            this.appointmentDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentDescriptionLabel.Location = new System.Drawing.Point(76, 108);
            this.appointmentDescriptionLabel.Name = "appointmentDescriptionLabel";
            this.appointmentDescriptionLabel.Size = new System.Drawing.Size(36, 13);
            this.appointmentDescriptionLabel.TabIndex = 12;
            this.appointmentDescriptionLabel.Text = "DESC";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(7, 108);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.descriptionLabel.TabIndex = 11;
            this.descriptionLabel.Text = "Description:";
            // 
            // divider
            // 
            this.divider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.divider.Location = new System.Drawing.Point(12, 175);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(727, 2);
            this.divider.TabIndex = 13;
            // 
            // divider2
            // 
            this.divider2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.divider2.Location = new System.Drawing.Point(10, 46);
            this.divider2.Name = "divider2";
            this.divider2.Size = new System.Drawing.Size(650, 2);
            this.divider2.TabIndex = 14;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 621);
            this.Controls.Add(this.AppointmentView);
            this.Controls.Add(this.manageCustomersButton);
            this.Controls.Add(this.newAppointmentButton);
            this.Controls.Add(this.UsernameLabel);
            this.Name = "DashboardForm";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.AppointmentView.ResumeLayout(false);
            this.monthTab.ResumeLayout(false);
            this.appointmentGroupBox.ResumeLayout(false);
            this.appointmentGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource databaseDataSetBindingSource;
        private databaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private databaseDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Button newAppointmentButton;
        private System.Windows.Forms.Button manageCustomersButton;
        private System.Windows.Forms.TabControl AppointmentView;
        private System.Windows.Forms.TabPage monthTab;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TabPage weekTab;
        private System.Windows.Forms.Button deleteActiveAppointmentButton;
        private System.Windows.Forms.Button editActiveAppointmentButton;
        private System.Windows.Forms.GroupBox appointmentGroupBox;
        private System.Windows.Forms.ListBox appointmentListBox;
        private System.Windows.Forms.Label divider2;
        private System.Windows.Forms.Label divider;
        private System.Windows.Forms.Label appointmentDescriptionLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.DateTimePicker appointmentTo;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.DateTimePicker appointmentFrom;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label appointmentContactLabel;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.Label appointmentLocationLabel;
        private System.Windows.Forms.Label locationLabel;
    }
}

