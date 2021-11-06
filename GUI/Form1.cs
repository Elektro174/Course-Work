using Data.Repositiries;
using Domain;
using GUI.Models.ViewModels;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void SetDataGridViewHeaders()
        {
            dataGridView1.Columns [0].HeaderText = "Название";
            dataGridView1.Columns [1].HeaderText = "Имя Режисёра";
            dataGridView1.Columns [2].HeaderText = "Фамилия режисёра";
            dataGridView1.Columns [3].HeaderText = "Страна";
            dataGridView1.Columns [4].HeaderText = "Год выпуска";
            dataGridView1.Columns [5].HeaderText = "Бюджет $";
            dataGridView1.Columns [6].HeaderText = "Кассовые сборы";
            dataGridView1.Columns [7].HeaderText = "Награды";
            dataGridView1.Columns [8].Visible = false;
            dataGridView1.Columns [9].Visible = false;
        }
        private void GetDataButton_Click(object sender, EventArgs e)
        {
            MoviesRepository repository = new MoviesRepository();
            MoviesService movieService = new MoviesService(repository);
            MainFormDataViewModel.movies = movieService.GetAllMovies();
            dataGridView1.DataSource = MainFormDataViewModel.movies;
            SetDataGridViewHeaders();
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
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

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
