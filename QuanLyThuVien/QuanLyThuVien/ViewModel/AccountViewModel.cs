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
    class AccountViewModel : BaseViewModel
    {
        private ObservableCollection<TAIKHOAN> _AccountList;
        public ObservableCollection<TAIKHOAN> AccountList { get => _AccountList; set { _AccountList = value; OnPropertyChanged(); } }
        public ICommand Save { get; set; }

        public AccountViewModel()
        {
            Save = new RelayCommand<AccountControl>((p) => { return true; }, (p) => { SaveAccount(p); });
        }

        public void SaveAccount(AccountControl account)
        {
            string name = account.acc.Text;
            string password = account.pass.Text;
            string repeatpassword = account.repeatpass.Text;
            AccountList = new ObservableCollection<TAIKHOAN>(DataProvider.Ins.DB.TAIKHOANs);
            int dem = 0;
            foreach (TAIKHOAN i in AccountList)
            {
                string b = i.TENTK;
                if (b == name)
                {
                    dem += 1;
                    break;
                }
            }
            var tk = DataProvider.Ins.DB.TAIKHOANs.Where(x => x.TENTK == name).SingleOrDefault();
            tk.MK = password;
            DataProvider.Ins.DB.SaveChanges();
            account.acc.Clear();
            account.pass.Clear();
            account.repeatpass.Clear();
            AccountList.Clear();
            AccountList = new ObservableCollection<TAIKHOAN>(DataProvider.Ins.DB.TAIKHOANs);
            MessageBox.Show("Cập nhật thành công");
        }

    }

}