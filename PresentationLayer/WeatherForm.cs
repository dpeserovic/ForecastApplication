using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class WeatherForm : Form
    {
        private DataSynchronizator _weatherRepository = new DataSynchronizator();
        private BindingSource _tableBindingSourceWeather = new BindingSource();

        public WeatherForm(int id)
        {
            InitializeComponent();
            _tableBindingSourceWeather.DataSource = _weatherRepository.GetWeather(id);
        }

        private void WeatherForm_Load(object sender, EventArgs e)
        {
            dataGridViewWeather.DataSource = _tableBindingSourceWeather;
            dataGridViewWeather.Columns[0].Visible = false;
            dataGridViewWeather.Columns[3].Visible = false;
        }
    }
}