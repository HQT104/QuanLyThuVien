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
    class CheckfineViewModel : BaseViewModel
    {
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

