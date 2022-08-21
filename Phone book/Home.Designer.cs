namespace Phone_book
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.SearchIcon = new System.Windows.Forms.Button();
            this.SearchInput = new System.Windows.Forms.TextBox();
            this.SearchHr = new System.Windows.Forms.Label();
            this.MutateContactPage = new System.Windows.Forms.TabPage();
            this.addContactBtn = new System.Windows.Forms.Button();
            this.messageField = new System.Windows.Forms.Label();
            this.deleteContactBtn = new System.Windows.Forms.Button();
            this.saveEditContactBtn = new System.Windows.Forms.Button();
            this.cityInput = new System.Windows.Forms.TextBox();
            this.houseInput = new System.Windows.Forms.TextBox();
            this.streetInput = new System.Windows.Forms.TextBox();
            this.zipcodeInput = new System.Windows.Forms.TextBox();
            this.companyInput = new System.Windows.Forms.TextBox();
            this.numberInput = new System.Windows.Forms.TextBox();
            this.lastnameInput = new System.Windows.Forms.TextBox();
            this.firstnameInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ContactInfoPage = new System.Windows.Forms.TabPage();
            this.SortCheckbox = new System.Windows.Forms.CheckBox();
            this.ContactInfo = new System.Windows.Forms.TableLayoutPanel();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.MutateContactPage.SuspendLayout();
            this.ContactInfoPage.SuspendLayout();
            this.Tabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchIcon
            // 
            this.SearchIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchIcon.BackColor = System.Drawing.Color.Transparent;
            this.SearchIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchIcon.BackgroundImage")));
            this.SearchIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SearchIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchIcon.FlatAppearance.BorderSize = 0;
            this.SearchIcon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SearchIcon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SearchIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchIcon.ForeColor = System.Drawing.Color.Transparent;
            this.SearchIcon.Location = new System.Drawing.Point(245, 11);
            this.SearchIcon.Name = "SearchIcon";
            this.SearchIcon.Size = new System.Drawing.Size(32, 32);
            this.SearchIcon.TabIndex = 1;
            this.SearchIcon.UseVisualStyleBackColor = false;
            // 
            // SearchInput
            // 
            this.SearchInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.SearchInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchInput.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchInput.ForeColor = System.Drawing.Color.White;
            this.SearchInput.Location = new System.Drawing.Point(17, 15);
            this.SearchInput.MaxLength = 64;
            this.SearchInput.Name = "SearchInput";
            this.SearchInput.Size = new System.Drawing.Size(232, 21);
            this.SearchInput.TabIndex = 2;
            this.SearchInput.TextChanged += new System.EventHandler(this.SearchInput_TextChanged);
            // 
            // SearchHr
            // 
            this.SearchHr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(136)))), ((int)(((byte)(163)))));
            this.SearchHr.Location = new System.Drawing.Point(17, 39);
            this.SearchHr.Name = "SearchHr";
            this.SearchHr.Size = new System.Drawing.Size(260, 2);
            this.SearchHr.TabIndex = 3;
            // 
            // MutateContactPage
            // 
            this.MutateContactPage.Controls.Add(this.addContactBtn);
            this.MutateContactPage.Controls.Add(this.messageField);
            this.MutateContactPage.Controls.Add(this.deleteContactBtn);
            this.MutateContactPage.Controls.Add(this.saveEditContactBtn);
            this.MutateContactPage.Controls.Add(this.cityInput);
            this.MutateContactPage.Controls.Add(this.houseInput);
            this.MutateContactPage.Controls.Add(this.streetInput);
            this.MutateContactPage.Controls.Add(this.zipcodeInput);
            this.MutateContactPage.Controls.Add(this.companyInput);
            this.MutateContactPage.Controls.Add(this.numberInput);
            this.MutateContactPage.Controls.Add(this.lastnameInput);
            this.MutateContactPage.Controls.Add(this.firstnameInput);
            this.MutateContactPage.Controls.Add(this.label6);
            this.MutateContactPage.Controls.Add(this.label7);
            this.MutateContactPage.Controls.Add(this.label8);
            this.MutateContactPage.Controls.Add(this.label9);
            this.MutateContactPage.Controls.Add(this.label4);
            this.MutateContactPage.Controls.Add(this.label5);
            this.MutateContactPage.Controls.Add(this.label3);
            this.MutateContactPage.Controls.Add(this.label2);
            this.MutateContactPage.Location = new System.Drawing.Point(4, 24);
            this.MutateContactPage.Name = "MutateContactPage";
            this.MutateContactPage.Padding = new System.Windows.Forms.Padding(3);
            this.MutateContactPage.Size = new System.Drawing.Size(432, 762);
            this.MutateContactPage.TabIndex = 1;
            this.MutateContactPage.Text = "Add new contact";
            this.MutateContactPage.UseVisualStyleBackColor = true;
            // 
            // addContactBtn
            // 
            this.addContactBtn.Location = new System.Drawing.Point(341, 287);
            this.addContactBtn.Name = "addContactBtn";
            this.addContactBtn.Size = new System.Drawing.Size(75, 23);
            this.addContactBtn.TabIndex = 17;
            this.addContactBtn.Text = "Add";
            this.addContactBtn.UseVisualStyleBackColor = true;
            this.addContactBtn.Click += new System.EventHandler(this.AddContactBtn_Click);
            // 
            // messageField
            // 
            this.messageField.AutoSize = true;
            this.messageField.Location = new System.Drawing.Point(14, 291);
            this.messageField.Name = "messageField";
            this.messageField.Size = new System.Drawing.Size(79, 15);
            this.messageField.TabIndex = 20;
            this.messageField.Text = "message here";
            // 
            // deleteContactBtn
            // 
            this.deleteContactBtn.Location = new System.Drawing.Point(341, 315);
            this.deleteContactBtn.Name = "deleteContactBtn";
            this.deleteContactBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteContactBtn.TabIndex = 18;
            this.deleteContactBtn.Text = "Delete";
            this.deleteContactBtn.UseVisualStyleBackColor = true;
            this.deleteContactBtn.Click += new System.EventHandler(this.deleteContactBtn_Click);
            // 
            // saveEditContactBtn
            // 
            this.saveEditContactBtn.Location = new System.Drawing.Point(259, 315);
            this.saveEditContactBtn.Name = "saveEditContactBtn";
            this.saveEditContactBtn.Size = new System.Drawing.Size(75, 23);
            this.saveEditContactBtn.TabIndex = 16;
            this.saveEditContactBtn.Text = "Save";
            this.saveEditContactBtn.UseVisualStyleBackColor = true;
            this.saveEditContactBtn.Click += new System.EventHandler(this.saveEditContactBtn_Click);
            // 
            // cityInput
            // 
            this.cityInput.Location = new System.Drawing.Point(275, 204);
            this.cityInput.Name = "cityInput";
            this.cityInput.Size = new System.Drawing.Size(100, 23);
            this.cityInput.TabIndex = 15;
            // 
            // houseInput
            // 
            this.houseInput.Location = new System.Drawing.Point(106, 204);
            this.houseInput.Name = "houseInput";
            this.houseInput.Size = new System.Drawing.Size(100, 23);
            this.houseInput.TabIndex = 13;
            // 
            // streetInput
            // 
            this.streetInput.Location = new System.Drawing.Point(241, 164);
            this.streetInput.Name = "streetInput";
            this.streetInput.Size = new System.Drawing.Size(100, 23);
            this.streetInput.TabIndex = 11;
            // 
            // zipcodeInput
            // 
            this.zipcodeInput.Location = new System.Drawing.Point(65, 164);
            this.zipcodeInput.Name = "zipcodeInput";
            this.zipcodeInput.Size = new System.Drawing.Size(100, 23);
            this.zipcodeInput.TabIndex = 9;
            // 
            // companyInput
            // 
            this.companyInput.Location = new System.Drawing.Point(306, 57);
            this.companyInput.Name = "companyInput";
            this.companyInput.Size = new System.Drawing.Size(100, 23);
            this.companyInput.TabIndex = 7;
            // 
            // numberInput
            // 
            this.numberInput.Location = new System.Drawing.Point(106, 54);
            this.numberInput.Name = "numberInput";
            this.numberInput.Size = new System.Drawing.Size(100, 23);
            this.numberInput.TabIndex = 5;
            // 
            // lastnameInput
            // 
            this.lastnameInput.Location = new System.Drawing.Point(259, 14);
            this.lastnameInput.Name = "lastnameInput";
            this.lastnameInput.Size = new System.Drawing.Size(100, 23);
            this.lastnameInput.TabIndex = 3;
            // 
            // firstnameInput
            // 
            this.firstnameInput.Location = new System.Drawing.Point(79, 14);
            this.firstnameInput.Name = "firstnameInput";
            this.firstnameInput.Size = new System.Drawing.Size(100, 23);
            this.firstnameInput.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "City";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "House number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(194, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Street";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Zipcode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Company";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone number*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "First name*";
            // 
            // ContactInfoPage
            // 
            this.ContactInfoPage.Controls.Add(this.SortCheckbox);
            this.ContactInfoPage.Controls.Add(this.SearchHr);
            this.ContactInfoPage.Controls.Add(this.ContactInfo);
            this.ContactInfoPage.Controls.Add(this.SearchInput);
            this.ContactInfoPage.Controls.Add(this.SearchIcon);
            this.ContactInfoPage.Location = new System.Drawing.Point(4, 24);
            this.ContactInfoPage.Name = "ContactInfoPage";
            this.ContactInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.ContactInfoPage.Size = new System.Drawing.Size(432, 762);
            this.ContactInfoPage.TabIndex = 0;
            this.ContactInfoPage.Text = "All contacts";
            this.ContactInfoPage.UseVisualStyleBackColor = true;
            // 
            // SortCheckbox
            // 
            this.SortCheckbox.AutoSize = true;
            this.SortCheckbox.Location = new System.Drawing.Point(363, 19);
            this.SortCheckbox.Name = "SortCheckbox";
            this.SortCheckbox.Size = new System.Drawing.Size(47, 19);
            this.SortCheckbox.TabIndex = 2;
            this.SortCheckbox.Text = "Sort";
            this.SortCheckbox.UseVisualStyleBackColor = true;
            this.SortCheckbox.CheckedChanged += new System.EventHandler(this.SortCheckbox_CheckedChanged);
            // 
            // ContactInfo
            // 
            this.ContactInfo.ColumnCount = 3;
            this.ContactInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.ContactInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.ContactInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ContactInfo.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.ContactInfo.Location = new System.Drawing.Point(0, 62);
            this.ContactInfo.Name = "ContactInfo";
            this.ContactInfo.RowCount = 6;
            this.ContactInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.ContactInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.ContactInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.ContactInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.ContactInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.ContactInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.ContactInfo.Size = new System.Drawing.Size(432, 700);
            this.ContactInfo.TabIndex = 1;
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.ContactInfoPage);
            this.Tabs.Controls.Add(this.MutateContactPage);
            this.Tabs.Location = new System.Drawing.Point(12, 12);
            this.Tabs.Multiline = true;
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(440, 790);
            this.Tabs.TabIndex = 4;
            this.Tabs.Click += new System.EventHandler(this.TabControl_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(464, 814);
            this.Controls.Add(this.Tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(480, 853);
            this.MinimumSize = new System.Drawing.Size(480, 853);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.MutateContactPage.ResumeLayout(false);
            this.MutateContactPage.PerformLayout();
            this.ContactInfoPage.ResumeLayout(false);
            this.ContactInfoPage.PerformLayout();
            this.Tabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public Button search_btn;
        private Button SearchIcon;
        private TextBox SearchInput;
        private Label SearchHr;
        private TabPage MutateContactPage;
        private Button deleteContactBtn;
        private Button addContactBtn;
        private Button saveEditContactBtn;
        private TextBox cityInput;
        private TextBox houseInput;
        private TextBox streetInput;
        private TextBox zipcodeInput;
        private TextBox companyInput;
        private TextBox numberInput;
        private TextBox lastnameInput;
        private TextBox firstnameInput;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label2;
        private TabPage ContactInfoPage;
        private CheckBox SortCheckbox;
        private TableLayoutPanel ContactInfo;
        private TabControl Tabs;
        private Label messageField;
    }
}