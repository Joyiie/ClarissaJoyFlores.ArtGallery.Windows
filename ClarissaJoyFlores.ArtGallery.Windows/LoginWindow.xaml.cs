using ClarissaJoyFlores.ArtGallery.Windows.BLL;
using ClarissaJoyFlores.ArtGallery.Windows.Helpers;
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

namespace ClarissaJoyFlores.ArtGallery.Windows
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            lblError.Content = "";

            if (string.IsNullOrEmpty(txtEmailAddress.Text))
            {
                lblError.Content = "Invalid Login";
                return;

            };

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                lblError.Content = "Invalid Login";
                return;
            };


            var op = Userbll.Login(txtEmailAddress.Text, txtPassword.Text);

            if (op.Code == "200")
            {
                var users = Userbll.GetById(op.ReferenceId);
                var roles = Userbll.GetRoles(op.ReferenceId);

                ProgramUser.Id = op.ReferenceId;
                ProgramUser.FirstName = users.FirstName;
                ProgramUser.LastName = users.LastName;
                ProgramUser.EmailAddress = users.Email;
                ProgramUser.Roles = roles;

                Users.List userList = new Users.List();
                userList.Show();
                this.Close();
            }
            else
            {
                lblError.Content = "Invalid Login";
            }


        }

    }
}

