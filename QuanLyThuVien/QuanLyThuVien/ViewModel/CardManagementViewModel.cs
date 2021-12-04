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

        public ICommand LoadCommand { get; set; }


        public bool isFistVisible = false;

        private BackgroundWorker worker;

        public CardManagementViewModel()
        {
            BackHome = new RelayCommand<CardManagementWindow>((p) => { return true; }, (p) => { p.Close(); });
            OpenAddCard = new RelayCommand<CardManagementWindow>((p) => { return true; }, (p) => { OpenAddCardWD(p); });
            ExitCard = new RelayCommand<AddBookWindow>((p) => { return true; }, (p) => { p.Close(); });
            AddCard = new RelayCommand<AddBookWindow>((p) => { return true; }, (p) => { p.Close(); });
            LoadCommand = new RelayCommand<CardManagementWindow>((p) =>
            {
                if (p.IsVisible == true && isFistVisible == false)
                {
                    isFistVisible = true;
                    return true;
                }
                else
                    return false;
            }, (p) => { Load(p); });

        }

        public void OpenAddCardWD(CardManagementWindow ca)
        {
            AddBookWindow addBookWindow = new AddBookWindow();
            addBookWindow.ShowDialog();

        }
        public void Load(CardManagementWindow b)
        {
            worker = new BackgroundWorker();
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            worker.RunWorkerAsync(b);
        }
        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            CardManagementWindow p = (CardManagementWindow)e.Result;
            p.progressBar.Visibility = Visibility.Hidden;
            p.cardList.Visibility = Visibility.Visible;
        }
        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
