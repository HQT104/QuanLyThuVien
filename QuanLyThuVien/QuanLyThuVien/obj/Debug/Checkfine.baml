   M S B A M L   `   `   `  ����H  DQuanLyThuVien, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:QuanLyThuVienQuanLyThuVien  5   	   G(clr-namespace:QuanLyThuVien.UserControlsQuanLyThuVien.UserControls  5   	   A%clr-namespace:QuanLyThuVien.ViewModelQuanLyThuVien.ViewModel  5   	       QuanLyThuVien.Checkfine   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   'localclr-namespace:QuanLyThuVien  5   	   1uc(clr-namespace:QuanLyThuVien.UserControls  5   	   _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   5	viewmodel%clr-namespace:QuanLyThuVien.ViewModel  5   	   -   5          �Name$  FineWD��5   	    � WindowStartupLocation$ CenterScreen=�5
   	    
  FineVM � DataContext# [  5   	     MaterialDesignBody#���  5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$ Quản lý Thư Viện��5   	   $	��520��6"   $	��450��6/   .��5      �  � RowDefinitions 5   
   �� 5      $��90 �6   6*   �� 5      $��65 �6   6*   �� 5      $��65 �6   6*   �� 5      $��65 �6   6*   �� 5      $��65 �6   6*   �� 5      $��65 �6   6*   �� 5       $��60 �6   6*   .+�5"   
   �� $��0��6   $
��Bold"�6!   $��35(�63   $��Center=�6A   $��center=�6\   Kiểm tra tiền phạt6�   � 5#   
   $��1��6    � ColumnDefinitions 5$      �� 5%      $	��120 �6#   61   �� 5&      6%   .+�5(      �� $��18(�6   $
��Bold"�6&   $��center=�68   $��center=�6S   	Mã SV:6x   �� 5)      $��1��6   $��0 5 0 5q�6%   $��Center=�66   
������� �� CornerRadius$ 25��6f   $��40��6x   $	��200��6�   
���   �$��2q�6�   ._�5*      �� -   5        	 ��Name$	 fSearch��5*      
������ $��35��6D   $	��160��6P   $��0q�6\   $��20 0 0 0q�5+      $��Center=�6(   $
��Left=�6J   $��14(�6e   .��6t   5,      5-      5.      �� 5/   
   $��2��6   $	��130��6   $��
Kiểm tra��50   !   
�������$��18(�6G   
���  ��$
��Bold"�6f   ��5/   *   �� *Check+��6D   �� 
 �� ElementName$
 FineWD��51      � 52   
   $��3��6    53      �� 54      $	��120 �6#   61   �� 55      6%   .+�57      �� $��18(�6   $
��Bold"�6&   $��center=�68   $��center=�6S   Tổng nợ:6z   �� 58      $��1��6   $��0 5 0 5q�6%   $��Center=�66   
�������$ 25��6f   $��40��6x   $	��200��6�   
���   �$��2q�6�   ._�59      �� -   5        $	 SumDebt��59      
������ $��35��6D   $	��160��6P   $��0q�6\   $��20 0 0 0q�5:      $��Center=�6(   $
��Left=�6J   $��14(�6e   .��6t   5;      5<      5=      � 5>   
   $��4��6    5?      �� 5@      $	��120 �6#   61   �� 5A      6%   .+�5C      �� $��18(�6   $
��Bold"�6&   $��center=�68   $��center=�6S   Số tiền thu:6~   �� 5D      $��1��6   $��0 5 0 5q�6%   $��Center=�66   
�������$ 25��6f   $��40��6x   $	��200��6�   
���   �$��2q�6�   ._�5E      �� -   5        $	 MoneyRc��5E      
������ $��35��6D   $	��160��6P   $��0q�6\   $��20 0 0 0q�5F      $��Center=�6(   $
��Left=�6J   $��14(�6e   .��6t   5G      5H      5I      � 5J   
   $��5��6    5K      �� 5L      $	��120 �6#   61   �� 5M      6%   .+�5O      �� $��18(�6   $
��Bold"�6&   $��center=�68   $��center=�6S   Còn lại:6z   �� 5P      $��1��6   $��0 5 0 5q�6%   $��Center=�66   
�������$ 25��6f   $��40��6x   $	��200��6�   
���   �$��2q�6�   ._�5Q      �� -   5        $	 Result��5Q      
������ $��35��6C   $	��160��6O   $��0q�6[   $��20 0 0 0q�5R      $��Center=�6(   $
��Left=�6J   $��14(�6e   .��6t   5S      5T      5U      � 5V   
   $��6��6    5W      �� 5X      6%   �� 5Y      6%   .+�5[      �� $��0��6   $	��130��6%   $��Thanh toán��5\   !   
�������$��18(�6I   
���  ��$
��Bold"�6h   ��5[   1   �� *	Payment+��6M   �� $
 FineWD��5]      �� 5^      $��1��6   $	��130��6%   $��Thoát��5_   !   
�������$��18(�6D   
���  ��$
��Bold"�6c   ��5^   1   �� *Back+��6J   �� $
 FineWD��5`      5a      5b      5d      