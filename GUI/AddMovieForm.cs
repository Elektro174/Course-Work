using Data.Repositiries;
using Domain;
using GUI.Models.ViewModels;
using Services;
using System;
using System.Drawing;
using System.Windows.Forms;
using ToolTip = System.Windows.Forms.ToolTip;

namespace GUI
{
    public partial class AddMovieForm : Form
    {
        public AddMovieForm()
        {
            InitializeComponent();

        }
        private void AddMovieForm_Load(object sender, EventArgs e)
        {
            SetHelpText();
        }
        public Form1 LogicalParent { get; set; }
        private void AddMovieButton_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie();

            if (TitleTextBox.Text == "Название"
                || TitleTextBox.Text == ""
                || DirectorFirstNameTextBox.Text == "Имя режисёра"
                || DirectorFirstNameTextBox.Text == ""
                || DirectorLastNameTextBox.Text == "Фамилия режисёра"
                || DirectorLastNameTextBox.Text == ""
                || CountryTextBox.Text == "Страна"
                || CountryTextBox.Text == ""
                || ReleasYearTextBox.Text == "Год выпуска"
                || ReleasYearTextBox.Text == ""
                || BudgetTextBox.Text == "Бюджет"
                || BudgetTextBox.Text == ""
                || SalesFeesTextBox.Text == "Кассовые сборы"
                || SalesFeesTextBox.Text == ""
                || AwardsTextBox.Text == "Награды"
                || AwardsTextBox.Text == "")
            {
                MessageBox.Show("Пожалуйста заполните все поля о фильме");
                return;
            }
            try
            {
                movie.Title = TitleTextBox.Text;
                movie.DirectorFirstName = DirectorFirstNameTextBox.Text;
                movie.DirectorLastName = DirectorLastNameTextBox.Text;
                movie.Country = CountryTextBox.Text;
                movie.ReleaseYear = Convert.ToInt32(ReleasYearTextBox.Text);
                movie.Budget = Convert.ToInt32(BudgetTextBox.Text);
                movie.SalesFees = Convert.ToInt32(SalesFeesTextBox.Text);
                movie.Awards = AwardsTextBox.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Пожалуйста введите корректные данные");
                return;
            }

            MoviesRepository moviesRepository = new MoviesRepository();
            MoviesService moviesService = new MoviesService(moviesRepository);
            moviesService.AddMovie(movie);
            MainFormDataViewModel.movies = moviesService.GetAllMovies();
            SetHelpText();
            this.LogicalParent.dataGridView1.DataSource = MainFormDataViewModel.movies;
            this.LogicalParent.SetDataGridViewHeaders();
            this.LogicalParent.dataGridView1.Update();
            MessageBox.Show("Фильм добавлен");
        }

        private void ReleasYearTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }

        private void BudgetTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }

        private void SalesFeesTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }

        private void SetHelpText()
        {
            TitleTextBox.Text = "Название";
            TitleTextBox.ForeColor = Color.Gray;

            DirectorFirstNameTextBox.Text = "Имя режисёра";
            DirectorFirstNameTextBox.ForeColor = Color.Gray;

            DirectorLastNameTextBox.Text = "Фамилия режисёра";
            DirectorLastNameTextBox.ForeColor = Color.Gray;

            CountryTextBox.Text = "Страна";
            CountryTextBox.ForeColor = Color.Gray;

            ReleasYearTextBox.Text = "Год выпуска";
            ReleasYearTextBox.ForeColor = Color.Gray;

            BudgetTextBox.Text = "Бюджет";
            BudgetTextBox.ForeColor = Color.Gray;

            SalesFeesTextBox.Text = "Кассовые сборы";
            SalesFeesTextBox.ForeColor = Color.Gray;

            AwardsTextBox.Text = "Награды";
            AwardsTextBox.ForeColor = Color.Gray;
        }

        private void TitleTextBox_Enter(object sender, EventArgs e)
        {
            TitleTextBox.Text = null;
            TitleTextBox.ForeColor = Color.Black;
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 50;
            toolTip.SetToolTip(TitleTextBox, "Название");
        }

        private void DirectorFirstNameTextBox_Enter(object sender, EventArgs e)
        {
            DirectorFirstNameTextBox.Text = null;
            DirectorFirstNameTextBox.ForeColor = Color.Black;
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 50;
            toolTip.SetToolTip(DirectorFirstNameTextBox, "Имя режисёра");
        }

        private void DirectorLastNameTextBox_Enter(object sender, EventArgs e)
        {
            DirectorLastNameTextBox.Text = null;
            DirectorLastNameTextBox.ForeColor = Color.Black;
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 50;
            toolTip.SetToolTip(DirectorLastNameTextBox, "Фамилия режисёра");
        }

        private void CountryTextBox_Enter(object sender, EventArgs e)
        {
            CountryTextBox.Text = null;
            CountryTextBox.ForeColor = Color.Black;
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 50;
            toolTip.SetToolTip(CountryTextBox, "Страна");
        }

        private void ReleasYearTextBox_Enter(object sender, EventArgs e)
        {
            ReleasYearTextBox.Text = null;
            ReleasYearTextBox.ForeColor = Color.Black;
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 50;
            toolTip.SetToolTip(ReleasYearTextBox, "Год выпуска");
        }

        private void BudgetTextBox_Enter(object sender, EventArgs e)
        {
            BudgetTextBox.Text = null;
            BudgetTextBox.ForeColor = Color.Black;
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 50;
            toolTip.SetToolTip(BudgetTextBox, "Бюджет");
        }

        private void SalesFeesTextBox_Enter(object sender, EventArgs e)
        {
            SalesFeesTextBox.Text = null;
            SalesFeesTextBox.ForeColor = Color.Black;
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 50;
            toolTip.SetToolTip(SalesFeesTextBox, "Кассовые сборы");
        }

        private void AwardsTextBox_Enter(object sender, EventArgs e)
        {
            AwardsTextBox.Text = null;
            AwardsTextBox.ForeColor = Color.Black;
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 50;
            toolTip.SetToolTip(AwardsTextBox, "Награды");
        }
    }
}