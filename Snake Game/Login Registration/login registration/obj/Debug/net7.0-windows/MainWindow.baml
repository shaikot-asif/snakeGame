   M S B A M L   `   `   `  ����@  <Snake, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:SnakeSnake  5   	       Snake.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Snake     5   	     � Title$  Snake��5	   	   $	��500��6   $	��800��6$   ���#191620$��Arial)�5   	    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � .+�5   
   �� $��Login��6   $��Center=�6!   $��28(�6>   $
��Bold"�6L   $��0,30,0,0q�6^   $	��Top=�6p   
������ 
�������6�   � 5   
   $��Center=�6   $��34��6,   $	��Top=�68   $	��524��6P   $��	0,134,0,0q�6\   .+�5      �� $��Username��6   $��20(�6'   $
��Left=�65   $��Center=�6P   
�������6k   � 5      $
��Left=�6   $��44��6.   $��	135,0,0,0q�6:   $��Center=�6M   .+�5      �� -   5         ��Name$ textUsername��5      $��Center=�60   $
��5,10q�6M   $	��390��6\   $��44��6h   $��16(�6t   $��Center=�6�    �� 	MaxLength$ 0��6�    �� MinLines$ 4��6�    �� TextWrapping$
 Wrap=�6�   
�������$��0,0,0,0q�6�   4  .System.Windows.Automation.AutomationProperties   IsColumnHeader$
 True��6�   5      5      � 5   
   $��Center=�6   $��34��6,   $	��Top=�68   $	��524��6P   $��	0,204,0,0q�6\   .+�5      �� $��Password��6   $��20(�6'   $
��Left=�65   $��Center=�6P   
�������6k   � 5      $
��Left=�6   $��44��6.   $��	135,0,0,0q�6:   $��Center=�6M   .+�5      �� -   5        $ textPassword��5      $��Center=�60   $
��5,10q�6M   $	��390��6\   $��44��6h   $��16(�6t   $��Center=�6�   $ 0��6�   $ 4��6�   $
 Wrap=�6�   
�������$��0,0,0,0q�6�    � 
InputScope$ Password��6�   5!      5#      �� 5$   
   -   5         ��Name$ 	formLogin��5$      $��Login��6%   $
��Left=�65   $��371,278,0,0q�6P   $	��Top=�6e   $��40,10,40,10q�6}   $
��True��6�   
����������	#FFFFDE00$��16(�6�   $��0,0,0,0q�6�   ���	#FF191620	 � UseLayoutRounding$
	 True��6"  
 � Cursor$

 Hand��6;  $
|�True��6a     MyButtonStyle#��[  6r  �� 5'   
   $��Don't Have Any Account?��6   $��Center=�63   $��20(�6P   $��Light"�6^   $��	0,362,0,0q�6q   $	��Top=�6�   
������ 
�������6�   �� 5)   
   -   5        $ btnBackToLogin��5)      $��CRETE ACCOUNT��6)   $
��Left=�6A   $��296,400,0,0q�6\   $	��Top=�6q   $

 Hand��6�   
�������$��37��6�   $	��194��6�   $��0,0,0,0q�6�    J� SnapsToDevicePixels$
 True��6�   $��20(�6�     MyClickHere#��[ 6"  ��5*      �� 5+       �� Color$ 	#FF707070��6"    �� Opacity$ 0Q�64   ��5-      �� 5.      $ 	#FF6F6F6F��6"   $ 0Q�64   50      53      54      