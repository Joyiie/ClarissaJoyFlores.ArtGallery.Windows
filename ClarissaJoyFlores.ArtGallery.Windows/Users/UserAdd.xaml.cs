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
        UsersList myParentWindow = new UsersList();
        public UserAdd(UsersList parentWindow)
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
            var op = Userbll.Add(new User()
            {
                UserID = Guid.NewGuid(),
               FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Address = txtAddress.Text,
                Sex = txtSex.Text,
                Email = txtEmail.Text,

            }); ; ;

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

