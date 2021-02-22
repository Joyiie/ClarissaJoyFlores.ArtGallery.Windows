using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ClarissaJoyFlores.ArtGallery.Windows.BLL;
using ClarissaJoyFlores.ArtGallery.Windows.Models;


namespace ClarissaJoyFlores.ArtGallery.Windows.Users
{
    /// <summary>
    /// Interaction logic for UserAdd.xaml
    /// </summary>
    public partial class UserAdd : Window
    {
        List myParentWindow = new List();
        public UserAdd(List parentWindow)
        {
            InitializeComponent();
            myParentWindow = parentWindow;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            List<string> errors = new List<string>();
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                errors.Add("FirstName is required.");
            };

            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                errors.Add("LastName is required.");
            };

            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                errors.Add("Address is required.");
            };

            if (string.IsNullOrEmpty(txtSex.Text))
            {
                errors.Add("Sex is required.");
            };

            if (string.IsNullOrEmpty(txtContactNumber.Text))
            {
                errors.Add("Contact-Number is required.");
            };

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                errors.Add("Email is required.");
            };

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errors.Add("Password is required.");
            };

            if (errors.Count > 0)
            {
                foreach (var error in errors)
                {
                    txtError.Text = txtError.Text + error + "\n";
                }

                return;
            }


            var op = Userbll.Add(new User()
            {
                UserID = Guid.NewGuid(),
               FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Address = txtAddress.Text,
                Sex = txtSex.Text,
                ContactNumber = txtContactNumber.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text
            }); 

            if (op.Code != "200")
            {
                MessageBox.Show("Error : " + op.Message);
            }

            else
            {
                MessageBox.Show(" is successfully added to table");
            }

            myParentWindow.showData();
            this.Close();
        }
    }
    }

