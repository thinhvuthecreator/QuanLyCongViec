   M S B A M L   `   `   `  ����P  LPhanMemQuanLyCongViec, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:PhanMemQuanLyCongViecPhanMemQuanLyCongViec  5   	   g8clr-namespace:PhanMemQuanLyCongViec.UserControlTuanThinh*PhanMemQuanLyCongViec.UserControlTuanThinh  5   	   Q-clr-namespace:PhanMemQuanLyCongViec.ViewModelPhanMemQuanLyCongViec.ViewModel  5
   	   &     PhanMemQuanLyCongViec.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:PhanMemQuanLyCongViec     5   	   Guc8clr-namespace:PhanMemQuanLyCongViec.UserControlTuanThinh     5   	   _ [MaterialDesignThemes.Wpf, Version=4.7.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   =	viewModel-clr-namespace:PhanMemQuanLyCongViec.ViewModel  5
   	   -   5          �Name$  
mainWindow��5   	    
  MainVM � DataContext# [  5   	    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5   	    � Title$ Quản lý công việc��5   	   $	��640��6#   $	��850��60   .��5      � ���	#FF2F3742 � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      6   .+�5   
   � $��0��6   .+�5      >   8PhanMemQuanLyCongViec.UserControlTuanThinh.UserControlTT  
 � Tag 6   �� *Title+ �� ElementName$ 
mainWindow��5      5      � 5   
   $��1��6   	 � ColumnDefinitions	 5      �� 5      $	��100 �6#   �� 5       .+�5#      �� -   5        
 ��Name$
 toggleBtnStackPanel��5#      $��0��66   ���	#FF1A1E2C.+�5%      	� -   5         	�Name$ imageTypeRadioBtn��5%      $	��100��69   $	��100��6F     MenuButtonTheme#��[ 6R   $��LOẠI HÌNH ẢNH��6{   ��6�   �� *LoaiHinhCommand+5&      	� 5(      -   5        $ imageDoneRadioBtn��5(      $	��100��69   $	��100��6F   #��[ 6R   $��	ĐÃ XONG��6{   ��6�   �� *DaXongCommand+5)      	� 5+      -   5        $ imageNotDoneRadioBtn��5+      $	��100��6<   $	��100��6I   #��[ 6U   $��
CHƯA XONG��6~   ��6�   �� *ChuaXongCommand+5,      	� 5.      -   5        $ recyleBinRadioBtn��5.      $	��100��69   $	��100��6F   #��[ 6R   $��THÙNG RÁC��6{   ��6�   �� *ThungRacCommand+5/      �� 50      $��A PRODUCT FROM :��6   $��7(�64   
�������$
��Wrap=�6U   $��
20,100,0,0q�6i   �� 52      $��30��6   $��0,8,0,2q�6#   $��/ImagesSource/tapCom.jpg��64   �� 53      $��tapCom-Tech��6   $��11(�6/   
�������$
��Wrap=�6Q   $��19,0,0,2q�6e   �� 54      $��Software corporation.��6   $��5(�69   
�������$��27,0,0,0q�6Z   56      �� 58      -   5         ��Name$ SceneContentControl��58   -   $��1��6   $��1��59      $��10q�5:      
���   ���5;      �� *CurrentView+ �� UpdateSourceTrigger$ PropertyChanged=�6b   5=      5D      5E      