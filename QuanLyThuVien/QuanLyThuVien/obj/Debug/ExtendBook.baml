   M S B A M L   `   `   `  ����H  DQuanLyThuVien, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:QuanLyThuVienQuanLyThuVien  5   	   G(clr-namespace:QuanLyThuVien.UserControlsQuanLyThuVien.UserControls  5   	   A%clr-namespace:QuanLyThuVien.ViewModelQuanLyThuVien.ViewModel  5   	       QuanLyThuVien.ExtendBook   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   'localclr-namespace:QuanLyThuVien  5   	   1uc(clr-namespace:QuanLyThuVien.UserControls  5   	   _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   5	viewmodel%clr-namespace:QuanLyThuVien.ViewModel  5   	   -   5          �Name$  wdMain��5   	    � WindowStartupLocation$ CenterScreen=�5
   	    
  MainVM � DataContext# [  5   	     MaterialDesignBody#���  5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$ Quản lý Thư Viện��5   	   $	��504��6"   $	��828��6/   .��5      �  � RowDefinitions 5   
   �� 5      $��70 �6   6*   �� 5      $��50 �6   6*   �� 5      $��50 �6   6*   �� 5      $	��200 �6   6+   �� 5      $	��50* �6   6+   .+�5   
   � $��0��6    � ColumnDefinitions 5       �� 5!      $	��650 �6#   61   �� 5"      6%   .+�5$      �� $��0��6   $
��Bold"�6(   $��Center=�6:   $��
300,20,0,0q�6U   $��35(�6i   Gia hạn sách6�   � 5%      $��1��6    � 	Resources 5&      	 �� 
TargetType
 �� Property �� Value �� 
TargetType ��Name �� CornerRadius � Cursor��%�   '��       �� 5'      "	 ��6   .�5(      �� 
 � �� 5)      �� 5*   "   " ��62   .R�5+   &   �� $ 	btnBorder��6-   $ 20��6@   ._�5,   *   �� $��	0 0 15 15q�6;   $
 Hand��5-   7   5.   '   5/   #   51      52      53      .+�54      �� -   5         ��Name$ btnHome��54      $��1��6*   
 J� Uid$ 1��67   .��55      � $��70��6   $��70��6'   .+�56      �� -   5        $ bdHome��56   !   
�������$ 20��6D   ._�57      �� $��Center=�6)   $��Center=�6D   .+�58   "   '  !MaterialDesignThemes.Wpf.PackIcon  -   5          Name$ icHome��58   :   $��Center=�6J      Kind$ HomeOutline=�6g   $��30��6z   $��30��6�   
���   �6�   �� 59   "   -   5         ��Name$ txtHome��59   ,   $
��Home��6=   
�������6^   5:      5;      5<      .  (System.Windows.Interactivity.Interaction   Triggers 5=      /  )System.Windows.Interactivity.EventTrigger  5>         	EventName$ Click��6)   .  (System.Windows.Interactivity.TriggerBase   Actions. 5?      6  0System.Windows.Interactivity.InvokeCommandAction     Command 64   �� *SwitchTabCommand+   CommandParameter 6Y   ��  �� ElementName$ wdMain��5@        5A      $ 	MouseMove��6)   . 5B         64   �� *GetUidCommand+ 6V   �� $ btnHome��5C      5E      5F      5G      � 5H   
   $��1��6    5I      �� 5J      $	��150 �6#   61   �� 5K      6%   �� 5L      $	��150 �6#   61   �� 5M      6%   .+�5O      �� $��0��6   $
��Bold"�6(   $��16(�6:   $��Center=�6H   $��right=�6c   Ngày gia hạn:6�   �� 5P      $��1��6   
�������$ 25��69   $��30��6K   $	��180��6W   
���   �$��1q�6x   ._�5Q      �� 
������ $��35��63   $	��160��6?   $��0q�6K   $��20 0 0 0q�5R      $��Center=�6(   $
��Left=�6J   $��14(�6e   .��6t   5S      5T      5U      � 5V   
   $��2��6    5W      �� 5X      $	��150 �6#   61   �� 5Y      6%   �� 5Z      $	��150 �6#   61   �� 5[      6%   .+�5]      �� $��0��6   $
��Bold"�6(   $��16(�6:   $��Center=�6H   $��right=�6c   	Mã SV:6�   �� 5^      $��2��6   $
��Bold"�6(   $��16(�6:   $��Center=�6H   $��center=�6c   Họ và tên:6�   �� 5_      $��1��6   
�������$ 25��68   $��30��6J   $	��180��6V   
���   �$��1q�6w   ._�5`      �� 
������ $��35��63   $	��160��6?   $��0q�6K   $��20 0 0 0q�5a      $��Center=�6(   $
��Left=�6J   $��14(�6e   .��6t   5b      5c      �� 5d      $��3��6   $��Center=�6%   $
��Left=�6@   
�������$ 25��6n   $��30��6�   $	��180��6�   
���   �$��1q�6�   ._�5e      �� 
������ $��35��63   $	��160��6?   $��0q�6K   $��20 0 0 0q�5f      $��Center=�6(   $
��Left=�6J   $��14(�6e   .��6t   5g      5h      5i      � 5j   
   $��4��6    5k      �� 5l      6%   �� 5m      6%   .+�5o      �� $��0��6   $	��130��6%   $��Xác nhận��5p   !   
�������$��18(�6G   
���  ��$
��Bold"�6f   ��5o   1   �� *OpenAddBook+��6Q   �� $ BookWD��5q      �� 5r      $��1��6   $	��130��6%   $��Thoát��5s   !   
�������$��18(�6D   
���  ��$
��Bold"�6c   ��5r   1   �� *OpenAddBook+��6Q   �� $ BookWD��5t      5u      5v      5w      