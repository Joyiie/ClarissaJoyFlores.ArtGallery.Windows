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
    /// Interaction logic for List.xaml
    /// </summary>
    public partial class List : Window
    {
        private string sortBy = "name";
        private string sortOrder = "asc";
        private string keyword = "";
        private int pageSize = 1;
        private int pageIndex = 1;
        private long pageCount = 1;
        public List()
        {
            InitializeComponent();

            cboSortBy.ItemsSource = new List<string>() { "Name" };
            cboSortOrder.ItemsSource = new List<string>() { "Ascending", "Descending" };
            showData();
        }

        public void showData()
        {
            var Artists = Artistbll.Search(pageIndex, pageSize, sortBy, sortOrder, keyword);

            dgArtist.ItemsSource = Artists.Items;
            pageCount = Artists.PageCount;

        }
        private void TxtPageSize_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtPageSize.Text.Length > 0)
            {
                int.TryParse(txtPageSize.Text, out pageSize);
                showData();
            }

        }

        private void TxtKeyword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                keyword = txtKeyword.Text;

                showData();
            }
        }

        private void CboSortBy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            sortBy = cboSortBy.SelectedValue.ToString();
            showData();
        }

        private void CboSortOrder_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboSortOrder.SelectedValue.ToString().ToLower() == "ascending")
            {
                sortOrder = "asc";
            }
            else
            {
                sortOrder = "desc";
            }
            showData();
        }

        private void BtnFirst_Click_1(object sender, RoutedEventArgs e)
        {

            pageIndex = 1;
            showData();
        }

        private void BtnPrevious_Click_1(object sender, RoutedEventArgs e)
        {
            pageIndex = pageIndex - 1;
            if (pageIndex < 1)
            {
                pageIndex = 1;
            };

            showData();
        }

        private void BtnNext_Click_1(object sender, RoutedEventArgs e)
        {
            pageIndex = pageIndex + 1;
            if (pageIndex > pageCount)
            {
                pageIndex = (int)pageCount;
            };
            showData();
        }

        private void BtnLast_Click_1(object sender, RoutedEventArgs e)
        {
            pageIndex = (int)pageCount;
            showData();
        }

      

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {

        }



        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            ArtistDTO artistDTO = ((FrameworkElement)sender).DataContext as ArtistDTO;

            if (MessageBox.Show("Are you sure you want to delete " + artistDTO.Name + " " + artistDTO.BirthPlace + "?",
                        "Are you sure?", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                var op = Artistbll.Delete(artistDTO.ArtistID);

                if (op.Code != "200")
                {
                    MessageBox.Show("Error : " + op.Message);
                }
                else
                {
                    MessageBox.Show("Artwork is successfully deleted from table");
                    showData();
                }
            };
        }

        private void btnDeactivate_Click(object sender, RoutedEventArgs e)
        {
            ArtistDTO artistDTO = ((FrameworkElement)sender).DataContext as ArtistDTO;


            if (MessageBox.Show("Are you sure you want to deactivate " + artistDTO.Name + " " + artistDTO.BirthPlace + "?",
                        "Are you sure?", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                var op = Artworkbll.Deactivate(artistDTO.ArtistID);

                if (op.Code != "200")
                {
                    MessageBox.Show("Error : " + op.Message);
                }
                else
                {
                    MessageBox.Show("Artwork is successfully deactivated from table");
                    showData();
                }
            };
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            ArtistDTO artistDTO = ((FrameworkElement)sender).DataContext as ArtistDTO;
            Artist artist = new Artist();
            //Userbll.UpdateUser(, this);
            this.Show();
            ////Update update = new Update(List parentWindow, ResearchDTO research);
            //update.Show();
        }

    
    }
}
