   M S B A M L   `   `   `  ����H  DQuanLyThuVien, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:QuanLyThuVienQuanLyThuVien  5   	   $    QuanLyThuVien.DetailBookWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:QuanLyThuVien     5   	   _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5	   	   -   5        $��detailBookWD��5   	      MaterialDesignBody#���   5
   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � WindowStartupLocation$ CenterScreen=�5   	    
 BookVM � DataContext# [ 5   	    � Title$ Thông tin sách��5   	   $	��600��6    $	��300��6-   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $	��100 �6   6+   �� 5      $��40 �6   6*   �� 5      $��40 �6   6*   �� 5      $��40 �6   6*   �� 5      $��40 �6   6*   �� 5      $��40 �6   6*   �� 5      $��40 �6   6*   �� 5      $��40 �6   6*   �� 5       $��40 �6   6*   �� 5!      $��40 �6   6*   �� 5"      $
��auto �6   6,   .+�5$   
   � $��0��6   $��0 10 0 0q�6   .+�5%      �� $��Thông tin sách��6   $��20(�6.   $��Center=�6<   6[   5&      � 5'   
   $��1��6    � ColumnDefinitions 5(      �� 5)      $	��87* �6#   �� 5*      $	��59* �6#   .+�5,      �� $��/Images/Sach.jpg��6   $��2��6.   5-      � 5.   
   $��2��6   $
��16 0q�6   .+�5/      �� -   5         ��Name$ txbBookName��5/      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Tên sách��6+    % !MaterialDesignFloatingHintTextBox#��[ 6U   50      � 51   
   $��3��6   $
��16 0q�6   .+�52      �� -   5        $ 	txbBookID��52      $ 	Mã sách��6)   #��[ 6R   53      � 54   
   $��4��6   $
��16 0q�6   .+�55      �� -   5        $ txbBookCategory��55      $ Thể loại��60   #��[ 6Z   57      � 58   
   $��5��6   $
��16 0q�6   .+�59      �� -   5        $ txbBookAuthor��59      $ 
Tác giả��6-   #��[ 6V   5;      � 5<   
   $��6��6   $
��16 0q�6   .+�5=      �� -   5        $ txbBookPublishYear��5=      $ Năm xuất bản��63   #��[ 6a   5?      � 5@   
   $��7��6   $
��16 0q�6   .+�5A      �� -   5        $ txbBookPulisher��5A      $ Nhà xuất bản��60   #��[ 6^   5C      � 5D   
   $��8��6   $
��16 0q�6   .+�5E      �� -   5        $ txbBookImportDate��5E      $ Ngày nhập��62   #��[ 6]   5G      � 5H   
   $��9��6   $
��16 0q�6   .+�5I      �� -	   5        $ txbBookValue��5I      $ 
Giá trị��6,   #��[ 6U   5K      � 5L   
   $��10��6   $
��16 0q�6   .+�5M      �� -
   5        $ txbBookNumber��5M      $ Số lượng��6.   #��[ 6X   5N      � 5O   
   $��11��6   	 � 	Resources	 5P      
 �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius �� Padding � Cursor��%  '��       �� 5Q      "
 ��6   .�5R      ��  � �� 5S      �� 5T      " ��6.   .R�5U   "   �� ���#F73B4F$ 15��6>   $
��0 20q�6P   $
 20 2q�6^   ._�5V   &   � .+�5W   *   �� $��5q�6;   $
 Hand��6F   5X   '   5Y   #   5Z      5\      5]      5^       5_      �� 5`      6%   �� 5a      6%   .+�5c      � $��0��6   $��Center=�6#   .+�5d      �� $
��Lưu��6   
�������$��14(�6:   ��5e      �� *EditBookCommand+��69   ��  �� ElementName$ detailBookWD��6q   5f      � 5g      $��1��6   $��Center=�6#   .+�5h      �� $��Thoát��6   
�������$��14(�6<   ��5i      �� *ExitBookCommand+��69   �� $ detailBookWD��6q   5j      5k      5l      5m      