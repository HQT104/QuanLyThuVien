   M S B A M L   `   `   `  ����H  DQuanLyThuVien, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:QuanLyThuVien.UserControlsQuanLyThuVien.UserControls  5      2    ,QuanLyThuVien.UserControls.CardDetailControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:QuanLyThuVien.UserControls     5      _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5          >�Name$  CardDetailCT��5       
  CardVM � DataContext# [  5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   6,   �� 5      $
��1.5* �6   6.   �� 5      $
��1.5* �6   6.   �� 5      $��1* �6   6,   �� 5      $��1* �6   6,   �� 5      $��1* �6   6,   �� 5      6"    � 	Resources 5   
    �� 
TargetType �� Property �� Value��%(  '��       '�� �     �� 5      " ��6   .�5      ��  � ��
 �����6?   �� 5       � ��$ 1q�64   6@   �� 5       � �� �#ccc6?   5      �� 5      " ��6   .�5      ��  � ��$	 0 2q�6+   69   �� 5       � ��$ Center=�68   6I   5      5       .+�5!   
   � $��0��6   .+�5"      �� ._�5#      �� -   5         ��Name$ txbID��5#      6-   5$      5%      � 5&   
   $��1��6   .+�5'      �� ._�5(      �� -   5        $ txbName��5(      6/   5)      5*      � 5+   
   $��2��6   .+�5,      �� ._�5-      �� -   5        $ txbEmail��5-      60   5.      5/      � 50   
   $��3��6   .+�51      �� ._�52      �� -   5        $ txbSDT��52      6.   53      54      � 55   
   $��4��6   .+�56      �� ._�57      �� -   5        $ txbDate��57      6/   58      59      � 5:   
   $��5��6   .+�5;      �� ._�5<      �� -   5        $ txbTotalDebt��5<      64   5=      5>      � 5?   
   $��6��6   .+�5@      �� ._�5A      ��  �� Orientation$ 
Horizontal=�6   $��Center=�66   .+�5B      �� 
������ $��25��5D   2   $��0q�6>   $��0q�6R   $��0 0 20 0q�6^   ��5B      �� 	 �� RelativeSource	 �� *FindAncestor+
 �� AncestorType"
 �� �� Path$ DataContext.OpenEditCard���5C      ��  �� ElementName$ CardDetailCT��.��5E      '  !MaterialDesignThemes.Wpf.PackIcon  $��25��62   $��25��6>   
����  �   Kind$ PencilBoxOutline=�6[   5F      �� 5G      
������ $��25��66   $��0q�6B   $��0q�6V   ��5H      �� 	 �� *FindAncestor+"
 ��$# DataContext.DeleteCardCommand���5I      �� $ CardDetailCT��.��5J        $��25��62   $��25��6>   
���  ��$ Delete=�6Z   5K      5L      5M      5N      5O      5P      