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

    class CardManagementViewModel : BaseViewModel
    {

        private ObservableCollection<THETV> _CardList;
        public ObservableCollection<THETV> CardList { get => _CardList; set { _CardList = value; OnPropertyChanged(); } }
        public ICommand BackHome { get; set; }
        public ICommand OpenAddCard { get; set; }
        public ICommand ExitCard { get; set; }
        public ICommand AddCard { get; set; }
        public ICommand LoadCommand { get; set; }
        public ICommand EditCardCommand { get; set; }
        public ICommand ExitCardCommand { get; set; }
        public ICommand DeleteCardCommand { get; set; }
        public ICommand SelectionChanged { get; set; }
        public ICommand SubmitAddCard { get; set; }
        public ICommand SearchCommand { get; set; }

        public ICommand OpenEditCard { get; set; }

        private BackgroundWorker worker;

        public bool isFistVisible = false;
        public string id_selected = "";
        public bool isUpdateCardSuccess = false;
        public bool isAddCardSuccess = false;
        public CardManagementViewModel()
        {
            BackHome = new RelayCommand<CardManagementWindow>((p) => { return true; }, (p) => { p.Close(); });
            OpenAddCard = new RelayCommand<ItemsControl>((p) => { return true; }, (p) => { OpenAddCardWD(p); });
            OpenEditCard = new RelayCommand<CardDetailControl>((p) => { return true; }, (p) => { OpenEditCardWD(p); });
            ExitCard = new RelayCommand<AddCardWindow>((p) => { return true; }, (p) => { p.Close(); });
            ExitCardCommand = new RelayCommand<DetailCardWindow>((p) => { return true; }, (p) => { p.Close(); });

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
            EditCardCommand = new RelayCommand<DetailCardWindow>((p) => { return true; }, (p) => { EditCard(p); if (isUpdateCardSuccess) p.Close(); });
            DeleteCardCommand = new RelayCommand<CardDetailControl>((p) => { return true; }, (p) => { DeleteCard(p); });
            SubmitAddCard = new RelayCommand<AddCardWindow>((p) => { return true; }, (p) => { SubmitAdd(p); if (isAddCardSuccess) p.Close(); });
            SearchCommand = new RelayCommand<CardManagementWindow>((p) => { return true; }, (p) => { SearchCard(p); });

        }

        public void OpenEditCardWD(CardDetailControl cardDetail)
        {
            id_selected = cardDetail.txbID.Text;
            //MessageBox.Show(id_selected.ToString());
            int n = CardList.Count;
            THETV s = new THETV();
            for (int i = 0; i < n; i++)
            {
                if (CardList[i].MASV == id_selected)
                {
                    s = CardList[i];
                    break;
                }
            }
            DetailCardWindow edit = new DetailCardWindow();
            edit.txbCardMaSV.Text = s.MASV;
            edit.txbCardName.Text = s.HOTENSV;
            edit.txbCardEmail.Text = s.EMAIL;
            edit.txbCardSDT.Text = s.SODT.ToString();
            edit.txbCardDate.Text = s.NGAYLAPTHE.ToString("dd/M/yyyy");
            edit.txbCardTotalDebt.Text = s.TONGNO.ToString();
            edit.ShowDialog();

            // Update screen after updated card
            if (isUpdateCardSuccess)
            {
                cardDetail.txbID.Text = edit.txbCardMaSV.Text;
                cardDetail.txbName.Text = edit.txbCardName.Text;
                cardDetail.txbEmail.Text = edit.txbCardEmail.Text;
                cardDetail.txbSDT.Text = edit.txbCardSDT.Text;
                cardDetail.txbDate.Text = edit.txbCardDate.Text;
                cardDetail.txbTotalDebt.Text = edit.txbCardTotalDebt.Text;
                isUpdateCardSuccess = false;
            }

        }
        public void OpenAddCardWD(ItemsControl p)
        {
            AddCardWindow addCardWindow = new AddCardWindow();
            addCardWindow.txbCardDate.Text = DateTime.Now.ToShortDateString();
            addCardWindow.ShowDialog();
            if (isAddCardSuccess)
            {
                int index = CardList.Count;
                THETV a = new THETV();
                a = CardList[index - 1];
                AddCardToScreen(a, p);
                isAddCardSuccess = false;
            }
        }

        public void AddCardToScreen(THETV a, ItemsControl p)
        {
            CardDetailControl b = new CardDetailControl();
            b.txbID.Text = a.MASV;
            b.txbName.Text = a.HOTENSV;
            b.txbEmail.Text = a.EMAIL;
            b.txbSDT.Text = a.SODT.ToString();
            b.txbDate.Text = a.NGAYLAPTHE.ToString("dd/M/yyyy");
            b.txbTotalDebt.Text = a.TONGNO.ToString();
            p.Items.Add(b);
        }

        public void Load(CardManagementWindow p)
        {
            worker = new BackgroundWorker();
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            worker.RunWorkerAsync(p);
        }
        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            CardManagementWindow p = (CardManagementWindow)e.Result;
            p.progressBar.Visibility = Visibility.Hidden;
            p.cardList.Visibility = Visibility.Visible;
        }
        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            CardManagementWindow p = (CardManagementWindow)e.Argument;
            System.Windows.Threading.Dispatcher settingDispatcher = p.Dispatcher;
            CardList = new ObservableCollection<THETV>(DataProvider.Ins.DB.THETVs);
            foreach (THETV i in CardList)
            {
                UpdateUi update = new UpdateUi(AddCardToScreen);
                settingDispatcher.BeginInvoke(update, i, p.cardList);
            }
            e.Result = p;

        }
        public delegate void UpdateUi(THETV a, ItemsControl p);
        public bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }
        public void EditCard(DetailCardWindow edit)
        {
            if (!IsCardValid(edit)) return;
            var card = DataProvider.Ins.DB.THETVs.Where(x => x.MASV == id_selected).SingleOrDefault();

            card.MASV = edit.txbCardMaSV.Text;
            card.HOTENSV = edit.txbCardName.Text;
            card.EMAIL = edit.txbCardEmail.Text;
            card.SODT = edit.txbCardSDT.Text;
            card.NGAYLAPTHE = Convert.ToDateTime(edit.txbCardDate.Text);
            card.TONGNO = int.Parse(edit.txbCardTotalDebt.Text);

            id_selected = "";
            isUpdateCardSuccess = true;
            DataProvider.Ins.DB.SaveChanges();
            CardList.Clear();
            CardList = new ObservableCollection<THETV>(DataProvider.Ins.DB.THETVs);
            MessageBox.Show("Cập nhật thành công");
        }
        public bool IsCardValid(AddCardWindow card)
        {
            if (String.IsNullOrEmpty(card.txbCardDate.Text) || String.IsNullOrEmpty(card.txbCardEmail.Text) || String.IsNullOrEmpty(card.txbCardMaSV.Text)
               || String.IsNullOrEmpty(card.txbCardName.Text) || String.IsNullOrEmpty(card.txbCardSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin đầy đủ");
                return false;
            }

            if (!IsDigitsOnly(card.txbCardSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại là số nguyên");
                return false;
            }
            return true;

        }

        // Kiểm tra cho trường hợp edit
        public bool IsCardValid(DetailCardWindow card)
        {
            if (String.IsNullOrEmpty(card.txbCardDate.Text) || String.IsNullOrEmpty(card.txbCardEmail.Text) || String.IsNullOrEmpty(card.txbCardMaSV.Text)
               || String.IsNullOrEmpty(card.txbCardName.Text) || String.IsNullOrEmpty(card.txbCardSDT.Text) || String.IsNullOrEmpty(card.txbCardTotalDebt.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin đầy đủ");
                return false;
            }

            if (!IsDigitsOnly(card.txbCardSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại là số nguyên");
                return false;
            }
            if (!IsDigitsOnly(card.txbCardTotalDebt.Text))
            {
                MessageBox.Show("Vui lòng nhập tổng nợ là số nguyên");
                return false;
            }
            return true;
        }
        public void DeleteCard(CardDetailControl cardDetail)
        {
            string s = "Bạn muốn xóa thẻ có mã số sinh viên " + cardDetail.txbID.Text + " không?";
            MessageBoxResult result = MessageBox.Show(s, "Thông báo", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                string id = cardDetail.txbID.Text;
                foreach (THETV card in CardList)
                {
                    if (card.MASV == id)
                    {
                        DataProvider.Ins.DB.THETVs.Remove(card);
                        DataProvider.Ins.DB.SaveChanges();
                        CardList.Clear();
                        CardList = new ObservableCollection<THETV>(DataProvider.Ins.DB.THETVs);

                        ItemsControl p = (ItemsControl)cardDetail.Parent;
                        p.Items.Remove(cardDetail);
                        break;
                    }
                }
                MessageBox.Show("Bạn đã xóa thẻ thành công");
            }

        }
        public void SubmitAdd(AddCardWindow add)
        {
            if (!IsCardValid(add)) return;
            var a = DataProvider.Ins.DB.THETVs.ToList().LastOrDefault();
            var card = new THETV()
            {
                MASV = add.txbCardMaSV.Text,
                HOTENSV = add.txbCardName.Text,
                EMAIL = add.txbCardEmail.Text,
                SODT = add.txbCardSDT.Text,
                NGAYLAPTHE = Convert.ToDateTime(add.txbCardDate.Text),
                TONGNO = 0,
            };
            DataProvider.Ins.DB.THETVs.Add(card);
            DataProvider.Ins.DB.SaveChanges();
            CardList.Clear();
            CardList = new ObservableCollection<THETV>(DataProvider.Ins.DB.THETVs);

            isAddCardSuccess = true;
            MessageBox.Show("Thêm thẻ thành công!!!");
        }

        // Search thẻ theo họ tên
        public void SearchCard(CardManagementWindow Card)
        {
            string a = Card.txbSearch.Text.ToLower();
            Card.cardList.Items.Clear();
            foreach (THETV i in CardList)
            {
                string b = i.HOTENSV.ToLower();
                if (b.Contains(a))
                {
                    AddCardToScreen(i, Card.cardList);
                }
            }
        }

    }
}
