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

namespace ClarissaJoyFlores.ArtGallery.Windows.Artists
{
    /// <summary>
    /// Interaction logic for ArtistAdd.xaml
    /// </summary>
    public partial class ArtistAdd : Window
    {
        List myParentWindow = new List();
        
        public ArtistAdd(List parentWindow)

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
            if (string.IsNullOrEmpty(txtName.Text))
            {
                errors.Add("Name is required.");
            };

            if (string.IsNullOrEmpty(txtBrithPlace.Text))
            {
                errors.Add("BirthPlace is required.");
            };

            if (string.IsNullOrEmpty(txtAge.Text))
            {
                errors.Add("Age is required.");
            };

            if (string.IsNullOrEmpty(txtStyleOfWork.Text))
            {
                errors.Add("StyleOfWork is required.");
            };
            if (errors.Count > 0)
            {
                foreach (var error in errors)
                {
                    txtError.Text = txtError.Text + error + "\n";
                }

                return;
            }


            var op = Artistbll.Add(new Artist()
            {
                ArtistID = Guid.NewGuid(),
                Name = txtName.Text,
                BirthPlace = txtBrithPlace.Text,
                Age = txtAge.Text,
                StyleOfWork = txtStyleOfWork.Text,

            });

            if (op.Code != "200")
            {
                MessageBox.Show("Error : " + op.Message);
            }

            else
            {
                MessageBox.Show("Artwork is successfully added to table");
            }

            myParentWindow.showData();
            this.Close();

        }

    }
}
