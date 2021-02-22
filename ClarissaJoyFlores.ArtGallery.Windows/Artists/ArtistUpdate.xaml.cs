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

namespace ClarissaJoyFlores.ArtGallery.Windows.Artists
{
    /// <summary>
    /// Interaction logic for ArtistUpdate.xaml
    /// </summary>
    public partial class ArtistUpdate : Window
    {
        List myParentWindow = new List();
        private ArtistDTO artistDTO;
        public ArtistUpdate(List parentWindow, ArtistDTO artist)
        {
            InitializeComponent();

            artistDTO = artist;
            myParentWindow = parentWindow;

            txtName.Text = artist.Name;
            txtBrithPlace.Text = artist.BirthPlace;
            txtAge.Text = artist.Age;
            txtStyleOfWork.Text = artist.StyleOfWork;
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

            var op = Artistbll.Update(new Artist()
            {
                ArtistID = artistDTO.ArtistID,
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
                MessageBox.Show("User is successfully updated");
            }

            this.Close();
        }
    }
}
