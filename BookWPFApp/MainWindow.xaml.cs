using BookLib.DataAccess;
using BookLib.Repository;
using System;
using System.Windows;

namespace BookWPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IBookRepository bookRepository = new BookRepository();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var title = txtPrice.Text;
            var author = txtAuthor.Text;
            var genne = txtGenne.Text;
            var publisher = txtPublisher.Text;
            var price = txtPrice.Text;
            double dPrice = 0;

            lbError.Content = "";

            if (String.IsNullOrEmpty(title) || String.IsNullOrEmpty(author) || String.IsNullOrEmpty(genne) || String.IsNullOrEmpty(publisher) || String.IsNullOrEmpty(price))
            {
                lbError.Content = "Please fill all input";
                return;
            }


            try
            {
                dPrice = Double.Parse(txtPrice.Text);
            }
            catch (Exception)
            {
                lbError.Content = "Price must be a number";
                return;
            }


            try
            {
                Book b = new Book() { Title = txtPrice.Text, Author = txtAuthor.Text, Genre = txtGenne.Text, Publisher = txtPublisher.Text, Price = dPrice };
                bookRepository.InsertBook(b);
                MessageBox.Show("Insert successfully!");
            }
            catch (Exception)
            {
                lbError.Content = "Something wrong when input data";
                return;
            }


        }
    }
}
