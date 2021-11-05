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

        private void GetDataButton_Click(object sender, EventArgs e)
        {
            MoviesRepository repository = new MoviesRepository();
            MoviesService movieService = new MoviesService(repository);
            MainFormDataViewModel.movies = movieService.GetAllMovies();
            dataGridView1.DataSource = MainFormDataViewModel.movies;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            MoviesRepository repository = new MoviesRepository();
            MoviesService movieService = new MoviesService(repository);
            movieService.UpdateAllMovies(MainFormDataViewModel.movies);
        }
    }
}
