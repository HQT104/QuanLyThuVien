   M S B A M L   `   `   `  ����H  DQuanLyThuVien, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:QuanLyThuVien.UserControlsQuanLyThuVien.UserControls  5      A%clr-namespace:QuanLyThuVien.ViewModelQuanLyThuVien.ViewModel  5
      /    )QuanLyThuVien.UserControls.AccountControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      4local(clr-namespace:QuanLyThuVien.UserControls  5      _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      5	viewmodel%clr-namespace:QuanLyThuVien.ViewModel  5
      -   5          >�Name$  	AccountWD��5         	AccountVM � DataContext# [  5        MaterialDesignBody#���  5      $��Regular"�5      $��14(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      $	��404��5      $	��608��6   .��5      � .+�5   
   � -   5         �Name$ Content��5       � RowDefinitions 5      �� 5      $��60 �6    6.   �� 5      $��60 �6    6.   �� 5      $	��220 �6    6/   �� 5      $��60 �6    6.   .+�5      �� $��0��6   $��0,15,0,0q�6"   ���#44bcd8 �� CornerRadius$ 30��6I   $
��auto��6[   
���   �$��1q�6}   $	��400��6�   ._�5      �� -   5         ��Name$ QL��5      $
��Bold"�6)   $��Center=�6;   $��Center=�6V   $��20(�6s   Quản lý thư viện6�   5       �� 5"      $��1��6   $
��Bold"�6%   $��Center=�67   $��Center=�6R   $��20(�6o   Tài khoản6�   �� 5$      $��2��6   ���#44bcd8$ 15��67   $
��auto��6I   
���   �$��1q�6k   $	��350��6   ._�5%      �  5&      �� 5'      $��80 �6(   66   �� 5(      $��50 �6(   66   �� 5)      $	��80* �6(   67   .+�5+      � $��0��6    � ColumnDefinitions 5,      �� 5-      $	��100 �6/   6=   �� 5.      $
��100* �6/   6>   .+�50      �� $��0��6$   $
��Bold"�64   $��Center=�6F   $��Right=�6a   $��14(�6}   Tài khoản6�   �� 51      $��1��6!   
�������$ 25��6D   $��30��6V   
���   �$��1q�6v   $��34,25,34.8,25q�6�   ._�52      �� -   5        	 ��Name$		 acc��52   &   $��21.2,0.2,-0.8,-1.4q�63   
������ $��30��6h   $	��158��6t   $��0q�6�   $��Center=�53   *   $
��Left=�6L   $��14(�6g   .��6v   54      55      56      � 57      $��1��6    58      �� 59      $	��100 �6/   6=   �� 5:      $
��100* �6/   6>   .+�5<      �� $��0��6$   $
��Bold"�64   $��Center=�6F   $��Right=�6a   $��14(�6}   Mật khẩu6�   �� 5=      $��1��6!   
�������$ 25��6D   $��30��6V   $	��180��6b   
���   �$��1q�6�   ._�5>      �� -   5        $
	 pass��5>   &   
������ $��30��6N   $	��155��6Z   $��0q�6f   $��Center=�5?   *   $
��Left=�6L   $��14(�6g   $��24.2,0.2,-0.8,-1.4q�6u   .��6�   5@      5A      5B      � 5C      $��2��6    5D      �� 5E      $	��100 �6/   6=   �� 5F      $
��100* �6/   6>   .+�5H      �� $��0��6$   $
��Bold"�64   $��Center=�6F   $��Right=�6a   $��14(�6}   Xác nhận�� 6�   mật khẩu6�   �� 5I      $��1��6!   
�������$ 25��6D   $��30��6V   $	��180��6b   
���   �$��1q�6�   ._�5J      �� -   5        $	 
repeatpass��5J   &   
������ $��30��6T   $	��152��6`   $��0q�6l   $��Center=�5K   *   $
��Left=�6L   $��14(�6g   $��27.2,0.2,-0.8,-1.4q�6u   6�   5L      5M      5N      5O      � 5P      $��3��6   $��Center=�6    $��Center=�6=   .+�5Q      �� $
��Lưu��6   
�������$��14(�6:   ��5R      �� *Save+��6.   �� 
 �� ElementName$
 	AccountWD��6c   5S      5U      5V      5W      