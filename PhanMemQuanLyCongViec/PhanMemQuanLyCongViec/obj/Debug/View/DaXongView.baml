   M S B A M L   `   `   `  ����P  LPhanMemQuanLyCongViec, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:PhanMemQuanLyCongViec.ViewPhanMemQuanLyCongViec.View  5   	   +    %PhanMemQuanLyCongViec.View.DaXongView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   4local(clr-namespace:PhanMemQuanLyCongViec.View  5   	      UserControlStyle#��[  5	   	   .  (System.Windows.Interactivity.Interaction    Triggers  5      /  )System.Windows.Interactivity.EventTrigger  5   
      	EventName$ Loaded��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6%   �� *loadCommand+   CommandParameter 6F   ��  �� ElementName$ hinhAnhListView��5      .��5      � 
������  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��50 �6   .+�5   
   �� 
�������$��0��6%    �� CornerRadius$ 15��62   $	��540��6E   ._�5      �� $
��Auto=�6   $
��Auto=�6>   .��5      �� -   5         ��Name$ hinhAnhListView��5   ?   ��6   �� *listHinhAnh+	 �� View	 5      �� 5      .P�5      �� $
��Tên��6V   
 �� Width$	
 140��6c    �� DisplayMemberBinding 6-   �� *	TenHinh+6c   �� 5      $��
Kích cỡ��6U   $	
 130��6f    6-   �� *KichCo+6f   �� 5      $��
Ngày giao��6[   $	
 130��6n    6-   �� *NgayGiaoHinh+6n   �� 5      $��Số điện thoại��6\   $	
 148��6s    6-   �� *SoDienThoaiKH+6s   �� 5      $
��Giá��6V   $	
 160��6c    6-   �� *	GiaHinh+6c   �� 5       $��Khách cọc��6Z   $	
 160��6m    6-   �� *GiaKhachCoc+6m   �� 5!      $��
Còn lại��6U   $	
 160��6f    6-   �� *ConLai+6f   �� 5"      $��Ghi chú��6U   $	
 190��6f    6-   �� *GhiChu+6f   �� 5#      $��Loại hình��6V   $	
 130��6i    6-   �� *	TenLoai+6i   5$      5&      5'      5(      �� 5)   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $	��880��6;   .+�5*      �� $��
Chưa xong��6   $	��100��6)   ���	#FF405E63��6L   �� *chuaXongCommand+��6p   �� $ hinhAnhListView���� 5+      $��Chuyển vào thùng rác��6   $	��173��64   ���	#FF405E63$��10,0,0,0q�6W   ��6i   �� *xoaHinhCommand+��6�   �� $ hinhAnhListView��5,      5-      5.      