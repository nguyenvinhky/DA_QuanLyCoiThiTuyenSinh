   M S B A M L   `   `   `  ����P  LQuanLyCoiThiTuyenSinh, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:QuanLyCoiThiTuyenSinhQuanLyCoiThiTuyenSinh  5   	   c6clr-namespace:QuanLyCoiThiTuyenSinh.UserControl_QLCTTS(QuanLyCoiThiTuyenSinh.UserControl_QLCTTS  5   	   $    QuanLyCoiThiTuyenSinh.DangNhap   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:QuanLyCoiThiTuyenSinh     5   	   Euc6clr-namespace:QuanLyCoiThiTuyenSinh.UserControl_QLCTTS     5   	   V RXamlAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=20a987d8023d9690<gif2https://github.com/XamlAnimatedGif/XamlAnimatedGif  5	   	   _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
   	   -   5          �Name$  LoginWindows��5   	    � 
ResizeMode$ NoResize=�5   	    � AllowsTransparency . 
������� � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � Title$ Đăng nhập��5   	   $	��500��6   $	��350��6(   .��5      � .+�5   
   �� $	��280��6   $	��top=�6!   ��5      �� 5       �� EndPoint$ 0.5, 1&�6&    �� 
StartPoint$ 0.5, 0&�68   .��5      �  � Color$ 	#FF2281D1��6#   � 5      $ 	#FF34268A��6#   	 � Offset$	 1Q�65   � 5      $ 	#FF33288B��6#   $		 0.5Q�65   5      5      �� 5   
   $
��Fill=�6   $��Images/iconH.png��6   $��50��69   $��50��6D   $	��Top=�6P   $��20q�6h   �� 5   
   $	��280��6   $	��240��6    
�������$��Bottom=�6?   $��0, 100q�6Z   
 �� RadiusY$
 30��6j    �� RadiusX$ 30��6w    J� Effect 5       3  -System.Windows.Media.Effects.DropShadowEffect  5!         Color$ 	#FFBBBBBB��6#      	Direction$ 0Q�65      
BlurRadius$ 15Q�6C      RenderingBias$ Quality=�6S      ShadowDepth$ 1Q�6k   5#      � 5%   
   $	��280��6   $	��240��6   $��Bottom=�6(   $��0, 100q�6C   .+�5&      �� 
�������$��LOGIN��6*   $��Center=�67   $	��Top=�6T   $��5q�6l   $��18(�6w   $��Black"�6�   �� 5'      $��Center=�6   $��10q�64   .+�5(      �� -   5         ��Name$ txtTenDangNhap��50      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tên đăng nhập��5(      $��0, 10q�5)      $	��250��5*      $��50��5+      $��Black"�5,      $��Center=�5-      $��admin��5.      
���   �   
Foreground
 �   �.  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush
 �   � %  !MaterialDesignFloatingHintTextBox#��[  53      $��Center=�54      $��	Champagne)�64   G� 56      -   5         G�Name$ 
txtMatKhau��56      $��0, 10q�57      $	��250��58      $��50��59      $��Black"�5:      
���   �$ Mật khẩu��5<      
 �   �
 �   � ) %MaterialDesignFloatingHintPasswordBox#��[ 5?      5@      5A      �� 5C   
   -   5         ��Name$ btnDangNhap��5M       " MaterialDesignFlatDarkBgButton#��[ 5C      $��LOGIN��5D      $	��150��5E      $��30��5F      ���	#FF2281D1$��Black"�5H       �� 	IsDefault . $��Bottom=�5J      $��0q�5K      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 30��5L      $��0, 85q�5O      �� 5Q   
   -   5        $ btnExit��5V      $��Click để thoát��5Q      
������ 
�������$	��120��5T      $��40q�5U      $��Center=�5X      $��Bottom=�5Y      $��12(�5Z      ��5[      Z� 5\      5^      