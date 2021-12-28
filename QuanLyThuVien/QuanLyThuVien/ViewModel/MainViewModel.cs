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
    class MainViewModel : BaseViewModel
    {
        public ICommand SwitchTabCommand { get; set; }
        public ICommand GetUidCommand { get; set; }
        private string uid;

        public MainViewModel()
        {
            SwitchTabCommand = new RelayCommand<MainWindow>((p) => { return true; }, (p) => { SwitchTab(p); });
            GetUidCommand = new RelayCommand<Button>((p) => { return true; }, (p) => { uid = p.Uid; });

        }

        public void SwitchTab(MainWindow mainWindow)
        {
            int index = int.Parse(uid);

            mainWindow.Home.Visibility = System.Windows.Visibility.Hidden;
            mainWindow.Account.Visibility = System.Windows.Visibility.Hidden;
            mainWindow.Regulation.Visibility = System.Windows.Visibility.Hidden;

            mainWindow.bdHome.Background = (Brush)new BrushConverter().ConvertFrom("#FF4699DA");
            mainWindow.bdRegulation.Background = (Brush)new BrushConverter().ConvertFrom("#FF4699DA");
            mainWindow.bdAccount.Background = (Brush)new BrushConverter().ConvertFrom("#FF4699DA");

            mainWindow.icHome.Foreground = (Brush)new BrushConverter().ConvertFrom("#000000");
            mainWindow.icRegulation.Foreground = (Brush)new BrushConverter().ConvertFrom("#000000");
            mainWindow.icAccount.Foreground = (Brush)new BrushConverter().ConvertFrom("#000000");

            mainWindow.txtHome.Foreground = (Brush)new BrushConverter().ConvertFrom("#000000");
            mainWindow.txtRegulation.Foreground = (Brush)new BrushConverter().ConvertFrom("#000000");
            mainWindow.txtAccount.Foreground = (Brush)new BrushConverter().ConvertFrom("#000000");



            switch (index)
            {
                case 1:
                    mainWindow.Home.Visibility = System.Windows.Visibility.Visible;

                    mainWindow.bdHome.Background = (Brush)new BrushConverter().ConvertFrom("#ffffff");
                    mainWindow.icHome.Foreground = (Brush)new BrushConverter().ConvertFrom("#000000");
                    mainWindow.txtHome.Foreground = (Brush)new BrushConverter().ConvertFrom("#000000");
                    break;
                case 2:
                    mainWindow.Account.Visibility = System.Windows.Visibility.Visible;
                    TAIKHOAN TK = new TAIKHOAN();
                    var account = new ObservableCollection<TAIKHOAN>(DataProvider.Ins.DB.TAIKHOANs);
                    TK = account[0];
                    mainWindow.Account.acc.Text = TK.TENTK.ToString();
                    mainWindow.Account.pass.Text = TK.MK.ToString();
                    mainWindow.bdAccount.Background = (Brush)new BrushConverter().ConvertFrom("#ffffff");
                    mainWindow.icAccount.Foreground = (Brush)new BrushConverter().ConvertFrom("#000000");
                    mainWindow.txtAccount.Foreground = (Brush)new BrushConverter().ConvertFrom("#000000");
                    break;
                case 3:
                    mainWindow.Regulation.Visibility = System.Windows.Visibility.Visible;
                    THAMSO TS = new THAMSO();
                    var regulations = new ObservableCollection<THAMSO>(DataProvider.Ins.DB.THAMSOes);
                    TS = regulations[0];
                    mainWindow.Regulation.txbSLSACHMUON.Text = TS.SLSACHMUON.ToString();
                    mainWindow.Regulation.txbSONAMXUATBAN.Text = TS.SONAMXUATBAN.ToString();
                    mainWindow.Regulation.txbSOTIENPHAT.Text = TS.SOTIENPHAT.ToString();
                    mainWindow.Regulation.txbTHOIGIANMUON.Text = TS.THOIGIANMUON.ToString();
                    mainWindow.bdRegulation.Background = (Brush)new BrushConverter().ConvertFrom("#ffffff");
                    mainWindow.icRegulation.Foreground = (Brush)new BrushConverter().ConvertFrom("#000000");
                    mainWindow.txtRegulation.Foreground = (Brush)new BrushConverter().ConvertFrom("#000000");
                    break;
            }
        }
    }
}
