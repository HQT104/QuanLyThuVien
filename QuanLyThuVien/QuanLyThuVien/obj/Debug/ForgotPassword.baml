   M S B A M L   `   `   `  ����H  DQuanLyThuVien, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:QuanLyThuVienQuanLyThuVien  5   	   "    QuanLyThuVien.ForgotPassword   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:QuanLyThuVien     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   h dMicrosoft.Expression.Interactions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bei9http://schemas.microsoft.com/expression/2010/interactions  5	   	   _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5          �Name$  forgotPasswordWD��5   	    � WindowStartupLocation$ CenterScreen=�5
   	      LoginVM � DataContext# [  5   	     MaterialDesignBody#���  5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$ ForgotPassword��5   	   $	��350��6    $	��400��6-   .��5      � ��5   
   �� 5       �� ImageSource$ Images\Sach.jpg��6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      $	��300 �6   6-   �� 5      6!   .+�5   
   � $��1��6   .+�5       �� $
��Left=�6   $	��300��61   ._�5!      �  � RowDefinitions 5"      �� 5#      $	��100 �6(   67   �� 5$      $	��200 �6(   67   �� 5%      $	��100 �6(   67   .+�5'      � $��1��6   $��Center=�6(   $��Center=�6C   ���	#FF4699DA 5)      �� 5*      $
��auto �6,   6<   �� 5+      $
��auto �6,   6<   �� 5,      $
��auto �6,   6<   �� 5-      $
��auto �6,   6<   �� 5.      $
��auto �6,   6<   .+�51      � $��0��6   .+�52      �� -   5        	 ��Name$	 nameAccount��53   U   
�������$	��200��52   9   
���   �
 �� 
CaretBrush

 ����� �� SelectionBrush
 �����)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tên tài khoản��53   &    % !MaterialDesignFloatingHintTextBox#��[ 54   &   .��6b   55      56      � 57      $��1��6   .+�58      �� -   5        $	 confirmAccount��59   e   
�������$	��200��58   9   
�������

 �����
 �����$- 'Email hoặc SĐT bạn đã đăng ký��59   &   #��[ 5:   &   .��6b   5;      5<      � 5=      $��2��6   .+�5>      �� -   5        $	 newPassword��5?   T   
�������$	��200��5>   9   
�������

 �����
 �����$ Mật khẩu mới��5?   &   #��[ 5@   &   .��6b   5A      5B      � 5C      $��3��6   .+�5D      �� -   5        $	 confirmPassword��5E   Y   
�������$	��200��5D   9   
�������

 �����
 �����$ Xác nhận mật khẩu��5E   &   #��[ 5F   &   .��6b   5G      5H      � 5I      $��4��6    � 	Resources 5J       �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius �� Padding � Cursor��%(  '��       �� 5K   "   " ��6(   .�5L   &   ��  � �� 5M   *   �� 5N   .   " ��6>   .R�5O   2   �� ���#F73B4F$ 15��6N   $
��0 20q�6`   $
 20 2q�6n   $��30��6}   ._�5P   6   � .+�5Q   :   �� $��5q�6K   $
 Hand��6V   5R   7   5S   3   5T   /   5V   '   5W   #   5X       5Y      �� 5Z   "   65   �� 5[   "   65   .+�5]      � $��0��6#   $��Center=�63   .+�5^   "   �� $��Xác nhận��6)   
�������$��14(�6O   ��5_   )   �� *EditAccount+��6I   ��  �� ElementName$ forgotPasswordWD��6�   5`      � 5a      $��1��6#   $��Center=�63   .+�5b   "   �� $��Thoát��6)   
�������$��14(�6L   ��5c   )   �� *ExitForgotPassWord+��6P   �� $ forgotPasswordWD��6�   5d      5f      5g      5h      5i      5k      5l      5m      