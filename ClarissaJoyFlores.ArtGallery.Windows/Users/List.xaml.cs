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
    /// Interaction logic for List.xaml
    /// </summary>
    public partial class List : Window
    {
        private string sortBy = "FirstName";
        private string sortOrder = "asc";
        private string keyword = "";
        private int pageSize = 5;
        private int pageIndex = 1;
        private long pageCount = 1;

        public List()
        {
            InitializeComponent();
            cboSortBy.ItemsSource = new List<string>() { "FirstName", "LastName" };
            cboSortOrder.ItemsSource = new List<string>() { "Ascending", "Descending" };

            showData();
        }

        public void showData()
        {


            var user = Userbll.Search(pageIndex, pageSize, sortBy, sortOrder, keyword);

            dgUsers.ItemsSource = user.Items;
            pageCount = user.PageCount;
        }

   


        private void BtnFirst_Click(object sender, RoutedEventArgs e)
        {
            pageIndex = 1;
            showData();
        }

        private void BtnPrevious_Click(object sender, RoutedEventArgs e)
        {
            pageIndex = pageIndex - 1;
            if (pageIndex < 1)
            {
                pageIndex = 1;
            };
            showData();

        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            pageIndex = pageIndex + 1;
            if (pageIndex > pageCount)
            {
                pageIndex = (int)pageCount;
            };
            showData();
        }

        private void BtnLast_Click(object sender, RoutedEventArgs e)
        {
            pageIndex = (int)pageCount;
            showData();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            UserAdd addWindow = new Users.UserAdd(this);
            addWindow.Show();
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

        private void TxtKeyword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                keyword = txtKeyword.Text;
                showData();
            }
        }


        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            UserDTO userDto = ((FrameworkElement)sender).DataContext as UserDTO;

            if (MessageBox.Show("Are you sure you want to delete " + userDto.FirstName + " " + userDto.Email + "?",
                        "Are you sure?", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                var op = Userbll.Delete(userDto.UserID);

                if (op.Code != "200")
                {
                    MessageBox.Show("Error : " + op.Message);
                }
                else
                {
                    MessageBox.Show("Research is successfully deleted from table");
                    showData();
                }
            };
        }

        private void btnDeactivate_Click(object sender, RoutedEventArgs e)
        {
            UserDTO userDto = ((FrameworkElement)sender).DataContext as UserDTO;

            if (MessageBox.Show("Are you sure you want to deactivate " + userDto.FirstName + " " + userDto.Email + "?",
                        "Are you sure?", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                var op = Userbll.Deactivate(userDto.UserID);

                if (op.Code != "200")
                {
                    MessageBox.Show("Error : " + op.Message);
                }
                else
                {
                    MessageBox.Show("User is successfully deactivated from table");
                    showData();
                }
            };
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            UserDTO userDTO = ((FrameworkElement)sender).DataContext as UserDTO;
            User user = new User();
            //Userbll.UpdateUser(, this);
            this.Show();
            ////Update update = new Update(List parentWindow, ResearchDTO research);
            //update.Show();
        }

        private void cboSortBy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            sortBy = cboSortBy.SelectedValue.ToString();
            showData();
        }

        private void BtnArtist_Click(object sender, RoutedEventArgs e)
        {
            Artists.List list = new Artists.List();
            list.Show();
        }

        private void BtnArtwork_Click(object sender, RoutedEventArgs e)
        {
            Artworks.List list = new Artworks.List();
            list.Show();
        }

        private void TxtPageSize_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtPageSize.Text.Length > 0)
            {
                int.TryParse(txtPageSize.Text, out pageSize);
                showData();
            }

        }
    }
}
