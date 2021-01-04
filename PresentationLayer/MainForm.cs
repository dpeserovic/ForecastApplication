using DataAccessLayer;
using DataAccessLayer.Entities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class MainForm : Form
    {
        private DataSynchronizator _cityRepository = new DataSynchronizator();
        private BindingSource _tableBindingSourceCity = new BindingSource();
        private DataSynchronizator _favoriteRepository = new DataSynchronizator();
        private BindingSource _tableBindingSourceFavorite = new BindingSource();

        public MainForm()
        {
            InitializeComponent();
            _tableBindingSourceCity.DataSource = _cityRepository.GetCities();
            _tableBindingSourceFavorite.DataSource = _favoriteRepository.GetFavorites();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridViewCities.DataSource = _tableBindingSourceCity;
            dataGridViewFavorites.DataSource = _tableBindingSourceFavorite;

            DataGridViewImageColumn buttonFavorite = new DataGridViewImageColumn();
            buttonFavorite.Image = Image.FromFile("favorite.png");
            buttonFavorite.Width = 20;
            buttonFavorite.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCities.Columns.Insert(5, buttonFavorite);
            dataGridViewCities.Columns[5].HeaderText = "Favorite";
            dataGridViewCities.AutoGenerateColumns = false;

            DataGridViewImageColumn buttonWeather = new DataGridViewImageColumn();
            buttonWeather.Image = Image.FromFile("weather.png");
            buttonWeather.Width = 20;
            buttonWeather.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewFavorites.Columns.Insert(5, buttonWeather);
            dataGridViewFavorites.Columns[5].HeaderText = "Weather";
            dataGridViewFavorites.AutoGenerateColumns = false;

            DataGridViewImageColumn buttonDelete = new DataGridViewImageColumn();
            buttonDelete.Image = Image.FromFile("delete.png");
            buttonDelete.Width = 40;
            buttonWeather.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewFavorites.Columns.Insert(6, buttonDelete);
            dataGridViewFavorites.Columns[6].HeaderText = "Delete";
            dataGridViewFavorites.AutoGenerateColumns = false;
        }

        private void dataGridViewCities_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCities.CurrentCell.ColumnIndex.Equals(5) && e.RowIndex != -1)
            {
                var id = Convert.ToInt32(dataGridViewCities.Rows[e.RowIndex].Cells[0].Value);
                var cityName = dataGridViewCities.Rows[e.RowIndex].Cells[1].Value.ToString();
                var country = dataGridViewCities.Rows[e.RowIndex].Cells[2].Value.ToString();
                var lon = dataGridViewCities.Rows[e.RowIndex].Cells[3].Value.ToString();
                var lat = dataGridViewCities.Rows[e.RowIndex].Cells[4].Value.ToString();

                var city = new City
                {
                    Id = id,
                    CityName = cityName,
                    Country = country,
                    Lon = lon,
                    Lat = lat
                };

                if (_cityRepository.IsAdded(id))
                {
                    _cityRepository.AddCity(city);
                    SuccessForm successForm = new SuccessForm();
                    successForm.Show();
                    _tableBindingSourceFavorite.DataSource = _favoriteRepository.GetFavorites();
                }
                else
                {
                    FailForm failForm = new FailForm();
                    failForm.Show();
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var id = numericUpDownId.Value;
            var cityName = textBoxCity.Text;
            var country = textBoxCountry.Text;
            var lon = textBoxLon.Text;
            var lat = textBoxLat.Text;

            dataGridViewCities.DataSource = _cityRepository.Search(id, cityName, country, lon, lat);
        }

        private void dataGridViewFavorites_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewFavorites.CurrentCell.ColumnIndex.Equals(6) && e.RowIndex != -1)
            {
                var id = Convert.ToInt32(dataGridViewFavorites.Rows[e.RowIndex].Cells[0].Value);
                var cityName = dataGridViewFavorites.Rows[e.RowIndex].Cells[1].Value.ToString();
                var country = dataGridViewFavorites.Rows[e.RowIndex].Cells[2].Value.ToString();
                var lon = dataGridViewFavorites.Rows[e.RowIndex].Cells[3].Value.ToString();
                var lat = dataGridViewFavorites.Rows[e.RowIndex].Cells[4].Value.ToString();

                var city = new City
                {
                    Id = id,
                    CityName = cityName,
                    Country = country,
                    Lon = lon,
                    Lat = lat
                };
                _favoriteRepository.DeleteCity(city);
                SuccessForm successForm = new SuccessForm();
                successForm.Show();
                _tableBindingSourceFavorite.DataSource = _favoriteRepository.GetFavorites();
            }

            if (dataGridViewFavorites.CurrentCell.ColumnIndex.Equals(5) && e.RowIndex != -1)
            {
                var id = Convert.ToInt32(dataGridViewFavorites.Rows[e.RowIndex].Cells[0].Value);
                WeatherForm weatherForm = new WeatherForm(id);
                weatherForm.Show();
            }
        }
    }
}