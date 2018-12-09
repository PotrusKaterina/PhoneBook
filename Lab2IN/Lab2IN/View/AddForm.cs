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
    public partial class AddForm : Form
    {

        IConnectionFactory connectionFactory;
        IAddController controller;

        public AddForm()
        {
            InitializeComponent();
            connectionFactory = new ConnectionFactory();
            controller = new AddController(connectionFactory);
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            NameValidation.Visible = false;
            PhoneValidation.Visible = false;
            string name = NameField.Text;
            if (name.Count() == 0)
            {
                NameValidation.Visible = true;
                return;
            }
            string surname = SurnameField.Text;
            string address = AddressField.Text;
            string phone = Phone.Text;
            if(phone.Count() == 0)
            {
                PhoneValidation.Visible = true;
                return;
            }
            controller.AddToData(new UserModel {
                                                Name = name,
                                                Surname = surname,
                                                Address = address, 
                                                Number = phone, 
                                            });
            MessageBox.Show("Succesfully added");
        }

        private void ToMainMenu_Click(object sender, EventArgs e)
        {
            Number17 mainForm = new Number17();
            mainForm.Show();
            this.Hide();
        }
    }
}
