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

    class BookManagementViewModel : BaseViewModel
    {

        private ObservableCollection<SACH> _BookList;
        public ObservableCollection<SACH> BookList { get => _BookList; set { _BookList = value; OnPropertyChanged(); } }
        public ICommand BackHome { get; set; }
        public ICommand OpenAddBook { get; set; }
        public ICommand ExitBook { get; set; }
        public ICommand AddBook { get; set; }
        public ICommand LoadCommand { get; set; }
        public ICommand EditBookCommand { get; set; }
        public ICommand ExitBookCommand { get; set; }
        public ICommand DeleteBookCommand { get; set; }
        public ICommand SelectionChanged { get; set; }
        public ICommand SubmitAddBook { get; set; }
        public ICommand SearchCommand { get; set; }

        public ICommand OpenEditBook { get; set; }

        private BackgroundWorker worker;

        public bool isFistVisible = false;
        public string id_selected = "";
        public bool isUpdateBookSuccess = false;
        public bool isAddBookSuccess = false;
        public BookManagementViewModel()
        {
            BackHome = new RelayCommand<BookManagementWindow>((p) => { return true; }, (p) => { p.Close(); });
            OpenAddBook = new RelayCommand<ItemsControl>((p) => { return true; }, (p) => { OpenAddBookWD(p); });
            OpenEditBook = new RelayCommand<BookDetailControl>((p) => { return true; }, (p) => { OpenEditBookWD(p); });
            ExitBook = new RelayCommand<AddBookWindow>((p) => { return true; }, (p) => { p.Close(); });
            ExitBookCommand = new RelayCommand<DetailBookWindow>((p) => { return true; }, (p) => { p.Close(); });

            LoadCommand = new RelayCommand<BookManagementWindow>((p) =>
            {
                if (p.IsVisible == true && isFistVisible == false)
                {
                    isFistVisible = true;
                    return true;
                }
                else
                    return false;
            }, (p) => { Load(p); });
            EditBookCommand = new RelayCommand<DetailBookWindow>((p) => { return true; }, (p) => { EditBook(p); if (isUpdateBookSuccess) p.Close(); });
            DeleteBookCommand = new RelayCommand<BookDetailControl>((p) => { return true; }, (p) => { DeleteBook(p); });
            SubmitAddBook = new RelayCommand<AddBookWindow>((p) => { return true; }, (p) => { SubmitAdd(p); if (isAddBookSuccess) p.Close(); });
            SearchCommand = new RelayCommand<BookManagementWindow>((p) => { return true; }, (p) => { SearchBook(p); });

        }

        public void OpenEditBookWD(BookDetailControl bookDetail)
        {
            id_selected = bookDetail.txbID.Text;
            //MessageBox.Show(id_selected.ToString());
            int n = BookList.Count;
            SACH s = new SACH();
            for (int i = 0; i < n; i++)
            {
                if (BookList[i].MASACH == id_selected)
                {
                    s = BookList[i];
                    break;
                }
            }
            DetailBookWindow edit = new DetailBookWindow();
            edit.txbBookAuthor.Text = s.TACGIA;
            edit.txbBookCategory.Text = s.THELOAI;
            edit.txbBookID.Text = s.MASACH;
            edit.txbBookImportDate.Text = s.NGAYNHAP.ToString("M/dd/yyyy");
            edit.txbBookValue.Text = s.TRIGIA.ToString();
            edit.txbBookPulisher.Text = s.NHAXUATBAN;
            edit.txbBookPublishYear.Text = s.NAMXUATBAN.ToString();
            edit.txbBookNumber.Text = s.SOLUONG.ToString();
            edit.txbBookName.Text = s.TENSACH;

            edit.ShowDialog();

            // Update screen after updated book
            if (isUpdateBookSuccess)
            {
                bookDetail.txbID.Text = edit.txbBookID.Text;
                bookDetail.txbAuthor.Text = edit.txbBookAuthor.Text;
                bookDetail.txbCategory.Text = edit.txbBookCategory.Text;
                bookDetail.txbImportDate.Text = edit.txbBookImportDate.Text;
                bookDetail.txbValue.Text = edit.txbBookValue.Text;
                bookDetail.txbPublisher.Text = edit.txbBookPulisher.Text;
                bookDetail.txbPushlishYear.Text = edit.txbBookPublishYear.Text;
                bookDetail.txbNumberOfBook.Text = edit.txbBookNumber.Text;
                bookDetail.txbName.Text = edit.txbBookName.Text;
                isUpdateBookSuccess = false;
            }

        }
        public void OpenAddBookWD(ItemsControl p)
        {
            AddBookWindow addBookWindow = new AddBookWindow();
            addBookWindow.txbBookImportDate.Text = DateTime.Now.ToShortDateString();
            
            addBookWindow.ShowDialog();
            if (isAddBookSuccess)
            {
                int index = BookList.Count;
                SACH a = new SACH();
                a = BookList[index - 1];
                AddBookToScreen(a, p);
                isAddBookSuccess = false;
            }
        }

        public void AddBookToScreen(SACH s, ItemsControl p)
        {
            BookDetailControl b = new BookDetailControl();
            b.txbID.Text = s.MASACH;
            b.txbAuthor.Text = s.TACGIA;
            b.txbCategory.Text = s.THELOAI;
            b.txbName.Text = s.TENSACH;
            b.txbImportDate.Text = s.NGAYNHAP.ToString("M/dd/yyyy");
            b.txbValue.Text = s.TRIGIA.ToString();
            b.txbPublisher.Text = s.NHAXUATBAN;
            b.txbPushlishYear.Text = s.NAMXUATBAN.ToString();
            b.txbNumberOfBook.Text = s.SOLUONG.ToString();
            p.Items.Add(b);
        }

        public void Load(BookManagementWindow p)
        {
            worker = new BackgroundWorker();
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            worker.RunWorkerAsync(p);
        }
        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BookManagementWindow p = (BookManagementWindow)e.Result;
            p.progressBar.Visibility = Visibility.Hidden;
            p.bookList.Visibility = Visibility.Visible;
        }
        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            BookManagementWindow p = (BookManagementWindow)e.Argument;
            System.Windows.Threading.Dispatcher settingDispatcher = p.Dispatcher;
            BookList = new ObservableCollection<SACH>(DataProvider.Ins.DB.SACHes);
            foreach (SACH i in BookList)
            {
                UpdateUi update = new UpdateUi(AddBookToScreen);
                settingDispatcher.BeginInvoke(update, i, p.bookList);
            }
            e.Result = p;

        }
        public delegate void UpdateUi(SACH a, ItemsControl p);
        public bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }
        public void EditBook(DetailBookWindow edit)
        {
            if (!IsBookValid(edit)) return;
            var book = DataProvider.Ins.DB.SACHes.Where(x => x.MASACH == id_selected).SingleOrDefault();

            book.MASACH = edit.txbBookID.Text;
            book.TENSACH = edit.txbBookName.Text;
            book.THELOAI = edit.txbBookCategory.Text;
            string s = edit.txbBookImportDate.Text;
            book.NAMXUATBAN = int.Parse(edit.txbBookPublishYear.Text);
            book.NHAXUATBAN = edit.txbBookPulisher.Text;
            book.TRIGIA = int.Parse(edit.txbBookValue.Text);
            book.SOLUONG = int.Parse(edit.txbBookNumber.Text);
            book.TACGIA = edit.txbBookAuthor.Text;

            id_selected = "";
            isUpdateBookSuccess = true;
            DataProvider.Ins.DB.SaveChanges();
            BookList.Clear();
            BookList = new ObservableCollection<SACH>(DataProvider.Ins.DB.SACHes);
            MessageBox.Show("Cập nhật thành công");
        }

        public void DeleteBook(BookDetailControl bookDetail)
        {
            string s = "Bạn muốn xóa sách có mã sách " + bookDetail.txbID.Text + " không?";
            MessageBoxResult result = MessageBox.Show(s, "Thông báo", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                string id = bookDetail.txbID.Text;
                foreach (SACH book in BookList)
                {
                    if (book.MASACH == id)
                    {
                        DataProvider.Ins.DB.SACHes.Remove(book);
                        DataProvider.Ins.DB.SaveChanges();
                        BookList.Clear();
                        BookList = new ObservableCollection<SACH>(DataProvider.Ins.DB.SACHes);

                        ItemsControl p = (ItemsControl)bookDetail.Parent;
                        p.Items.Remove(bookDetail);
                        break;
                    }
                }
                MessageBox.Show("Bạn đã xóa sách thành công");
            }

        }
        public void SubmitAdd(AddBookWindow add)
        {
            if (!IsBookValid(add)) return;
            var a = DataProvider.Ins.DB.SACHes.ToList().LastOrDefault();
            var Book = new SACH()
            {
                MASACH = add.txbBookID.Text,
                TENSACH = add.txbBookName.Text,
                THELOAI = add.txbBookCategory.Text,
                NGAYNHAP = Convert.ToDateTime(add.txbBookImportDate.Text),
                NAMXUATBAN = int.Parse(add.txbBookPublishYear.Text),
                SOLUONG = int.Parse(add.txbBookNumber.Text),
                TACGIA = add.txbBookAuthor.Text,
                NHAXUATBAN = add.txbBookPulisher.Text,
                TRIGIA = int.Parse(add.txbBookValue.Text)
            };
            DataProvider.Ins.DB.SACHes.Add(Book);
            DataProvider.Ins.DB.SaveChanges();
            BookList.Clear();
            BookList = new ObservableCollection<SACH>(DataProvider.Ins.DB.SACHes);

            isAddBookSuccess = true;
            MessageBox.Show("Thêm sách thành công!!!");
        }

        // Search thẻ theo họ tên
        public void SearchBook(BookManagementWindow book)
        {
            string a = book.txbSearch.Text.ToLower();
            book.bookList.Items.Clear();
            foreach (SACH i in BookList)
            {
                string b = i.TENSACH.ToLower();
                if (b.Contains(a))
                {
                    AddBookToScreen(i, book.bookList);
                }
            }
        }
        public bool IsBookValid(AddBookWindow book)
        {
            // Kiểm tra trường hợp nhập thiếu
            if (String.IsNullOrEmpty(book.txbBookValue.Text) || String.IsNullOrEmpty(book.txbBookPulisher.Text) || String.IsNullOrEmpty(book.txbBookPublishYear.Text)
                || String.IsNullOrEmpty(book.txbBookNumber.Text) || String.IsNullOrEmpty(book.txbBookName.Text) || String.IsNullOrEmpty(book.txbBookImportDate.Text)
                || String.IsNullOrEmpty(book.txbBookID.Text) || String.IsNullOrEmpty(book.txbBookCategory.Text) || String.IsNullOrEmpty(book.txbBookAuthor.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin đầy đủ");
                return false;
            }

            if (!IsDigitsOnly(book.txbBookNumber.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng sách là số nguyên");
                return false;
            }
            if (!IsDigitsOnly(book.txbBookPublishYear.Text))
            {
                MessageBox.Show("Vui lòng nhập năm xuất bản là số nguyên");
                return false;
            }
            if (!IsDigitsOnly(book.txbBookValue.Text))
            {
                MessageBox.Show("Vui lòng nhập giá trị sách là số nguyên");
                return false;
            }
            int n = BookList.Count;
            SACH s = new SACH();
            for (int i = 0; i < n; i++)
            {
                if (BookList[i].MASACH == book.txbBookID.Text)
                {
                    MessageBox.Show("Mã sách đã tồn tại");
                    return false;
                }
            }
            return true;

        }

        // Kiểm tra cho trường hợp edit
        public bool IsBookValid(DetailBookWindow book)
        {
            // Kiểm tra trường hợp nhập thiếu
            if (String.IsNullOrEmpty(book.txbBookValue.Text) || String.IsNullOrEmpty(book.txbBookPulisher.Text) || String.IsNullOrEmpty(book.txbBookPublishYear.Text)
                || String.IsNullOrEmpty(book.txbBookNumber.Text) || String.IsNullOrEmpty(book.txbBookName.Text) || String.IsNullOrEmpty(book.txbBookImportDate.Text)
                || String.IsNullOrEmpty(book.txbBookID.Text) || String.IsNullOrEmpty(book.txbBookCategory.Text) || String.IsNullOrEmpty(book.txbBookAuthor.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin đầy đủ");
                return false;
            }

            if (!IsDigitsOnly(book.txbBookNumber.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng sách là số nguyên");
                return false;
            }
            if (!IsDigitsOnly(book.txbBookPublishYear.Text))
            {
                MessageBox.Show("Vui lòng nhập năm xuất bản là số nguyên");
                return false;
            }
            if (!IsDigitsOnly(book.txbBookValue.Text))
            {
                MessageBox.Show("Vui lòng nhập giá trị sách là số nguyên");
                return false;
            }
            int n = BookList.Count;
            SACH s = new SACH();
            for (int i = 0; i < n; i++)
            {
                if (BookList[i].MASACH == book.txbBookID.Text)
                {
                    MessageBox.Show("Mã sách đã tồn tại");
                    return false;
                }
            }
            return true;
        }

    }
}
