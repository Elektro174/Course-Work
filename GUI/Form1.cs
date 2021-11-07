using Data.Repositiries;
using GUI.Models.ViewModels;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using Services;
using System;
using System.IO;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void SetDataGridViewHeaders()
        {
            dataGridView1.Columns[0].HeaderText = "Название";
            dataGridView1.Columns[1].HeaderText = "Имя Режисёра";
            dataGridView1.Columns[2].HeaderText = "Фамилия режисёра";
            dataGridView1.Columns[3].HeaderText = "Страна";
            dataGridView1.Columns[4].HeaderText = "Год выпуска";
            dataGridView1.Columns[5].HeaderText = "Бюджет млн. $";
            dataGridView1.Columns[6].HeaderText = "Сборы млн. $";
            dataGridView1.Columns[7].HeaderText = "Награды";
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            for (int i = 0; (i <= (dataGridView1.Rows.Count - 1)); i++)
            {
                dataGridView1.Rows[i].HeaderCell.Value = string.Format((i + 1).ToString(), "0");
            }
            dataGridView1.RowHeadersWidth = 50;
            for (int i = 0; i < 8; i++)
            {
                dataGridView1.AutoResizeColumn(i);
            }
        }
        private void GetDataButton_Click(object sender, EventArgs e)
        {
            MoviesRepository repository = new MoviesRepository();
            MoviesService movieService = new MoviesService(repository);
            MainFormDataViewModel.movies = movieService.GetAllMovies();
            if (MainFormDataViewModel.movies == null)
            {
                MessageBox.Show("Сначала добавьте хотя бы один фильм\n с помощью окна добалвения фильмов");
                return;
            }
            dataGridView1.DataSource = MainFormDataViewModel.movies;
            SetDataGridViewHeaders();
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            if (MainFormDataViewModel.movies == null)
            {
                MessageBox.Show("Сначала добавьте хотя бы один фильм\n с помощью окна добалвения фильмов");
                return;
            }
            MoviesRepository repository = new MoviesRepository();
            MoviesService movieService = new MoviesService(repository);
            movieService.UpdateAllMovies(MainFormDataViewModel.movies);
        }

        private void OpenAddFilmFormButton_Click(object sender, EventArgs e)
        {
            AddMovieForm addMovieForm = new AddMovieForm();
            addMovieForm.LogicalParent = this;
            addMovieForm.Show();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();

            if (string.IsNullOrWhiteSpace(SearchTextBox.Text))
                return;

            var value = SearchTextBox.Text.ToLower();
            var result = MainFormDataViewModel.movies.Find(x => x.Title.ToLower() == value || x.DirectorLastName.ToLower() == value || x.DirectorFirstName.ToLower() == value
            || x.ReleaseYear.ToString() == value || x.SalesFees.ToString() == value || x.Country.ToLower() == value || x.Budget.ToString() == value
             || x.Awards.ToLower() == value || (x.DirectorFirstName.ToLower() + " " + x.DirectorLastName.ToLower()) == value);
            if (result != null)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    var row = dataGridView1.Rows[i];

                    if (row.Cells[8].Value.ToString() == result.Id.ToString())
                    {
                        row.Selected = true;
                    }
                }
            }
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                var row = dataGridView1.Rows[i];

                if (row.HeaderCell.Value.ToString().ToLower() == value)
                {
                    row.Selected = true;
                }
            }
        }

        private void DeleteMovieButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить данный фильм?", "Удаление фильма", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MoviesRepository repository = new MoviesRepository();
                    MoviesService movieService = new MoviesService(repository);
                    movieService.DeleteMovieById(Convert.ToInt32(dataGridView1.SelectedCells[8].Value));
                    MainFormDataViewModel.movies = movieService.GetAllMovies();
                    dataGridView1.DataSource = MainFormDataViewModel.movies;
                    SetDataGridViewHeaders();
                    return;
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста выделите одну строку с фильмом, который вы хотите удалить, целиком c помощью поиска, либо нажатием на ячейку с номером строки");
            }
        }

        private void SaveToPDF_Click(object sender, EventArgs e)
        {
            string MoviesListPath = "";
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text File (*.pdf)|*.pdf|Show All Files (*.*)|*.*";
            sfd.FileName = "Список фильмов";
            sfd.Title = "Сохранить как";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
              MoviesListPath = Path.GetFullPath(sfd.FileName);
            }
            if (MoviesListPath == "")
            {
                MessageBox.Show("Для сохранения в PDF укажите место где хотите создать файл и сохранить данные, или сохранить в уже существующий файл данные и нажмите кнопку \"ОК\"");
                return;
            }
            Document doc = new Document();
            try
            {
                PdfWriter.GetInstance(doc, new FileStream(MoviesListPath, FileMode.Create, FileAccess.Write));
            }
            catch (Exception)
            {
                MessageBox.Show("Для сохранения файла в данном месте запустите программу от имени администратора, либо измените место сохранения файла");
                return;
            }
            doc.Open();
            BaseFont baseFont = BaseFont.CreateFont("C:/Windows/Fonts/arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, 8 , iTextSharp.text.Font.NORMAL);
            iTextSharp.text.Font fontHeader = new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.NORMAL);
            PdfPTable table = new PdfPTable(new float[] { 30, 18, 15, 25, 9, 10, 10, 38 });
            PdfPCell cell = new PdfPCell(new Phrase("Cписок фильмов", fontHeader));

            cell.Colspan = dataGridView1.Columns.Count;
            cell.HorizontalAlignment = 1;
            cell.Border = 0;
            table.AddCell(cell);

            for (int j = 0; j < 8; j++)
            {
                cell = new PdfPCell(new Phrase(new Phrase(dataGridView1.Columns[j].HeaderText, font)));
                cell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY;
                cell.HorizontalAlignment = 1;
                table.AddCell(cell);
            }

            for (int j = 0; j < dataGridView1.Rows.Count; j++)
            {
                for (int k = 0; k < 8; k++)
                {
                    cell = new PdfPCell(new Phrase(dataGridView1.Rows[j].Cells[k].Value.ToString(), font));
                    cell.HorizontalAlignment = 1;
                    table.AddCell(cell);
                }
            }
            //Добавляем таблицу в документ
            doc.Add(table);
            doc.Close();

            MessageBox.Show("Pdf-документ сохранен");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)       
            {
                
                MessageBox.Show("• Чтобы добавить фильм нажмите на кнопку \"Открыть окно добавления фильмов\".\n\n" +
                    "• Чтобы просмотреть уже добавленные ранее фильмы нажмите на кнопку \"Открыть окно добавления фильмов\".\n\n" +
                    "• Чтобы найти фильм в списке используейте поиск.\n\n" +
                    "• Чтобы удалить фильм выделите его в списке, нажав на ячейку с номером фильма, либо найдите фильм с помощью поиска, он выделится автоматически, и нажмите кнопку \"Удалить фильм\".\n\n" +
                    "• Чтобы сохранить список фильмов в PDF файл нажмите на кнопку \"Сохранить в PDF\".\n\n" +
                    "Вы можете изменять данные фильмов прямо в таблице, для этого кликните 2 раза на ячейку в которой хотите изменить данные, измените данные и нажмите на кнопку \"Сохранить изменения\".\n\n" +
                    "• Горячие клавиши:\nПолучить список фильмов   –   CTRL+G\n" +
                    "Сохранить изменения   –   CTRL+S\n" +
                    "Открыть окно добавления фильмов   –   CTRL+O\n" +
                    "Поиск   –   CTRL+N\n" +
                    "Удалить выделенный фильм   –   CTRL+D\n" +
                    "Сохранить в PDF   –   CTRL+P", "Помощь");
                e.SuppressKeyPress = true;  
            }
            if (e.Control && e.KeyCode == Keys.G)
            {
                GetDataButton_Click(sender, e);
                e.SuppressKeyPress = true;  
            }
            if (e.Control && e.KeyCode == Keys.S)
            {
                SaveChangesButton_Click(sender, e);
                e.SuppressKeyPress = true; 
            }
            if (e.Control && e.KeyCode == Keys.O)
            {
                OpenAddFilmFormButton_Click(sender, e);
                e.SuppressKeyPress = true;
            }
            if (e.Control && e.KeyCode == Keys.N)
            {
                SearchTextBox.Select();
                e.SuppressKeyPress = true;
            }
            if (e.Control && e.KeyCode == Keys.D)
            {
                DeleteMovieButton_Click(sender, e);
                e.SuppressKeyPress = true;
            }
            if (e.Control && e.KeyCode == Keys.P)
            {
                SaveToPDF_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }
    }
}