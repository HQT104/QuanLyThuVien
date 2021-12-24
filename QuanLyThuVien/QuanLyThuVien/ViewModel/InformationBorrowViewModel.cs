using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using QuanLyThuVien.ViewModel;
using QuanLyThuVien.UserControls;
using System.Windows;
using QuanLyThuVien.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Media;
using System.Security.Cryptography;

namespace QuanLyThuVien.ViewModel
{
    class InformationBorrowViewModel : BaseViewModel
    {
        private ObservableCollection<PHIEUMUON> _BorrowList;
        public ObservableCollection<PHIEUMUON> BorrowList { get => _BorrowList; set { _BorrowList = value; OnPropertyChanged(); } }
        public ICommand Backib { get; set; }
        public ICommand Findmt { get; set; }
        public InformationBorrowViewModel()
        {
            Backib = new RelayCommand<InformationBorrowWindow>((p) => { return true; }, (p) => { p.Close(); });
            Findmt = new RelayCommand<InformationBorrowWindow>((p) => { return true; }, (p) => { Searchmt(p); });
        }

        public void Searchmt(InformationBorrowWindow ib)
        {

        }
    }
}
