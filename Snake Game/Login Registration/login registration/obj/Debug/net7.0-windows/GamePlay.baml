   M S B A M L   `   `   `  ����@  <Snake, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:SnakeSnake  5   	       Snake.GamePlay   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Snake     5   	   -   5          � Title$  Snake��5   	   $	��500��6   $	��800��6$   $	��300��5	   	   $	��300��5
   	      BackgroundColor#��[  5   	     	TextColor#��[ 5   	     MainFont#��[ 5   	    � WindowStartupLocation$ CenterScreen=�5   	   .��5      (� .��5   
   �  � RowDefinitions 5      �� 5      $
��auto �6    �� 5      $��* �6    .+�5      �� -   5         ��Name$ 	ScoreText��5      $
��Left=�5      $��Center=�5      $��SCORE: 0��5      $��25(�5      $��10q�5       �� 5!      -   5         ��Name$ 
GridBorder��5!      $��1��5"        GridLineColor#��[ 5#      $	��1.5q�5%      $��Center=�5&      $��Center=�5'       �� EdgeMode$ Aliased=�5(      $��
20,0,20,20q�5)      ._�5+      A� -   5         A�Name$ GameGrid��5+      $	��400��5,      $	��400��5-        GridBackgroundColor#��[ 5.       J� SnapsToDevicePixels$
 True��5/       �� BitmapScalingMode$ HighQuality=�50      51      �� 53      -   5        $ Overlay��53      $��1��54        OverlayColor#��[ 55      $ Aliased=�59      ��56      �� 	 �� Path$	 ActualWidth�
 �� ElementName$
 
GridBorder����57      �� $	 ActualHeight�$
 
GridBorder����58      �� $	 Margin�$
 
GridBorder��._�5:      �� -   5        $ OverlayText��5:      $%��Press Any Key To Start The Game��5;      $��20(�5<      $��Center=�5=      $��Center=�5>      $
��Wrap=�5?      5A      �� 5B      -   5        $��BACK TO MAIN MENU��5B        MyClickHere#��[ 61   $��2,2,2,2q�6V   $��	215,0,0,0q�6h   $��Center=�6{   
�������$��20(�6�   $
��Left=�6�    � Cursor$
 Hand��6  ��6�   Z� ��6�   Z� 6  5D      5E      5F      