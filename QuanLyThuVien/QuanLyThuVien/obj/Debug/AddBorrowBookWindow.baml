   M S B A M L   `   `   `  ����H  DQuanLyThuVien, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:QuanLyThuVienQuanLyThuVien  5   	   G(clr-namespace:QuanLyThuVien.UserControlsQuanLyThuVien.UserControls  5   	   A%clr-namespace:QuanLyThuVien.ViewModelQuanLyThuVien.ViewModel  5   	   '    !QuanLyThuVien.AddBorrowBookWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   'localclr-namespace:QuanLyThuVien  5   	   1uc(clr-namespace:QuanLyThuVien.UserControls  5   	   _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   5	viewmodel%clr-namespace:QuanLyThuVien.ViewModel  5   	   -   5          �Name$  addBorrowBookWD��5   	    � WindowStartupLocation$ CenterScreen=�5
   	    
  MainVM � DataContext# [  5   	     MaterialDesignBody#���  5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$ AddBorrowBookWindow��5   	   $	��300��6%   $	��500��62   .��5      � .+�5   
   �� ._�5      �  � RowDefinitions 5      �� 5      $
��auto �6$   64   �� 5      $	��150 �6$   63   �� 5      $��70 �6$   62   .+�5      � $��0��6   $��60��6$   .+�5       � $��Center=�6   $��Center=�66   .+�5!      �� $��30(�6%   $
��Bold"�63   $��Thêm sách mượn��6E   6^   5"      5#      �� 5$      $��1��6   ._�5%      �  � ColumnDefinitions 5&      �� 5'      $	��100 �6/   6=   �� 5(      $	��300 �6/   6=   �� 5)      $	��100 �6/   6=   .+�5+      � $��1��6   ���	#FF4699DA 5,      �� 5-   "   $��50 �60   6>   �� 5.   "   $��50 �60   6>   �� 5/   "   $	��50* �60   6?   .+�51      � $��0��6#    52   "   �� 53   &   $
��0.5* �67   6F   �� 54   &   $��1* �67   6D   .+�56   "   �� $��0��6,   $
��Bold"�6<   $��Center=�6N   $
��Left=�6i   $��14(�6�   	Mã sách6�   �� 57   "   $��1��6)   
������� �� CornerRadius$ 25��6L   $��30��6^   $	��200��6j   
���   �$��1q�6�   ._�58   &   �� 
������ $��30��6G   $	��179��6S   $��0q�6_   $��Center=�59   )   $
��Left=�6K   .��6f   5:   '   5;   #   5<      � 5=      $��1��6#    5>   "   �� 5?   &   $
��0.5* �67   6F   �� 5@   &   $��1* �67   6D   .+�5B   "   �� $��0��6,   $
��Bold"�6<   $��Center=�6N   $
��Left=�6i   $��14(�6�   
Tên sách6�   �� 5C   "   $��1��6)   
�������$ 25��6L   $��30��6^   $	��200��6j   
���   �$��1q�6�   ._�5D   &   �� 
������ $��30��6G   $	��179��6S   $��0q�6_   $��Center=�5E   )   $
��Left=�6K   .��6f   5F   '   5G   #   5H      � 5I      $��2��6#    5J   "   �� 5K   &   $
��0.5* �67   6F   �� 5L   &   $��1* �67   6D   .+�5N   "   �� $��0��6,   $
��Bold"�6<   $��Center=�6N   $
��Left=�6i   $��14(�6�   
Tác giả6�   �� 5O   "   $��1��6)   
�������$ 25��6L   $��30��6^   $	��200��6j   
���   �$��1q�6�   ._�5P   &   �� 
������ $��30��6G   $	��179��6S   $��0q�6_   $��Center=�5Q   )   $
��Left=�6K   .��6f   5R   '   5S   #   5T      5U      5V      5W      � 5Y      $��2��6   	 � 	Resources	 5Z      
 �� 
TargetType �� Property �� Value �� 
TargetType �� Padding � Cursor��%(  '��       �� 5[      "
 ��6    .�5\      ��  � �� 5]   "   �� 5^   &   " ��66   .R�5_   *   �� ���#F73B4F$ 15��6F   $
��0 20q�6X   $
 20 2q�6f   $��30��6u   ._�5`   .   � .+�5a   2   �� $��5q�6C   $
 Hand��6N   5b   /   5c   +   5d   '   5f      5g      5h       5i      �� 5j      6-   �� 5k      6-   .+�5m      � $��0��6   $��Center=�6+   .+�5n      �� $��Xác nhận��6!   
�������$��14(�6G   ��5o      �� *SubmitAddBorowBook+��6<   ��  �� ElementName$ addBorrowBookWD��6w   5p      � 5q      $��1��6   $��Center=�6+   .+�5r      �� $��Thoát��6!   
�������$��14(�6D   ��5s      �� *ExitAddBorrowBook+��6;   �� $ addBorrowBookWD��6v   5t      5u      5x      5y      5z      5{      