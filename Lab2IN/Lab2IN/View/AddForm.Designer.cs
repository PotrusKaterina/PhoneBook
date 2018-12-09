namespace Lab2IN.View
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.ToMainMenu = new System.Windows.Forms.Button();
            this.Ok = new System.Windows.Forms.Button();
            this.NameField = new System.Windows.Forms.TextBox();
            this.SurnameField = new System.Windows.Forms.TextBox();
            this.AddressField = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NameValidation = new System.Windows.Forms.Label();
            this.PhoneValidation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ToMainMenu
            // 
            this.ToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToMainMenu.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToMainMenu.ForeColor = System.Drawing.Color.Crimson;
            this.ToMainMenu.Location = new System.Drawing.Point(139, 399);
            this.ToMainMenu.Name = "ToMainMenu";
            this.ToMainMenu.Size = new System.Drawing.Size(358, 39);
            this.ToMainMenu.TabIndex = 16;
            this.ToMainMenu.Text = "Cancel";
            this.ToMainMenu.UseVisualStyleBackColor = true;
            this.ToMainMenu.Click += new System.EventHandler(this.ToMainMenu_Click);
            // 
            // Ok
            // 
            this.Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ok.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ok.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Ok.Location = new System.Drawing.Point(139, 347);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(358, 39);
            this.Ok.TabIndex = 15;
            this.Ok.Text = "OK";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // NameField
            // 
            this.NameField.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameField.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameField.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.NameField.Location = new System.Drawing.Point(139, 74);
            this.NameField.Multiline = true;
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(358, 36);
            this.NameField.TabIndex = 12;
            this.NameField.Tag = "Name";
            // 
            // SurnameField
            // 
            this.SurnameField.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SurnameField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SurnameField.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameField.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.SurnameField.Location = new System.Drawing.Point(139, 142);
            this.SurnameField.Multiline = true;
            this.SurnameField.Name = "SurnameField";
            this.SurnameField.Size = new System.Drawing.Size(358, 37);
            this.SurnameField.TabIndex = 13;
            // 
            // AddressField
            // 
            this.AddressField.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddressField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddressField.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddressField.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.AddressField.Location = new System.Drawing.Point(139, 213);
            this.AddressField.Multiline = true;
            this.AddressField.Name = "AddressField";
            this.AddressField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AddressField.Size = new System.Drawing.Size(358, 38);
            this.AddressField.TabIndex = 14;
            // 
            // Phone
            // 
            this.Phone.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Phone.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Phone.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Phone.Location = new System.Drawing.Point(310, 284);
            this.Phone.Margin = new System.Windows.Forms.Padding(5);
            this.Phone.Mask = "+(999) 00-00-000-00";
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(187, 30);
            this.Phone.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(136, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Name*:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(136, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(136, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(150, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 19);
            this.label4.TabIndex = 23;
            this.label4.Text = "Phone number*:";
            // 
            // NameValidation
            // 
            this.NameValidation.AutoSize = true;
            this.NameValidation.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameValidation.ForeColor = System.Drawing.Color.DarkRed;
            this.NameValidation.Location = new System.Drawing.Point(198, 48);
            this.NameValidation.Name = "NameValidation";
            this.NameValidation.Size = new System.Drawing.Size(114, 19);
            this.NameValidation.TabIndex = 24;
            this.NameValidation.Text = "can not be null";
            this.NameValidation.Visible = false;
            // 
            // PhoneValidation
            // 
            this.PhoneValidation.AutoSize = true;
            this.PhoneValidation.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneValidation.ForeColor = System.Drawing.Color.DarkRed;
            this.PhoneValidation.Location = new System.Drawing.Point(150, 309);
            this.PhoneValidation.Name = "PhoneValidation";
            this.PhoneValidation.Size = new System.Drawing.Size(114, 19);
            this.PhoneValidation.TabIndex = 25;
            this.PhoneValidation.Text = "can not be null";
            this.PhoneValidation.Visible = false;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(642, 450);
            this.Controls.Add(this.PhoneValidation);
            this.Controls.Add(this.NameValidation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.ToMainMenu);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.NameField);
            this.Controls.Add(this.SurnameField);
            this.Controls.Add(this.AddressField);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddForm";
            this.Text = "Add contact";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ToMainMenu;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.TextBox SurnameField;
        private System.Windows.Forms.TextBox AddressField;
        private System.Windows.Forms.MaskedTextBox Phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label NameValidation;
        private System.Windows.Forms.Label PhoneValidation;
    }
}