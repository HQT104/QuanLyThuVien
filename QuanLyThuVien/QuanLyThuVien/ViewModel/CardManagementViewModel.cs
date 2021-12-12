using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using QuanLyThuVien.UserControls;
using System.Windows;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Media;
using System.Security.Cryptography;

namespace QuanLyThuVien.ViewModel
{
    class CardManagementViewModel : BaseViewModel
    {

    }
    //class CardManagementViewModel : BaseViewModel
    //{

    //    private ObservableCollection<THETV> _cardList;
    //    public ObservableCollection<THETV> cardList { get => _cardList; set { _cardList = value; OnPropertyChanged(); } }
    //    public ICommand BackHome { get; set; }
    //    public ICommand OpenAddCard { get; set; }
    //    public ICommand ExitCard { get; set; }
    //    public ICommand AddCard { get; set; }
    //    public ICommand LoadCommand { get; set; }
    //    public ICommand EditCardCommand { get; set; }
    //    public ICommand DeleteCardCommand { get; set; }
    //    public ICommand SelectionChanged { get; set; }
    //    public ICommand SubmitAddCard { get; set; }
    //    public ICommand SearchCommand { get; set; }

    //    private BackgroundWorker worker;

    //    public bool isFistVisible = false;
    //    public int id_selected = -1;
    //    public bool isUpdateCardSuccess = false;
    //    public bool isAddCardSuccess = false;
    //    public CardManagementViewModel()
    //    {
    //        BackHome = new RelayCommand<DetailCardWindow>((p) => { return true; }, (p) => { p.Close(); });
    //        OpenAddCard = new RelayCommand<DetailCardWindow>((p) => { return true; }, (p) => { OpenAddCardWD(p); });
    //        ExitCard = new RelayCommand<AddCardWindow>((p) => { return true; }, (p) => { p.Close(); });
    //        // AddCard = new RelayCommand<AddCardWindow>((p) => { return true; }, (p) => { AddCardWD(p); });
    //        LoadCommand = new RelayCommand<CardDetailControl>((p) =>
    //        {
    //            if (p.IsVisible == true && isFistVisible == false)
    //            {
    //                isFistVisible = true;
    //                return true;
    //            }
    //            else
    //                return false;
    //        }, (p) => { Load(p); });
    //        //EditCardCommand = new RelayCommand<DetailCardWindow>((p) => { return true; }, (p) => { EditCard(p); if (isUpdateCardSuccess) p.Close(); });
    //        //DeleteCardCommand = new RelayCommand<CardDetailControl>((p) => { return true; }, (p) => { DeleteCard(p); });
    //        //SubmitAddCard = new RelayCommand<AddCardWindow>((p) => { return true; }, (p) => { SubmitAdd(p); if (isAddCardSuccess) p.Close(); });
    //        SearchCommand = new RelayCommand<DetailCardWindow>((p) => { return true; }, (p) => { SearchCard(p); });

    //    }


    //    public void OpenAddCardWD(DetailCardWindow detailCardWindow)
    //    {
    //        AddCardWindow addCardWindow = new AddCardWindow();
    //        addCardWindow.ShowDialog();
    //    }
    //    public void OpenAddCardWD(ItemsControl p)
    //    {
    //        AddCardWindow addCardWindow = new AddCardWindow();
    //        addCardWindow.ShowDialog();
    //        if (isAddCardSuccess)
    //        {
    //            int index = cardList.Count;
    //            THETV a = new THETV();
    //            a = cardList[index - 1];
    //            AddCardToScreen(a, p);
    //            isAddCardSuccess = false;
    //        }
    //    }


    //    public void AddCardToScreen(THETV a, ItemsControl p)
    //    {
    //        CardDetailControl b = new CardDetailControl();
    //        b.txbID.Text = a.MASV.ToString();
    //        b.txbName.Text = a.HOTENSV;
    //        b.txbEmail.Text = a.EMAIL;
    //        b.txbSDT.Text = a.SODT.ToString();
    //        b.txbDate.Text = a.NGAYLAPTHE.ToString("dd/M/yyyy");
    //        b.txbTotalDebt.Text = a.TONGNO.ToString();
    //        p.Items.Add(b);
    //    }

    //    public void AddCardWD(AddCardWindow addCardWindow)
    //    {

    //    }
    //    public void OpenAddCardWD(ItemsControl p)
    //    {
    //        AddCardWindow addCardWindow = new AddCardWindow();
    //        addCardWindow.ShowDialog();
    //        if (isAddCardSuccess)
    //        {
    //            int index = cardList.Count;
    //            THETV a = new THETV();
    //            a = cardList[index - 1];
    //            AddCardToScreen(a, p);
    //            isAddCardSuccess = false;
    //        }
    //    }


    //    public void AddCardToScreen(THETV a, ItemsControl p)
    //    {
    //        CardDetailControl b = new CardDetailControl();
    //        b.txbID.Text = a.MASV.ToString();
    //        b.txbName.Text = a.HOTENSV;
    //        b.txbEmail.Text = a.EMAIL;
    //        b.txbSDT.Text = a.SODT.ToString();
    //        b.txbDate.Text = a.NGAYLAPTHE.ToString("dd/M/yyyy");
    //        b.txbTotalDebt.Text = a.TONGNO.ToString();
    //        p.Items.Add(b);
    //    }

    //    public void Load(DetailCardWindow p)
    //    {
    //        worker = new BackgroundWorker();
    //        worker.DoWork += Worker_DoWork;
    //        worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
    //        worker.RunWorkerAsync(p);
    //    }
    //    private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    //    {
    //        DetailCardWindow p = (DetailCardWindow)e.Result;
    //        p.progressBar.Visibility = Visibility.Hidden;
    //        p.cardList.Visibility = Visibility.Visible;
    //    }
    //    private void Worker_DoWork(object sender, DoWorkEventArgs e)
    //    {
    //        DetailCardWindow p = (DetailCardWindow)e.Argument;
    //        System.Windows.Threading.Dispatcher settingDispatcher = p.Dispatcher;
    //        cardList = new ObservableCollection<THETV>(DataProvider.Ins.DB.THETVs);

    //        foreach (THETV i in cardList)
    //        {
    //            UpdateUi update = new UpdateUi(AddCardToScreen);
    //            settingDispatcher.BeginInvoke(update, i, p.cardList);
    //        }
    //        e.Result = p;
    //    }
    //    public delegate void UpdateUi(THETV a, ItemsControl p);
    //    public void SearchCard(DetailCardWindow Card)
    //    {
    //        string a = Card.txbSearch.Text.ToLower();
    //        Card.cardList.Items.Clear();
    //        foreach (THETV i in cardList)
    //        {
    //            string b = i.HOTENSV.ToLower();
    //            if (b.Contains(a))
    //            {
    //                AddCardToScreen(i, Card.cardList);
    //            }
    //        }
    //    }
    //}
}
