using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;


namespace QuanLyThuVien.ViewModel
{
  
    class BookManagementViewModel : BaseViewModel
    {
        public ICommand BackHome { get; set; }
        public ICommand OpenAddBook { get; set; }
        public ICommand ExitBook { get; set; }
        public ICommand AddBoook { get; set; }

        public ICommand LoadCommand { get; set; }


        public bool isFistVisible = false;

        private BackgroundWorker worker;

        public BookManagementViewModel()
        {
            BackHome = new RelayCommand<BookManagementWindow>((p) => { return true; }, (p) => { p.Close(); });
            OpenAddBook = new RelayCommand<BookManagementWindow>((p) => { return true; }, (p) => { OpenAddBookWD(p); });
            ExitBook = new RelayCommand<AddBookWindow>((p) => { return true; }, (p) => { p.Close(); });
            AddBoook = new RelayCommand<AddBookWindow>((p) => { return true; }, (p) => { p.Close(); });
            LoadCommand = new RelayCommand<BookManagementWindow>((p) =>
            {
                if (p.IsVisible == true && isFistVisible == false)
                {
                    isFistVisible = true;
                    return true;
                }
                else
                    return false;
            }, (p) => { Load(p); });

        }

        public void BackHomeWD(BookManagementWindow bookManagementWindow)
        {
            bookManagementWindow.Hide();

        }
        public void OpenAddBookWD(BookManagementWindow bookManagementWindow)
        {
            AddBookWindow addBookWindow = new AddBookWindow();
            addBookWindow.ShowDialog();

        }
        public void ExitAddBook(AddBookWindow addBookWindow)
        {
            addBookWindow.Close();

        }
        public void Load(BookManagementWindow b)
        {
            worker = new BackgroundWorker();
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            worker.RunWorkerAsync(b);
        }
        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BookManagementWindow p = (BookManagementWindow)e.Result;
            p.progressBar.Visibility = Visibility.Hidden;
            p.bookList.Visibility = Visibility.Visible;
        }
        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }
    }
}
