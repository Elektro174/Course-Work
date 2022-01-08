namespace GUI
{
    partial class AddMovieForm
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
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.DirectorFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.CountryTextBox = new System.Windows.Forms.TextBox();
            this.DirectorLastNameTextBox = new System.Windows.Forms.TextBox();
            this.AwardsTextBox = new System.Windows.Forms.TextBox();
            this.SalesFeesTextBox = new System.Windows.Forms.TextBox();
            this.BudgetTextBox = new System.Windows.Forms.TextBox();
            this.ReleasYearTextBox = new System.Windows.Forms.TextBox();
            this.AddMovieButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(12, 22);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(177, 20);
            this.TitleTextBox.TabIndex = 1;
            this.TitleTextBox.Text = "Название";
            this.TitleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TitleTextBox.Enter += new System.EventHandler(this.TitleTextBox_Enter);
            // 
            // DirectorFirstNameTextBox
            // 
            this.DirectorFirstNameTextBox.Location = new System.Drawing.Point(12, 70);
            this.DirectorFirstNameTextBox.Name = "DirectorFirstNameTextBox";
            this.DirectorFirstNameTextBox.Size = new System.Drawing.Size(177, 20);
            this.DirectorFirstNameTextBox.TabIndex = 2;
            this.DirectorFirstNameTextBox.Text = "Имя режисёра";
            this.DirectorFirstNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DirectorFirstNameTextBox.Enter += new System.EventHandler(this.DirectorFirstNameTextBox_Enter);
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.Location = new System.Drawing.Point(12, 164);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(177, 20);
            this.CountryTextBox.TabIndex = 4;
            this.CountryTextBox.Text = "Страна";
            this.CountryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CountryTextBox.Enter += new System.EventHandler(this.CountryTextBox_Enter);
            // 
            // DirectorLastNameTextBox
            // 
            this.DirectorLastNameTextBox.Location = new System.Drawing.Point(12, 116);
            this.DirectorLastNameTextBox.Name = "DirectorLastNameTextBox";
            this.DirectorLastNameTextBox.Size = new System.Drawing.Size(177, 20);
            this.DirectorLastNameTextBox.TabIndex = 3;
            this.DirectorLastNameTextBox.Text = "Фамилия режисёра";
            this.DirectorLastNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DirectorLastNameTextBox.Enter += new System.EventHandler(this.DirectorLastNameTextBox_Enter);
            // 
            // AwardsTextBox
            // 
            this.AwardsTextBox.Location = new System.Drawing.Point(12, 354);
            this.AwardsTextBox.Name = "AwardsTextBox";
            this.AwardsTextBox.Size = new System.Drawing.Size(177, 20);
            this.AwardsTextBox.TabIndex = 8;
            this.AwardsTextBox.Text = "Награды";
            this.AwardsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AwardsTextBox.Enter += new System.EventHandler(this.AwardsTextBox_Enter);
            // 
            // SalesFeesTextBox
            // 
            this.SalesFeesTextBox.Location = new System.Drawing.Point(12, 306);
            this.SalesFeesTextBox.Name = "SalesFeesTextBox";
            this.SalesFeesTextBox.Size = new System.Drawing.Size(177, 20);
            this.SalesFeesTextBox.TabIndex = 7;
            this.SalesFeesTextBox.Text = "Кассовые сборы";
            this.SalesFeesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SalesFeesTextBox.Enter += new System.EventHandler(this.SalesFeesTextBox_Enter);
            this.SalesFeesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SalesFeesTextBox_KeyPress);
            // 
            // BudgetTextBox
            // 
            this.BudgetTextBox.Location = new System.Drawing.Point(12, 260);
            this.BudgetTextBox.Name = "BudgetTextBox";
            this.BudgetTextBox.Size = new System.Drawing.Size(177, 20);
            this.BudgetTextBox.TabIndex = 6;
            this.BudgetTextBox.Text = "Бюджет";
            this.BudgetTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BudgetTextBox.Enter += new System.EventHandler(this.BudgetTextBox_Enter);
            this.BudgetTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BudgetTextBox_KeyPress);
            // 
            // ReleasYearTextBox
            // 
            this.ReleasYearTextBox.Location = new System.Drawing.Point(12, 212);
            this.ReleasYearTextBox.Name = "ReleasYearTextBox";
            this.ReleasYearTextBox.Size = new System.Drawing.Size(177, 20);
            this.ReleasYearTextBox.TabIndex = 5;
            this.ReleasYearTextBox.Text = "Год Выпуска";
            this.ReleasYearTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ReleasYearTextBox.Enter += new System.EventHandler(this.ReleasYearTextBox_Enter);
            this.ReleasYearTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ReleasYearTextBox_KeyPress);
            // 
            // AddMovieButton
            // 
            this.AddMovieButton.Location = new System.Drawing.Point(283, 22);
            this.AddMovieButton.Name = "AddMovieButton";
            this.AddMovieButton.Size = new System.Drawing.Size(166, 68);
            this.AddMovieButton.TabIndex = 9;
            this.AddMovieButton.Text = "Добавить фильм";
            this.AddMovieButton.UseVisualStyleBackColor = true;
            this.AddMovieButton.Click += new System.EventHandler(this.AddMovieButton_Click);
            // 
            // AddMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(461, 394);
            this.Controls.Add(this.DirectorLastNameTextBox);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.AddMovieButton);
            this.Controls.Add(this.AwardsTextBox);
            this.Controls.Add(this.DirectorFirstNameTextBox);
            this.Controls.Add(this.SalesFeesTextBox);
            this.Controls.Add(this.ReleasYearTextBox);
            this.Controls.Add(this.CountryTextBox);
            this.Controls.Add(this.BudgetTextBox);
            this.Name = "AddMovieForm";
            this.Text = "AddMovieForm";
            this.Load += new System.EventHandler(this.AddMovieForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox DirectorFirstNameTextBox;
        private System.Windows.Forms.TextBox CountryTextBox;
        private System.Windows.Forms.TextBox DirectorLastNameTextBox;
        private System.Windows.Forms.TextBox AwardsTextBox;
        private System.Windows.Forms.TextBox SalesFeesTextBox;
        private System.Windows.Forms.TextBox BudgetTextBox;
        private System.Windows.Forms.TextBox ReleasYearTextBox;
        private System.Windows.Forms.Button AddMovieButton;
    }
}