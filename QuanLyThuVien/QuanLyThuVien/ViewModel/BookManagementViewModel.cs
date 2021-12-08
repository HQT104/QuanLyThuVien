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

        public BookManagementViewModel()
        {
            BackHome = new RelayCommand<BookManagementWindow>((p) => { return true; }, (p) => { p.Close(); });
            OpenAddBook = new RelayCommand<BookManagementWindow>((p) => { return true; }, (p) => { OpenAddBookWD(p); });
            ExitBook = new RelayCommand<AddBookWindow>((p) => { return true; }, (p) => { p.Close(); });
            AddBoook = new RelayCommand<AddBookWindow>((p) => { return true; }, (p) => { p.Close(); });


        }

        public void OpenAddBookWD(BookManagementWindow bookManagementWindow)
        {
            AddBookWindow addBookWindow = new AddBookWindow();
            addBookWindow.ShowDialog();

        }
    }
}
