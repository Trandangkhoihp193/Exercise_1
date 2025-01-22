using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new ServiceReference1.WebService1SoapClient();
                var response = await client.GetAllCountriesAsync();
                var countries = response.Body.GetAllCountriesResult;

                if (countries != null && countries.Length > 0)
                {
                    dgvResults.DataSource = null;
                    dgvResults.DataSource = ConvertCountriesToDataTable(countries);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy quốc gia nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void getCountrybyCode_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new ServiceReference1.WebService1SoapClient();
                string countryCode = txb_CountryCode.Text.Trim();

                if (string.IsNullOrEmpty(countryCode))
                {
                    MessageBox.Show("Vui lòng nhập mã quốc gia hợp lệ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var response = await client.GetCountryByCodeAsync(countryCode);
                var country = response.Body.GetCountryByCodeResult;

                if (country != null)
                {
                    dgvResults.DataSource = null;
                    dgvResults.DataSource = ConvertCountryToDataTable(new ServiceReference1.Country[] { country });
                }
                else
                {
                    MessageBox.Show("Không tìm thấy quốc gia.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void getCityByName_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new ServiceReference1.WebService1SoapClient();
                string cityName = txb_CityName.Text.Trim();

                if (string.IsNullOrEmpty(cityName))
                {
                    MessageBox.Show("Vui lòng nhập tên thành phố hợp lệ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var response = await client.GetCityByNameAsync(cityName);
                var city = response.Body.GetCityByNameResult;

                if (city != null)
                {
                    dgvResults.DataSource = null;
                    dgvResults.DataSource = ConvertCityToDataTable(new ServiceReference1.City[] { city });
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thành phố.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void getAllCityFromCountry_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new ServiceReference1.WebService1SoapClient();
                string countryCode = txb_CountryCode.Text.Trim();

                if (string.IsNullOrEmpty(countryCode))
                {
                    MessageBox.Show("Vui lòng nhập mã quốc gia hợp lệ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var response = await client.GetAllCitiesByCountryCodeAsync(countryCode);
                var cities = response.Body.GetAllCitiesByCountryCodeResult;

                if (cities != null && cities.Length > 0)
                {
                    dgvResults.DataSource = null;
                    dgvResults.DataSource = ConvertToDataTable(cities);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thành phố nào cho mã quốc gia đã nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable ConvertToDataTable(ServiceReference1.City[] cities)
        {
            var table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("CountryCode", typeof(string));
            table.Columns.Add("District", typeof(string));
            table.Columns.Add("Population", typeof(int));

            foreach (var city in cities)
            {
                table.Rows.Add(city.ID, city.Name, city.CountryCode, city.District, city.Population);
            }

            return table;
        }

        private DataTable ConvertCityToDataTable(ServiceReference1.City[] cities)
        {
            var table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("CountryCode", typeof(string));
            table.Columns.Add("District", typeof(string));
            table.Columns.Add("Population", typeof(int));

            foreach (var city in cities)
            {
                table.Rows.Add(city.ID, city.Name, city.CountryCode, city.District, city.Population);
            }

            return table;
        }

        private DataTable ConvertCountriesToDataTable(ServiceReference1.Country[] countries)
        {
            var table = new DataTable();
            table.Columns.Add("Code", typeof(string));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Continent", typeof(string));
            table.Columns.Add("Region", typeof(string));
            table.Columns.Add("Population", typeof(int));

            foreach (var country in countries)
            {
                table.Rows.Add(country.Code, country.Name, country.Continent, country.Region, country.Population);
            }

            return table;
        }

        private DataTable ConvertCountryToDataTable(ServiceReference1.Country[] countries)
        {
            var table = new DataTable();
            table.Columns.Add("Code", typeof(string));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Continent", typeof(string));
            table.Columns.Add("Region", typeof(string));
            table.Columns.Add("Population", typeof(int));

            foreach (var country in countries)
            {
                table.Rows.Add(country.Code, country.Name, country.Continent, country.Region, country.Population);
            }

            return table;
        }

        private DataTable ConvertListToDataTable(List<string> list)
        {
            var table = new DataTable();
            table.Columns.Add("Language", typeof(string));

            foreach (var item in list)
            {
                table.Rows.Add(item);
            }

            return table;
        }

        private async void btn_getLangs_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new ServiceReference1.WebService1SoapClient();
                string countryCode = txb_CountryCode.Text.Trim();

                if (string.IsNullOrEmpty(countryCode))
                {
                    MessageBox.Show("Vui lòng nhập mã quốc gia hợp lệ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var response = await client.GetCountryLanguageAsync(countryCode);
                var languages = response.Body.GetCountryLanguageResult;

                if (languages != null && languages.Any())
                {
                    dgvResults.DataSource = ConvertListToDataTable(languages);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy ngôn ngữ nào cho mã quốc gia đã nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
