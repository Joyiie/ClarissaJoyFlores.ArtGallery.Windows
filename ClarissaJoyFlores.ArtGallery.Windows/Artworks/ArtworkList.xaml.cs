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

namespace ClarissaJoyFlores.ArtGallery.Windows.Artworks
{
    /// <summary>
    /// Interaction logic for ArtworkList.xaml
    /// </summary>

        public partial class ArtworkList : Window
        {
            private string sortBy = "title";
            private string sortOrder = "asc";
            private string keyword = "";
            private int pageSize = 1;
            private int pageIndex = 1;
            private long pageCount = 1;
            public ArtworkList()
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

            private void btnFirst_Click(object sender, RoutedEventArgs e)
            {
                pageIndex = 1;
                showData();
            }

            private void btnPrevious_Click(object sender, RoutedEventArgs e)
            {
                pageIndex = pageIndex - 1;
                if (pageIndex < 1)
                {
                    pageIndex = 1;
                };

                showData();
            }

            private void btnNext_Click(object sender, RoutedEventArgs e)
            {
                pageIndex = pageIndex + 1;
                if (pageIndex > pageCount)
                {
                    pageIndex = (int)pageCount;
                };
                showData();
            }

            private void btnLast_Click(object sender, RoutedEventArgs e)
            {
                pageIndex = (int)pageCount;
                showData();
            }

            private void txtSearch_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.Key == Key.Return)
                {
                    keyword = txtSearch.Text;

                    showData();
                }
            }

            private void txtPageSize_KeyDown(object sender, KeyEventArgs e)
            {
                if (txtPageSize.Text.Length > 0)
                {
                    int.TryParse(txtPageSize.Text, out pageSize);
                    showData();
                }
            }

       

        private void btnAddNew_Click(object sender, RoutedEventArgs e)
        {
            Artworks.ArtworkAdd listWindow = new Artworks.ArtworkAdd(this);
            listWindow.Show();
        }
    }
    }

