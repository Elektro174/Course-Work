namespace GUI
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GetDataButton = new System.Windows.Forms.Button();
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.OpenAddFilmFormButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.DeleteMovieButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveToPDF = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GetDataButton
            // 
            this.GetDataButton.Location = new System.Drawing.Point(1027, 52);
            this.GetDataButton.Name = "GetDataButton";
            this.GetDataButton.Size = new System.Drawing.Size(151, 49);
            this.GetDataButton.TabIndex = 1;
            this.GetDataButton.Text = "Получить список фильмов";
            this.GetDataButton.UseVisualStyleBackColor = true;
            this.GetDataButton.Click += new System.EventHandler(this.GetDataButton_Click);
            // 
            // movieBindingSource
            // 
            this.movieBindingSource.DataSource = typeof(Domain.Movie);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 52);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = "DataGridViewNumberedRow.OnRowPostPaint()";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Size = new System.Drawing.Size(996, 456);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.Location = new System.Drawing.Point(1027, 130);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(151, 49);
            this.SaveChangesButton.TabIndex = 3;
            this.SaveChangesButton.Text = "Сохранить изменения";
            this.SaveChangesButton.UseVisualStyleBackColor = true;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // OpenAddFilmFormButton
            // 
            this.OpenAddFilmFormButton.Location = new System.Drawing.Point(1027, 210);
            this.OpenAddFilmFormButton.Name = "OpenAddFilmFormButton";
            this.OpenAddFilmFormButton.Size = new System.Drawing.Size(151, 49);
            this.OpenAddFilmFormButton.TabIndex = 4;
            this.OpenAddFilmFormButton.Text = "Открыть окно добавления фильмов";
            this.OpenAddFilmFormButton.UseVisualStyleBackColor = true;
            this.OpenAddFilmFormButton.Click += new System.EventHandler(this.OpenAddFilmFormButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(1027, 314);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(151, 20);
            this.SearchTextBox.TabIndex = 5;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // DeleteMovieButton
            // 
            this.DeleteMovieButton.Location = new System.Drawing.Point(1027, 389);
            this.DeleteMovieButton.Name = "DeleteMovieButton";
            this.DeleteMovieButton.Size = new System.Drawing.Size(151, 49);
            this.DeleteMovieButton.TabIndex = 6;
            this.DeleteMovieButton.Text = "Удалить выделенный фильм";
            this.DeleteMovieButton.UseVisualStyleBackColor = true;
            this.DeleteMovieButton.Click += new System.EventHandler(this.DeleteMovieButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1067, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Поиск";
            // 
            // SaveToPDF
            // 
            this.SaveToPDF.Location = new System.Drawing.Point(1027, 459);
            this.SaveToPDF.Name = "SaveToPDF";
            this.SaveToPDF.Size = new System.Drawing.Size(151, 49);
            this.SaveToPDF.TabIndex = 8;
            this.SaveToPDF.Text = "Сохранить в PDF";
            this.SaveToPDF.UseVisualStyleBackColor = true;
            this.SaveToPDF.Click += new System.EventHandler(this.SaveToPDF_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "F2 – Помощь";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1295, 592);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SaveToPDF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteMovieButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.OpenAddFilmFormButton);
            this.Controls.Add(this.SaveChangesButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GetDataButton);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "MovieList";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource movieBindingSource;
        private System.Windows.Forms.Button GetDataButton;
        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.Button OpenAddFilmFormButton;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button DeleteMovieButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveToPDF;
        private System.Windows.Forms.Label label2;
    }
}

