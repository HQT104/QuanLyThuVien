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


namespace QuanLyThuVien.ViewModel
{
    internal class CardManagementViewModel : BaseViewModel
    {
        public ICommand BackHome { get; set; }
        public ICommand OpenAddCard { get; set; }
        public ICommand ExitCard { get; set; }
        public ICommand AddCard { get; set; }



        public bool isFistVisible = false;

        public CardManagementViewModel()
        {
            BackHome = new RelayCommand<CardManagementWindow>((p) => { return true; }, (p) => { p.Close(); });
            OpenAddCard = new RelayCommand<CardManagementWindow>((p) => { return true; }, (p) => { OpenAddCardWD(p); });
            ExitCard = new RelayCommand<AddCardWindow>((p) => { return true; }, (p) => { p.Close(); });
            AddCard = new RelayCommand<AddCardWindow>((p) => { return true; }, (p) => { p.Close(); });
         

        }


        public void OpenAddCardWD(CardManagementWindow cardManagementWindow)
        {
            AddCardWindow addCardWindow = new AddCardWindow();
            addCardWindow.ShowDialog();

        }
    }
}
