namespace Lab2IN.View
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.SearchField = new System.Windows.Forms.TextBox();
            this.Elements = new System.Windows.Forms.ListBox();
            this.ToMainMenu = new System.Windows.Forms.Button();
            this.Ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchField
            // 
            this.SearchField.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SearchField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchField.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchField.Location = new System.Drawing.Point(21, 12);
            this.SearchField.Multiline = true;
            this.SearchField.Name = "SearchField";
            this.SearchField.Size = new System.Drawing.Size(207, 36);
            this.SearchField.TabIndex = 3;
            this.SearchField.Tag = "Name";
            // 
            // Elements
            // 
            this.Elements.BackColor = System.Drawing.SystemColors.MenuText;
            this.Elements.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Elements.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Elements.ForeColor = System.Drawing.Color.DarkGray;
            this.Elements.FormattingEnabled = true;
            this.Elements.ItemHeight = 19;
            this.Elements.Location = new System.Drawing.Point(259, 12);
            this.Elements.Name = "Elements";
            this.Elements.Size = new System.Drawing.Size(371, 418);
            this.Elements.TabIndex = 11;
            // 
            // ToMainMenu
            // 
            this.ToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToMainMenu.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToMainMenu.ForeColor = System.Drawing.Color.Crimson;
            this.ToMainMenu.Location = new System.Drawing.Point(21, 391);
            this.ToMainMenu.Name = "ToMainMenu";
            this.ToMainMenu.Size = new System.Drawing.Size(207, 39);
            this.ToMainMenu.TabIndex = 13;
            this.ToMainMenu.Text = "Cancel";
            this.ToMainMenu.UseVisualStyleBackColor = true;
            this.ToMainMenu.Click += new System.EventHandler(this.ToMainMenu_Click);
            // 
            // Ok
            // 
            this.Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ok.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ok.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Ok.Location = new System.Drawing.Point(21, 346);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(207, 39);
            this.Ok.TabIndex = 12;
            this.Ok.Text = "OK";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(642, 450);
            this.Controls.Add(this.ToMainMenu);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.Elements);
            this.Controls.Add(this.SearchField);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchField;
        private System.Windows.Forms.ListBox Elements;
        private System.Windows.Forms.Button ToMainMenu;
        private System.Windows.Forms.Button Ok;
    }
}