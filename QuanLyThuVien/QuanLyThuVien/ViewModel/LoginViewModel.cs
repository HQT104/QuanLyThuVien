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
    class LoginViewModel : BaseViewModel
    {

        private ObservableCollection<TAIKHOAN> _Account;
        public ObservableCollection<TAIKHOAN> Account { get => _Account; set { _Account = value; OnPropertyChanged(); } }
        public ICommand LoginCommand { get; set; }
        public ICommand ForgotPasswordCommand { get; set; }
        public ICommand EditAccount { get; set; }
        public ICommand ExitForgotPassWord { get; set; }
        public ICommand PasswordChangedCommand { get; set; }

        private string _Username = "";
        public string Username { get => _Username; set { _Username = value; OnPropertyChanged(); } }
        private string _Password = "";
        public string Password { get => _Password; set { _Password = value; OnPropertyChanged(); } }
        public LoginViewModel()
        {
            LoginCommand = new RelayCommand<LoginWindow>((p) => { return true; }, (p) => { Login(p); });
            ForgotPasswordCommand = new RelayCommand<LoginWindow>((p) => { return true; }, (p) => { ForgetPasswordWD(p); });
            EditAccount = new RelayCommand<ForgotPassword>((p) => { return true; }, (p) => { EditAccountWD(p); });
            ExitForgotPassWord = new RelayCommand<ForgotPassword>((p) => { return true; }, (p) => { BackLoginWD(p); });
            PasswordChangedCommand = new RelayCommand<PasswordBox>((p) => { return true; }, (p) => { Password = p.Password; });
        }

        public void Login(LoginWindow loginWindow)
        {
            if (Username.Length == 0 || Password.Length == 0)
            {
                if (Username.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập tài khoản.");
                }
                else if (Password.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu.");
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu.");
                }
            }
            else
            {
                var accCount = DataProvider.Ins.DB.TAIKHOANs.Where(x => x.TENTK == Username && x.MK == Password).ToList();
                if (accCount.Count > 0)
                {
                    MainWindow mainWindow = new MainWindow();
                    loginWindow.Hide();
                    mainWindow.ShowDialog();
                    loginWindow.Username.Text = "";
                    loginWindow.PasswordBox.Password = "";
                    loginWindow.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng.");
                }
            }
        }
        public void BackLoginWD(ForgotPassword forgotPassword)
        {
            LoginWindow login = new LoginWindow();
            forgotPassword.Hide();
            login.ShowDialog();
        }
        public void ForgetPasswordWD(LoginWindow loginWindow)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            loginWindow.Hide();
            forgotPassword.ShowDialog();
        }
        public void EditAccountWD(ForgotPassword forgotPassword)
        {
            TAIKHOAN TK = new TAIKHOAN();

            Account = new ObservableCollection<TAIKHOAN>(DataProvider.Ins.DB.TAIKHOANs);
            TK = Account[0];
            if (TK.TENTK != forgotPassword.nameAccount.Text)
            {
                MessageBox.Show("Tên tài khoản sai, vui lòng nhập lại");
                return;
            }
            if ((TK.EMAIL != forgotPassword.confirmAccount.Text) && (TK.SDT.ToString() != forgotPassword.confirmAccount.Text))
            {
                MessageBox.Show("Xác nhận tài khoản sai vui lòng kiểm tra lại SĐT hoặc Email");
                return;
            }
            if (String.IsNullOrEmpty(forgotPassword.newPassword.Text) || String.IsNullOrEmpty(forgotPassword.confirmPassword.Text))
            {
                MessageBox.Show("Mật khẩu không được để trống");
                return;
            }
            if (forgotPassword.newPassword.Text != forgotPassword.confirmPassword.Text)
            {
                MessageBox.Show("Vui lòng kiểm tra lại mật khẩu");
                return;
            }
            TK.MK = forgotPassword.newPassword.Text;
            DataProvider.Ins.DB.SaveChanges();

            MessageBox.Show("Cập nhật thành công !!!");
            forgotPassword.Hide();
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.ShowDialog();
        }
    }
}
