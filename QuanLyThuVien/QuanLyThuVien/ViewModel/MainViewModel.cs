using QuanLyThuVien.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

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
            mainWindow.Report.Visibility = System.Windows.Visibility.Hidden;
            if (mainWindow.btnReport.IsEnabled == false)
            {
                mainWindow.bdHome.Background = (Brush)new BrushConverter().ConvertFrom("#ffffff");

                mainWindow.icHome.Foreground = (Brush)new BrushConverter().ConvertFrom("#000000");

                mainWindow.txtHome.Foreground = (Brush)new BrushConverter().ConvertFrom("#000000");
            }
            else
            {
                mainWindow.bdHome.Background = (Brush)new BrushConverter().ConvertFrom("#ffffff");
                mainWindow.bdReport.Background = (Brush)new BrushConverter().ConvertFrom("#ffffff");
                mainWindow.bdRegulation.Background = (Brush)new BrushConverter().ConvertFrom("#ffffff");
                mainWindow.bdAccount.Background = (Brush)new BrushConverter().ConvertFrom("#ffffff");

                mainWindow.icHome.Foreground = (Brush)new BrushConverter().ConvertFrom("#000000");
                mainWindow.icReport.Foreground = (Brush)new BrushConverter().ConvertFrom("#000000");
                mainWindow.icRegulation.Foreground = (Brush)new BrushConverter().ConvertFrom("#000000");
                mainWindow.icAccount.Foreground = (Brush)new BrushConverter().ConvertFrom("#000000");

                mainWindow.txtHome.Foreground = (Brush)new BrushConverter().ConvertFrom("#000000");
                mainWindow.txtReport.Foreground = (Brush)new BrushConverter().ConvertFrom("#000000");
                mainWindow.txtRegulation.Foreground = (Brush)new BrushConverter().ConvertFrom("#000000");
                mainWindow.txtAccount.Foreground = (Brush)new BrushConverter().ConvertFrom("#000000");
            }


            switch (index)
            {
                case 1:
                    mainWindow.Home.Visibility = System.Windows.Visibility.Visible;
                    mainWindow.bdHome.Background = (Brush)new BrushConverter().ConvertFrom("#FF4699DA");
                    mainWindow.icHome.Foreground = (Brush)new BrushConverter().ConvertFrom("#ffffff");
                    mainWindow.txtHome.Foreground = (Brush)new BrushConverter().ConvertFrom("#ffffff");
                    break;
                case 2:
                    mainWindow.Report.Visibility = System.Windows.Visibility.Visible;
                    mainWindow.bdReport.Background = (Brush)new BrushConverter().ConvertFrom("#FF4699DA");
                    mainWindow.icReport.Foreground = (Brush)new BrushConverter().ConvertFrom("#ffffff");
                    mainWindow.txtReport.Foreground = (Brush)new BrushConverter().ConvertFrom("#ffffff");
                    break;
                case 3:
                    mainWindow.Account.Visibility = System.Windows.Visibility.Visible;
                    mainWindow.bdAccount.Background = (Brush)new BrushConverter().ConvertFrom("#FF4699DA");
                    mainWindow.icAccount.Foreground = (Brush)new BrushConverter().ConvertFrom("#ffffff");
                    mainWindow.txtAccount.Foreground = (Brush)new BrushConverter().ConvertFrom("#ffffff");
                    break;
                case 4:
                    mainWindow.Regulation.Visibility = System.Windows.Visibility.Visible;
                    mainWindow.bdRegulation.Background = (Brush)new BrushConverter().ConvertFrom("#FF4699DA");
                    mainWindow.icRegulation.Foreground = (Brush)new BrushConverter().ConvertFrom("#ffffff");
                    mainWindow.txtRegulation.Foreground = (Brush)new BrushConverter().ConvertFrom("#ffffff");
                    break;               
            }
        }
    }
}
