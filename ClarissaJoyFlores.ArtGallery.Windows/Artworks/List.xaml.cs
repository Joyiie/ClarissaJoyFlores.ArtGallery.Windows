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

namespace ClarissaJoyFlores.ArtGallery.Windows.Artworks
{
    /// <summary>
    /// Interaction logic for List.xaml
    /// </summary>
    public partial class List : Window
    {
        private string sortBy = "title";
        private string sortOrder = "asc";
        private string keyword = "";
        private int pageSize = 1;
        private int pageIndex = 1;
        private long pageCount = 1;

        public List()
        {
            InitializeComponent();

            cboSortBy.ItemsSource = new List<string>() { "Title" };
            cboSortOrder.ItemsSource = new List<string>() { "Ascending", "Descending" };
            showData();
        }

        public void showData()
        {
            var Artwork = Artworkbll.Search(pageIndex, pageSize, sortBy, sortOrder, keyword);

            dgArtwork.ItemsSource = Artwork.Items;
            pageCount = Artwork.PageCount;

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
            ArtworkAdd addWindow = new Artworks.ArtworkAdd(this);
            addWindow.Show();
        }

        private void TxtKeyword_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                keyword = txtKeyword.Text;

                showData();
            }
        }

     
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            ArtworkDTO artworkDTO = ((FrameworkElement)sender).DataContext as ArtworkDTO;

            if (MessageBox.Show("Are you sure you want to delete " + artworkDTO.Title + " " + artworkDTO.Content + "?",
                        "Are you sure?", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                var op = Artworkbll.Delete(artworkDTO.ArtistID);

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
            ArtworkDTO artworkDTO = ((FrameworkElement)sender).DataContext as ArtworkDTO;

            if (MessageBox.Show("Are you sure you want to deactivate " + artworkDTO.Title + " " + artworkDTO.Content + "?",
                        "Are you sure?", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                var op = Artworkbll.Deactivate(artworkDTO.ArtistID);

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
            ArtworkDTO artworkDTO = ((FrameworkElement)sender).DataContext as ArtworkDTO;
            Artwork artwork = new Artwork();
            //Userbll.UpdateUser(, this);
            this.Show();
            ////Update update = new Update(List parentWindow, ResearchDTO research);
            //update.Show();
        }

    }
}
