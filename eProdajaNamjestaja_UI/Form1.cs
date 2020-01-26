using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eProdajaNamjestaja_UI.Util;
using eProdajaNamjestaja_API.Models;

namespace eProdajaNamjestaja_UI
{
    public partial class Form1 : Form
    {
        WeAPIHelper korisniciService = new WeAPIHelper("http://localhost:5966/", "/api/Korisnici");
        public Form1()
        {
            InitializeComponent();
        }

        private void apiCallerButton_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5966/");
            HttpResponseMessage response = korisniciService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                List<Korisnici> korisnici = response.Content.ReadAsAsync < List<Korisnici>> ().Result;
                korisniciGrid.DataSource = korisnici;
            }
            else
            {
                MessageBox.Show("Error code: " + response.StatusCode + " Message: " + response.ReasonPhrase);
            }
        }
    }
}
