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
    class InformationBorrowViewModel : BaseViewModel
    {
        private ObservableCollection<PHIEUMUON> _BorrowList;
        public ObservableCollection<PHIEUMUON> BorrowList { get => _BorrowList; set { _BorrowList = value; OnPropertyChanged(); } }

        private ObservableCollection<CTPHIEUMUON> _DetailBorrowList;
        public ObservableCollection<CTPHIEUMUON> DetailBorrowList { get => _DetailBorrowList; set { _DetailBorrowList = value; OnPropertyChanged(); } }
        public ICommand Backib { get; set; }
        public ICommand Findmt { get; set; }
        public ICommand Loadib { get; set; }

        public string MSV_selected = "";
        public bool isFistVisible = false;
        private BackgroundWorker worker;
        public InformationBorrowViewModel()
        {
            Backib = new RelayCommand<InformationBorrowWindow>((p) => { return true; }, (p) => { p.Close(); });
            Findmt = new RelayCommand<InformationBorrowWindow>((p) => { return true; }, (p) => { Searchmt(p); });
            Loadib = new RelayCommand<InformationBorrowWindow>((p) =>
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
        public void AddBookToScreen(SACH s, PHIEUMUON pm, ItemsControl p)
        {
            BorrowDetailControl b = new BorrowDetailControl();
            b.bMS.Text = s.MASACH;
            b.bName.Text = s.TACGIA;
            b.bAuthor.Text = s.TENSACH;
            b.bBorrowDate.Text = pm.NGAYMUON.ToString("dd/M/yyyy");
            b.bTerm.Text = pm.NGAYTRA.ToString("dd/M/yyyy");
            p.Items.Add(b);
        }
        public void Searchmt(InformationBorrowWindow ib)
        {
            MSV_selected = ib.MSVSearch.Text.Trim();
            ib.MSV.Clear();
            ib.HT.Clear();
            BorrowList = new ObservableCollection<PHIEUMUON>(DataProvider.Ins.DB.PHIEUMUONs);
            int dem = 0;
            foreach (PHIEUMUON i in BorrowList)
            {
                string b = i.MASV.Trim();
                if (b == MSV_selected)
                {
                    ib.MSV.Text = MSV_selected.ToString();
                    var thetv = DataProvider.Ins.DB.THETVs.Where(x => x.MASV == i.MASV).SingleOrDefault();
                    ib.HT.Text = thetv.HOTENSV;
                    DetailBorrowList = new ObservableCollection<CTPHIEUMUON>(DataProvider.Ins.DB.CTPHIEUMUONs);
                    foreach (CTPHIEUMUON ctpm in DetailBorrowList)
                    {
                        if (i.MAPHIEUMUON == ctpm.MAPHIEUMUON)
                        {
                            var book = DataProvider.Ins.DB.SACHes.Where(x => x.MASACH == ctpm.MASACH).SingleOrDefault();
                            AddBookToScreen(book, i, ib.IbList);
                        }
                    }
                    dem += 1;
                    break;
                }
            }
            if (dem == 0)
            {
                MessageBox.Show("Không tồn tại mã sinh viên này");
            }
        }
        public void Load(InformationBorrowWindow p)
        {
            worker = new BackgroundWorker();
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            worker.RunWorkerAsync(p);
        }
        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            InformationBorrowWindow p = (InformationBorrowWindow)e.Result;
            p.progressBar.Visibility = Visibility.Hidden;
            p.IbList.Visibility = Visibility.Visible;
        }
        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            InformationBorrowWindow p = (InformationBorrowWindow)e.Argument;
            System.Windows.Threading.Dispatcher settingDispatcher = p.Dispatcher;
            DetailBorrowList = new ObservableCollection<CTPHIEUMUON>(DataProvider.Ins.DB.CTPHIEUMUONs);
            foreach (CTPHIEUMUON i in DetailBorrowList)
            {
                UpdateUi update = new UpdateUi(AddBookToScreen);
                settingDispatcher.BeginInvoke(update, i, p.IbList);
            }
            e.Result = p;
        }
        public delegate void UpdateUi(SACH s, PHIEUMUON pm, ItemsControl p);
    }
}
