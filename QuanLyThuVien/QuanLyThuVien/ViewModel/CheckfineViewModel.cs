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
        public ICommand Check { get; set; }
        public ICommand Payment { get; set; }
        public ICommand Back { get; set; }

        public string MaSV_selected = "";
        public CheckfineViewModel()
        {
            Check = new RelayCommand<Checkfine>((p) => { return true; }, (p) => { SearchFine(p); });
            Back = new RelayCommand<Checkfine>((p) => { return true; }, (p) => { p.Close(); });
            Payment = new RelayCommand<Checkfine>((p) => { return true; }, (p) => { Pay(p); });
        }



        public void SearchFine(Checkfine fine)
        {
            MaSV_selected = fine.fSearch.Text.ToLower().Trim();
            fine.SumDebt.Clear();
            fine.Result.Clear();
            FineList = new ObservableCollection<PHIEUPHAT>(DataProvider.Ins.DB.PHIEUPHATs);
            int dem = 0;
            foreach (PHIEUPHAT i in FineList)
            {
                string b = i.MASV.ToLower().Trim();
                if (b == MaSV_selected)
                {
                    fine.SumDebt.Text = i.SOTIENTHU.ToString();
                    dem += 1;
                    break;
                }
            }
            if (dem == 0)
            {
                MessageBox.Show("Không tồn tại mã số sinh viên này");
            }
        }
        public void Pay(Checkfine fine)
        {
            int a = Int32.Parse(fine.MoneyRc.Text);
            int b = Int32.Parse(fine.SumDebt.Text);
            int kq = b - a;
            fine.Result.Text = kq.ToString();

            var phieu = DataProvider.Ins.DB.PHIEUPHATs.Where(x => x.MASV == MaSV_selected).SingleOrDefault();
            phieu.SOTIENTHU = kq;
            DataProvider.Ins.DB.SaveChanges();
            FineList.Clear();
            FineList = new ObservableCollection<PHIEUPHAT>(DataProvider.Ins.DB.PHIEUPHATs);
            MaSV_selected = "";
        }
    }
}
