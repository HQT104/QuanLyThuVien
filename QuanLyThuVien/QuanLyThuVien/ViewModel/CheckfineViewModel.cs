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
    class CheckfineViewModel : BaseViewModel
    {
        private ObservableCollection<PHIEUPHAT> _FineList;
        public ObservableCollection<PHIEUPHAT> FineList { get => _FineList; set { _FineList = value; OnPropertyChanged(); } }
        public ICommand CheckFine { get; set; }
        public ICommand Payment { get; set; }
        public ICommand Exit { get; set; }

        public CheckfineViewModel()
        {
            CheckFine = new RelayCommand<Checkfine>((p) => { return true; }, (p) => { p.Close(); });


        }
    }
}
