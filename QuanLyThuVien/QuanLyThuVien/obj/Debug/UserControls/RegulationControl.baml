   M S B A M L   `   `   `  ����H  DQuanLyThuVien, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:QuanLyThuVien.UserControlsQuanLyThuVien.UserControls  5      A%clr-namespace:QuanLyThuVien.ViewModelQuanLyThuVien.ViewModel  5
      2    ,QuanLyThuVien.UserControls.RegulationControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      4local(clr-namespace:QuanLyThuVien.UserControls  5      _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      5	viewmodel%clr-namespace:QuanLyThuVien.ViewModel  5
      -   5          >�Name$  RegulationCT��5         RegulationVM � DataContext# [  5        MaterialDesignBody#���  5      $��Regular"�5      $��14(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      $	��454��5      $	��600��6   .��5      �  � RowDefinitions 5   
   �� 5      $��60 �6   6*   �� 5      $��60 �6   6*   �� 5      $	��250 �6   6+   �� 5      $��70 �6   6*   .+�5   
   �� $��0��6   ���#44bcd8 �� CornerRadius$ 30��63   $��50��6E   
���   �$��1q�6e   $	��400��6y   ._�5      �� -   5         ��Name$ QL��5      $
��Bold"�6%   $��Center=�67   $��Center=�6R   $��20(�6o   Quản lý thư viện6�   5      �� 5!   
   $��1��6   $
��Bold"�6!   $��Center=�63   $��Center=�6N   $��20(�6k   Thay đổi quy định6�   �� 5#   
   $��2��6   ._�5$      �  � ColumnDefinitions 5%      �� 5&      $	��100 �6'   65   �� 5'      $	��400 �6'   65   �� 5(      $	��100 �6'   65   .+�5*      � $��1��6   ���	#FF4699DA 5+      �� 5,      $��80 �6(   66   �� 5-      $��50 �6(   66   �� 5.      $	��50* �6(   67   �� 5/      $	��50* �6(   67   .+�51      � $��0��6    52      �� 53      $
��0.7* �6/   6>   �� 54      $��1* �6/   6<   .+�56      �� $��0��6$   $
��Bold"�64   $��Center=�6F   $
��Left=�6a   $��14(�6|   Số năm xuất bản6�   �� 57      $��1��6!   
�������$ 25��6D   $��30��6V   $	��200��6b   
���   �$��1q�6�   ._�58      �� -   5         ��Name$ txbSONAMXUATBAN��58   k   
������ $��30��6?   $	��179��6K   $��0q�6W   $��Center=�59   )   $��Center=�6K   .��6h   5:      5;      5<      � 5=      $��1��6    5>      �� 5?      $
��0.7* �6/   6>   �� 5@      $��1* �6/   6<   .+�5B      �� $��0��6$   $
��Bold"�64   $��Center=�6F   $
��Left=�6a   $��14(�6|   Số sách mượn tối đa6�   �� 5C      $��1��6!   
�������$ 25��6D   $��30��6V   $	��200��6b   
���   �$��1q�6�   ._�5D      �� -   5        $ txbSLSACHMUON��5D   k   
������ $��30��6?   $	��179��6K   $��0q�6W   $��Center=�5E   )   $��Center=�6K   .��6h   5F      5G      5H      � 5I      $��2��6    5J      �� 5K      $
��0.7* �6/   6>   �� 5L      $��1* �6/   6<   .+�5N      �� $��0��6$   $
��Bold"�64   $��Center=�6F   $
��Left=�6a   $��14(�6|   Thời gian mượn6�   �� 5O      $��1��6!   
�������$ 25��6D   $��30��6V   $	��200��6b   
���   �$��1q�6�   ._�5P      �� -   5        $ txbTHOIGIANMUON��5P   k   
������ $��30��6?   $	��179��6K   $��0q�6W   $��Center=�5Q   )   $��Center=�6K   .��6h   5R      5S      5T      � 5U      $��3��6    5V      �� 5W      $
��0.7* �6/   6>   �� 5X      $��1* �6/   6<   .+�5Z      �� $��0��6$   $
��Bold"�64   $��Center=�6F   $
��Left=�6a   $��14(�6|   &$Số tiền phạt trả trễ/ngày6�   �� 5[      $��1��6!   
�������$ 25��6D   $��30��6V   $	��200��6b   
���   �$��1q�6�   ._�5\      �� -   5        $ txbSOTIENPHAT��5\   k   
������ $��30��6?   $	��179��6K   $��0q�6W   $��Center=�5]   )   $��Center=�6K   .��6h   5^      5_      5`      5a      5b      5c      � 5e   
   $��3��6   	 � 	Resources	 5f      
 �� 
TargetType �� Property �� Value �� 
TargetType �� Padding � Cursor��%(  '��       �� 5g      "
 ��6   .�5h      ��  � �� 5i      �� 5j      " ��6.   .R�5k   "   �� ���#F73B4F$ 15��6>   $
��0 20q�6P   $
 20 2q�6^   $��30��6m   ._�5l   &   � .+�5m   *   �� $��5q�6;   $
 Hand��6F   5n   '   5o   #   5p      5r      5s      5t      .+�5u      �� $��Xác nhận��6   
�������$��14(�6;   $	��120��6I   ��5v      �� *ConfirmRegulation+��67   ��  �� ElementName$ RegulationCT��6o   5w      5y      5{      