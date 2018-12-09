namespace Lab2IN
{
    partial class Number17
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Number17));
            this.Start = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Finish = new System.Windows.Forms.Button();
            this.Picture1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picture1)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.AutoSize = true;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Start.Location = new System.Drawing.Point(77, 122);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(82, 39);
            this.Start.TabIndex = 1;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Search.Location = new System.Drawing.Point(77, 183);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(82, 39);
            this.Search.TabIndex = 6;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Finish
            // 
            this.Finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Finish.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Finish.ForeColor = System.Drawing.Color.Crimson;
            this.Finish.Location = new System.Drawing.Point(77, 248);
            this.Finish.Name = "Finish";
            this.Finish.Size = new System.Drawing.Size(82, 39);
            this.Finish.TabIndex = 7;
            this.Finish.Text = "Exit";
            this.Finish.UseVisualStyleBackColor = true;
            this.Finish.Click += new System.EventHandler(this.Finish_Click);
            // 
            // Picture1
            // 
            this.Picture1.Image = global::Lab2IN.Properties.Resources._1195445181899094722molumen_phone_icon_svg_hi;
            this.Picture1.Location = new System.Drawing.Point(175, 15);
            this.Picture1.Name = "Picture1";
            this.Picture1.Size = new System.Drawing.Size(440, 396);
            this.Picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture1.TabIndex = 5;
            this.Picture1.TabStop = false;
            this.Picture1.Click += new System.EventHandler(this.Picture1_Click);
            // 
            // Number17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(642, 450);
            this.Controls.Add(this.Finish);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Picture1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Number17";
            this.Text = "Numbers";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Number17_FormClosed);
            this.Load += new System.EventHandler(this.Number17_Load);
            this.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.Number17_ControlRemoved);
            ((System.ComponentModel.ISupportInitialize)(this.Picture1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.PictureBox Picture1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Finish;
    }
}

