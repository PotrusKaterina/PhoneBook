
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab2IN.Controller;
using Lab2IN.Model;
using Lab2IN.Services.DBConnection;
using Lab2IN.Services.Repository.Users;
using Lab2IN.View;

namespace Lab2IN
{
    public partial class Number17 : Form
    {
        private const string NameOfTheApp = "Numbers";

        public Number17()
        {
            InitializeComponent();
        }
                
        private void Name_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Picture1_Click(object sender, EventArgs e)
        {

        }

        private void SerName1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Number1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.Show();
            this.Hide();
        }

        private void Finish_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            UserModel user = new UserModel();
        }
        private void Number17_Load (object sender, EventArgs e)
        {

        }
        private void Number17_ControlRemoved(object sender, ControlEventArgs e)
        {

        }
        private void Number17_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult Result = MessageBox.Show("Are you sure?", NameOfTheApp, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (this.DialogResult == DialogResult.Yes)
                Application.Exit();
            this.TopMost = true;
        }
        private void Start_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.Show();
            this.Hide();
        }
        private void ToMainMenu_Click(object sender, EventArgs e)
        {
            
        }
    }
}
