   M S B A M L   `   `   `  ����P  LPhanMemQuanLyCongViec, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:PhanMemQuanLyCongViec.ViewPhanMemQuanLyCongViec.View  5   	   0    *PhanMemQuanLyCongViec.View.CapNhatThongTin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:PhanMemQuanLyCongViec.View     5   	   -   5          �Name$  capNhatWindow��5   >    � Title$ ThemHinhView��5   	   $	��550��6   $	��700��6+    � WindowStartupLocation$ CenterScreen=�5	   	   .��5
      � ���	#FF17272B � 	Resources 5   
    �� 
TargetType   textBlockStyle �� Property �� Value  textBoxStyle �� ElementName��%  &	        &	 �     �� 5      " ��6   .�5      ��  � ��
 ��ح�6/   �� 5       � ��$ 20(�6-   �� 5       � ��$ Arial Rounded MT Bold)�6/   �� 5       � ��$
 Left=�68   5      �� 5      " ��6   .�5      ��  � ��
 �����6/   �� 5       � ��$
 Left=�68   �� 5       � ��$ 20(�6-   �� 5       � ��$ 30��6+   �� 5       �@��TextAlignment$
 Left=�62   �� 5       � �� 6*   �� *Width+$ fieldStackPanel��5      5       � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��50 �6   �� 5      .+�5!   
   �� $��1��6   $��Center=�6!   $��Thông tin hình ảnh��6>   
�������$��30(�6k   $��Arial Rounded MT Bold)�6y   �� 5"   
   -   5        	 ��Name$	 fieldStackPanel��5"      $��2��6.   $	��500��6;   .+�5#      �� $��Tên hình ảnh��6   #��[  6,   �� 5$      -   5        
 ��Name$
 tenHinhTextbox��5$      #��[ 6.    � DataContext 6T   �� *	hinhAnh+��6t   ��  �� Path$ TenHinh� �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=��� 5%      $��
Kích cỡ��6   #��[  6'   �� 5&      -   5        $
 kichCoTextbox��5&      #��[ 6-    6T   �� *	hinhAnh+��6t   �� $ KichCo�$ PropertyChanged=�$ TwoWay=��� 5'      $��
Giá hình��6   #��[  6(   �� 5(      -   5        $
 giaHinhTextbox��5(      #��[ 6.    6U   �� *	hinhAnh+��6u   �� $ GiaHinh�$ PropertyChanged=�$ TwoWay=��� 5)      $��Tiền khách cọc��6   #��[  6.   �� 5*      -   5        $
 tienKhachCocTextbox��5*      #��[ 63    6Z   �� *	hinhAnh+��6z   �� $ GiaKhachCoc�$ PropertyChanged=�$ TwoWay=��� 5+      $��
Ngày giao��6   #��[  6)   �� 5,      -   5        $
 ngayGiaoTextbox��5,      #��[ 6/    6V   �� *	hinhAnh+��6v   �� $ NgayGiaoHinh�$ PropertyChanged=�$ TwoWay=��� 5-      $&�� Số điện thoại khách giao��6   #��[  68   �� 5.      -   5        $
 	SdtTexbox��5.      #��[ 6)    6P   �� *	hinhAnh+��6p   �� $ SoDienThoaiKH�$ PropertyChanged=�$ TwoWay=��� 5/      $��Ghi chú��6   #��[  6'   �� 50      -	   5        $
 ghiChuTextbox��50      #��[ 6-    6T   �� *	hinhAnh+��6t   �� $ GhiChu�$ PropertyChanged=�$ TwoWay=��� 52       �� Orientation$ 
Horizontal=�6   $��0,20,0,0q�62   .+�53      �� $	��100��6s   $��
130,0,30,0q�6   ���	#FF92A2A1$��Cập nhật��6�   
�������$��Arial Rounded MT Bold)�6�   ��6   �� *suaHinhCommand+��6<   �� $ capNhatWindow��6�   �� 54      -
   5         ��Name$ huyBtn��54   o   $��80��6   ���	#FF92A2A1$��Hủy��6�   
�������$��Arial Rounded MT Bold)�6�   ��6   �� *
huyCommand+��68   �� $ capNhatWindow��6�   55      56      �� 57   
   -   5         ��Name$ maHinhTextBlock��57      $	��200��6-   $��0��69   58      59      