using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APItask.Models;
using APItask.Infrastructure;
using System.Net;
using System.Collections.Specialized;
using System.Threading;
using System.Collections.Concurrent;

namespace APItask
{
    public partial class APIvalues : Form
    {
        private int _currentPage = 0;
        private int _cloudsPerPage = 20;
        public APIvalues()
        {
            InitializeComponent();
        }

        private async void fetchBTN_Click(object sender, EventArgs e)
        {
            cloudTable.DataSource = await Task.Run(() => CloudAPI.Fetch());
        }

        private void fetchDatabaseBTN_Click(object sender, EventArgs e)
        {
            _currentPage = 0;
            GetAllCouds();
        }

        private async void FetchandInsertintoLocalDB_Click(object sender, EventArgs e)
        {
            var ApiInfo = await Task.Run(() => CloudAPI.Fetch());

            var _db = new DB();
            _db.Delete();

            var primeNumbers = new ConcurrentBag<string>();
            var insertQuery = "INSERT INTO APIvalues (Id, Name, Date, Comment) Values ";

            var values = new ConcurrentBag<string>();

            Parallel.ForEach(ApiInfo, item =>
            {
                values.Add($"({item.Id}, '{item.Name}', '{item.Date}', '{item.Comment}')");
            });

            var allValues = string.Join(",", values);

            _db.RunQuery(insertQuery + allValues);
            cloudTable.DataSource = ApiInfo;
            MessageBox.Show("Records Inserted Successfully!");
        }

        private void filterBTN_Click(object sender, EventArgs e)
        {
            _currentPage = 0;
            FilterClouds();
        }



        private void previousPageBTN_Click(object sender, EventArgs e)
        {
            if (_currentPage < 0) return;
            _currentPage--;
            LoadCloudsForTheTable();
        }

        private void nextPageBTN_Click(object sender, EventArgs e)
        {
            _currentPage++;
            LoadCloudsForTheTable();
            if (cloudTable.Rows.Count == 0)
            {
                _currentPage--;
                LoadCloudsForTheTable();
                System.Windows.Forms.MessageBox.Show("No More Records Found!");
            }
        }

        private void Countdrp_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = int.Parse(Countdrp.SelectedItem.ToString());
            _cloudsPerPage = count;
            LoadCloudsForTheTable();
        }

        private void LoadCloudsForTheTable()
        {

            if (string.IsNullOrWhiteSpace(searchTerm.Text))
            {
                GetAllCouds();
            }
            else
            {
                FilterClouds();
            }
        }

        private void GetAllCouds()
        {
            var _db = new DB();
            cloudTable.DataSource = _db.Select(_currentPage, _cloudsPerPage);
        }
        private void FilterClouds()
        {
            var searchCoin = new Cloud()
            {
                Id = searchTerm.Text,
                Name = searchTerm.Text,
                Date = searchTerm.Text,
                Comment = searchTerm.Text
            };

            var _db = new DB();
            cloudTable.DataSource = _db.Select(searchCoin, _currentPage, _cloudsPerPage);
        }
        private void InsertIntoAPI_Click(object sender, EventArgs e)
        {
            using (var wb = new WebClient())
            {
                var data = new NameValueCollection();
                data["id"] = TxtId.Text;
                data["name"] = TxtName.Text;
                data["date"] = TxtDate.Text;
                data["comment"] = TxtComment.Text;

                var response = wb.UploadValues("http://tasks.cloudsite.ir/api/", "POST", data);
                string responseInString = Encoding.UTF8.GetString(response);
                System.Windows.Forms.MessageBox.Show("Records Inserted Into API!");
            }
        }
        private void Reset_Click(object sender, EventArgs e)
        {
            searchTerm.Text = "";
            cloudTable.DataSource = null;
        }
        private void ResetTxt_Click(object sender, EventArgs e)
        {
            TxtId.Text = "";
            TxtName.Text = "";
            TxtDate.Text = "";
            TxtComment.Text = "";
        }
    }
}
