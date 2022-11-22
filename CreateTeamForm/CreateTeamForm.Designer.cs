namespace CreateTeamForm
{
    partial class CreateTeamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
            this.TeamNameValue = new System.Windows.Forms.TextBox();
            this.TeamNameLabel = new System.Windows.Forms.Label();
            this.createTeamLabel = new System.Windows.Forms.Label();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.selectTeamDropdown = new System.Windows.Forms.ComboBox();
            this.selectTeamMemberLabel = new System.Windows.Forms.Label();
            this.addNewMemberBoz = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.mobileNumberValue = new System.Windows.Forms.Label();
            this.createMemberButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastNameValue = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.TeamMembersListBox = new System.Windows.Forms.ListBox();
            this.deleteSelectedMemberButton = new System.Windows.Forms.Button();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.addNewMemberBoz.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeamNameValue
            // 
            this.TeamNameValue.Location = new System.Drawing.Point(39, 128);
            this.TeamNameValue.Name = "TeamNameValue";
            this.TeamNameValue.Size = new System.Drawing.Size(332, 35);
            this.TeamNameValue.TabIndex = 13;
            // 
            // TeamNameLabel
            // 
            this.TeamNameLabel.AutoSize = true;
            this.TeamNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TeamNameLabel.Location = new System.Drawing.Point(32, 88);
            this.TeamNameLabel.Name = "TeamNameLabel";
            this.TeamNameLabel.Size = new System.Drawing.Size(151, 37);
            this.TeamNameLabel.TabIndex = 12;
            this.TeamNameLabel.Text = "Team Name";
            // 
            // createTeamLabel
            // 
            this.createTeamLabel.AutoSize = true;
            this.createTeamLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTeamLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.createTeamLabel.Location = new System.Drawing.Point(27, 28);
            this.createTeamLabel.Name = "createTeamLabel";
            this.createTeamLabel.Size = new System.Drawing.Size(213, 50);
            this.createTeamLabel.TabIndex = 11;
            this.createTeamLabel.Text = "Create Team";
            // 
            // addMemberButton
            // 
            this.addMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.addMemberButton.Location = new System.Drawing.Point(173, 260);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(198, 49);
            this.addMemberButton.TabIndex = 19;
            this.addMemberButton.Text = "Add Member";
            this.addMemberButton.UseVisualStyleBackColor = true;
            // 
            // selectTeamDropdown
            // 
            this.selectTeamDropdown.FormattingEnabled = true;
            this.selectTeamDropdown.Location = new System.Drawing.Point(39, 216);
            this.selectTeamDropdown.Name = "selectTeamDropdown";
            this.selectTeamDropdown.Size = new System.Drawing.Size(332, 38);
            this.selectTeamDropdown.TabIndex = 18;
            // 
            // selectTeamMemberLabel
            // 
            this.selectTeamMemberLabel.AutoSize = true;
            this.selectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTeamMemberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.selectTeamMemberLabel.Location = new System.Drawing.Point(32, 176);
            this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            this.selectTeamMemberLabel.Size = new System.Drawing.Size(253, 37);
            this.selectTeamMemberLabel.TabIndex = 17;
            this.selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // addNewMemberBoz
            // 
            this.addNewMemberBoz.Controls.Add(this.textBox2);
            this.addNewMemberBoz.Controls.Add(this.mobileNumberValue);
            this.addNewMemberBoz.Controls.Add(this.createMemberButton);
            this.addNewMemberBoz.Controls.Add(this.textBox1);
            this.addNewMemberBoz.Controls.Add(this.emailLabel);
            this.addNewMemberBoz.Controls.Add(this.lastNameValue);
            this.addNewMemberBoz.Controls.Add(this.lastNameLabel);
            this.addNewMemberBoz.Controls.Add(this.firstNameValue);
            this.addNewMemberBoz.Controls.Add(this.firstNameLabel);
            this.addNewMemberBoz.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewMemberBoz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.addNewMemberBoz.Location = new System.Drawing.Point(39, 329);
            this.addNewMemberBoz.Name = "addNewMemberBoz";
            this.addNewMemberBoz.Size = new System.Drawing.Size(338, 306);
            this.addNewMemberBoz.TabIndex = 20;
            this.addNewMemberBoz.TabStop = false;
            this.addNewMemberBoz.Text = "Add New Member";
            this.addNewMemberBoz.Enter += new System.EventHandler(this.addNewMemberBoz_Enter);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(134, 188);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(198, 39);
            this.textBox2.TabIndex = 32;
            // 
            // mobileNumberValue
            // 
            this.mobileNumberValue.AutoSize = true;
            this.mobileNumberValue.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileNumberValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.mobileNumberValue.Location = new System.Drawing.Point(6, 191);
            this.mobileNumberValue.Name = "mobileNumberValue";
            this.mobileNumberValue.Size = new System.Drawing.Size(82, 32);
            this.mobileNumberValue.TabIndex = 31;
            this.mobileNumberValue.Text = "Mobile";
            // 
            // createMemberButton
            // 
            this.createMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.createMemberButton.Location = new System.Drawing.Point(134, 233);
            this.createMemberButton.Name = "createMemberButton";
            this.createMemberButton.Size = new System.Drawing.Size(198, 49);
            this.createMemberButton.TabIndex = 33;
            this.createMemberButton.Text = "Create Member";
            this.createMemberButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(134, 143);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 39);
            this.textBox1.TabIndex = 34;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.emailLabel.Location = new System.Drawing.Point(6, 146);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(78, 32);
            this.emailLabel.TabIndex = 33;
            this.emailLabel.Text = "E-mail";
            // 
            // lastNameValue
            // 
            this.lastNameValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameValue.Location = new System.Drawing.Point(134, 98);
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.Size = new System.Drawing.Size(198, 39);
            this.lastNameValue.TabIndex = 32;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lastNameLabel.Location = new System.Drawing.Point(6, 101);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(121, 32);
            this.lastNameLabel.TabIndex = 31;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameValue
            // 
            this.firstNameValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameValue.Location = new System.Drawing.Point(134, 51);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Size = new System.Drawing.Size(198, 39);
            this.firstNameValue.TabIndex = 30;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.firstNameLabel.Location = new System.Drawing.Point(6, 54);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(122, 32);
            this.firstNameLabel.TabIndex = 29;
            this.firstNameLabel.Text = "First Name";
            // 
            // TeamMembersListBox
            // 
            this.TeamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TeamMembersListBox.FormattingEnabled = true;
            this.TeamMembersListBox.ItemHeight = 30;
            this.TeamMembersListBox.Location = new System.Drawing.Point(428, 88);
            this.TeamMembersListBox.Name = "TeamMembersListBox";
            this.TeamMembersListBox.Size = new System.Drawing.Size(348, 542);
            this.TeamMembersListBox.TabIndex = 21;
            // 
            // deleteSelectedMemberButton
            // 
            this.deleteSelectedMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteSelectedMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteSelectedMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSelectedMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.deleteSelectedMemberButton.Location = new System.Drawing.Point(793, 554);
            this.deleteSelectedMemberButton.Name = "deleteSelectedMemberButton";
            this.deleteSelectedMemberButton.Size = new System.Drawing.Size(109, 57);
            this.deleteSelectedMemberButton.TabIndex = 24;
            this.deleteSelectedMemberButton.Text = "Delete Selected";
            this.deleteSelectedMemberButton.UseVisualStyleBackColor = true;
            // 
            // createTeamButton
            // 
            this.createTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.createTeamButton.Location = new System.Drawing.Point(318, 664);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(255, 49);
            this.createTeamButton.TabIndex = 25;
            this.createTeamButton.Text = "Create Team";
            this.createTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(914, 725);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.deleteSelectedMemberButton);
            this.Controls.Add(this.TeamMembersListBox);
            this.Controls.Add(this.addNewMemberBoz);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.selectTeamDropdown);
            this.Controls.Add(this.selectTeamMemberLabel);
            this.Controls.Add(this.TeamNameValue);
            this.Controls.Add(this.TeamNameLabel);
            this.Controls.Add(this.createTeamLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTeamForm";
            this.Text = " Create Team";
            this.addNewMemberBoz.ResumeLayout(false);
            this.addNewMemberBoz.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TeamNameValue;
        private System.Windows.Forms.Label TeamNameLabel;
        private System.Windows.Forms.Label createTeamLabel;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.ComboBox selectTeamDropdown;
        private System.Windows.Forms.Label selectTeamMemberLabel;
        private System.Windows.Forms.GroupBox addNewMemberBoz;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox lastNameValue;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameValue;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label mobileNumberValue;
        private System.Windows.Forms.Button createMemberButton;
        private System.Windows.Forms.ListBox TeamMembersListBox;
        private System.Windows.Forms.Button deleteSelectedMemberButton;
        private System.Windows.Forms.Button createTeamButton;
    }
}

