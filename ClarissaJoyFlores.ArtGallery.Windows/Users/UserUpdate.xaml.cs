using ClarissaJoyFlores.ArtGallery.Windows.BLL;
using ClarissaJoyFlores.ArtGallery.Windows.DTO;
using ClarissaJoyFlores.ArtGallery.Windows.Models;
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

namespace ClarissaJoyFlores.ArtGallery.Windows.Users
{
    /// <summary>
    /// Interaction logic for UserUpdate.xaml
    /// </summary>
    public partial class UserUpdate : Window
    {
        List myParentWindow = new List();
        private UserDTO userDTO;

        public UserUpdate(List parentWindow,UserDTO userdto)
        {
            InitializeComponent();

            userDTO = userdto;
            myParentWindow = parentWindow;


            txtFirstName.Text = userdto.FirstName;
            txtLastName.Text = userdto.LastName;
            txtAddress.Text = userdto.Address;
            txtSex.Text = userdto.Sex;
            txtContactNumber.Text = userdto.ContactNumber;
            txtEmail.Text = userdto.Email;
            txtPassword.Text = userdto.Password;

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

            var op = Userbll.UpdateUser(new User()
            {
                UserID = userDTO.UserID,
                FirstName = txtFirstName.Text,
                LastName  = txtLastName.Text,
                Address = txtAddress.Text,
                Sex = txtSex.Text,
                ContactNumber = txtContactNumber.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text,
            });


            if (op.Code != "200")
            {
                MessageBox.Show("Error : " + op.Message);
            }
            else
            {
                MessageBox.Show("User is successfully updated");
            }

            this.Close();

        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
