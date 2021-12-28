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
using QuanLyThuVien.UserControls;

namespace QuanLyThuVien.ViewModel
{
    class HomeViewModel : BaseViewModel
    {

        public ICommand AddBook { get; set; }
        public ICommand AddCard { get; set; }
        public ICommand Fine { get; set; }
        public ICommand AddInforBorrow { get; set; }
        public ICommand ReturnBookCommand { get; set; }
        public ICommand BorrowCommand { get; set; }
        public ICommand ReportCommand { get; set; }

        public HomeViewModel()
        {
            AddBook = new RelayCommand<HomeControl>((p) => { return true; }, (p) => { BookManagementWindow bookManagementWindow = new BookManagementWindow(); bookManagementWindow.ShowDialog(); });
            AddCard = new RelayCommand<HomeControl>((p) => { return true; }, (p) => { CardManagementWindow cardManagementWindow = new CardManagementWindow(); cardManagementWindow.ShowDialog(); });
            Fine = new RelayCommand<HomeControl>((p) => { return true; }, (p) => { Checkfine checkfine = new Checkfine(); checkfine.ShowDialog(); });
            AddInforBorrow = new RelayCommand<HomeControl>((p) => { return true; }, (p) => { InformationBorrowWindow information = new InformationBorrowWindow(); information.ShowDialog(); });
            ReturnBookCommand = new RelayCommand<HomeControl>((p) => { return true; }, (p) => { ReturnBookWindow returnBook = new ReturnBookWindow(); returnBook.ShowDialog(); });
            BorrowCommand = new RelayCommand<HomeControl>((p) => { return true; }, (p) => { BorrowBookWindow bookWindow = new BorrowBookWindow(); bookWindow.ShowDialog(); });
            ReportCommand = new RelayCommand<HomeControl>((p) => { return true; }, (p) => { ReportWindow reportWindow = new ReportWindow(); reportWindow.ShowDialog(); });
        }
    }
}
