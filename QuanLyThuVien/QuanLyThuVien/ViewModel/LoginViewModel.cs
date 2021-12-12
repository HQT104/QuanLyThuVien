using QuanLyThuVien.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace QuanLyThuVien.ViewModel
{
    class LoginViewModel : BaseViewModel
    {
        public ICommand LoginCommand { get; set; }


        public LoginViewModel()
        {
            LoginCommand = new RelayCommand<LoginWindow>((p) => { return true; }, (p) => { Login(p); });

        }

        public void Login(LoginWindow loginWindow)
        {
            MainWindow mainWindow = new MainWindow();
            loginWindow.Hide();
            mainWindow.ShowDialog();

        }
    }
}
