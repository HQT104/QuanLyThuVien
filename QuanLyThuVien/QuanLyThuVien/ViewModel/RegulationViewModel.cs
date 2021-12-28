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
    class RegulationViewModel : BaseViewModel
    {
        private ObservableCollection<THAMSO> _Regulations;
        public ObservableCollection<THAMSO> Regulations { get => _Regulations; set { _Regulations = value; OnPropertyChanged(); } }
        public ICommand ConfirmRegulation { get; set; }
        public RegulationViewModel()
        {
            ConfirmRegulation = new RelayCommand<RegulationControl>((p) => { return true; }, (p) => { EditRegulation(p); });

        }
        public void EditRegulation(RegulationControl edit)
        {
            if (!IsRegulationValid(edit)) return;
            THAMSO TS = new THAMSO();
            var regulations = new ObservableCollection<THAMSO>(DataProvider.Ins.DB.THAMSOes);
            TS = regulations[0];

            TS.THOIGIANMUON = int.Parse(edit.txbTHOIGIANMUON.Text);
            TS.SOTIENPHAT = int.Parse(edit.txbSOTIENPHAT.Text);
            TS.SONAMXUATBAN = int.Parse(edit.txbSONAMXUATBAN.Text);
            TS.SLSACHMUON = int.Parse(edit.txbSLSACHMUON.Text);


            // DataProvider.Ins.DB.SaveChanges();
            MessageBox.Show("Cập nhật thành công");
        }
        public bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }
        public bool IsRegulationValid(RegulationControl regulation)
        {
            if (String.IsNullOrEmpty(regulation.txbTHOIGIANMUON.Text) || String.IsNullOrEmpty(regulation.txbSOTIENPHAT.Text) || String.IsNullOrEmpty(regulation.txbSONAMXUATBAN.Text) || String.IsNullOrEmpty(regulation.txbSLSACHMUON.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return false;
            }
            if (!IsDigitsOnly(regulation.txbSLSACHMUON.Text))
            {
                MessageBox.Show("Số lượng sách là số nguyên");
                return false;
            }
            if (!IsDigitsOnly(regulation.txbSONAMXUATBAN.Text))
            {
                MessageBox.Show("Số năm xuất bản là số nguyên");
                return false;
            }
            if (!IsDigitsOnly(regulation.txbSOTIENPHAT.Text))
            {
                MessageBox.Show("Số tiền phạt là số nguyên");
                return false;
            }
            if (!IsDigitsOnly(regulation.txbTHOIGIANMUON.Text))
            {
                MessageBox.Show("Thời gian mượn là số nguyên");
                return false;
            }
            return true;
        }
    }
}
