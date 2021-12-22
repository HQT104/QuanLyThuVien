using System;
using System.Collections.Generic;
<<<<<<< HEAD
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
=======
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
>>>>>>> 7876ebffd7aed11b5ff425ea451aaa3ff39060a7

namespace QuanLyThuVien.ViewModel
{
    class CheckfineViewModel : BaseViewModel
    {
<<<<<<< HEAD
        //private ObservableCollection<PHIEUPHAT> _FineList;
        //public ObservableCollection<PHIEUPHAT> FineList { get => _FineList; set { _FineList = value; OnPropertyChanged(); } }
        public ICommand Check { get; set; }
        public ICommand Payment { get; set; }
        public ICommand Back { get; set; }

        public CheckfineViewModel()
        {
            Check = new RelayCommand<Checkfine>((p) => { return true; }, (p) => { SearchFine(p); });
            Back = new RelayCommand<Checkfine>((p) => { return true; }, (p) => {  p.Close(); });
        }


        public void SearchFine(Checkfine fine)
        {
            //string a = fine.fSearch.Text.ToLower();
            //fine.SumDebt.Clear();
            //foreach (PHIEUPHAT i in FineList)
            //{
            //    string money = i.MASV.ToLower();
            //    if (money.Contains(a))
            //    {
            //        fine.SumDebt.Text = i.SOTIENTHU.ToString();
            //        break;
            //    }
            //}
        }

    }
}

=======
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
>>>>>>> 7876ebffd7aed11b5ff425ea451aaa3ff39060a7
