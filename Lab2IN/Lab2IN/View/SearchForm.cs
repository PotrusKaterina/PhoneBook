using Lab2IN.Controller;
using Lab2IN.Model;
using Lab2IN.Services.DBConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2IN.View
{
    public partial class SearchForm : Form
    {
        private ISearchController controller;
        private IConnectionFactory connectionFactory;

        public SearchForm()
        {
            InitializeComponent();

            connectionFactory = new ConnectionFactory();
            controller = new SearchController(connectionFactory);
            ShowContacts();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            Elements.Items.Clear();
            String searchText = SearchField.Text;
            var users = controller.SearchContacts(searchText);
            foreach(UserModel user in users)
            {
                Elements.Items.Add(user.ToString());
            }
        }

        private void ShowContacts()
        {
            Elements.Items.Clear();
            var contacts = controller.GetContacts();
            foreach (UserModel user in contacts)
            {
                Elements.Items.Add(user.ToString());
            }
        }

        private void ToMainMenu_Click(object sender, EventArgs e)
        {
            Number17 mainForm = new Number17();
            mainForm.Show();
            this.Hide();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            ShowContacts();
        }
    }
}
