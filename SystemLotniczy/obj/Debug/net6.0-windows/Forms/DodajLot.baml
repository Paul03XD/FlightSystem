   M S B A M L   `   `   `  ����I  ESystemLotniczy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:SystemLotniczySystemLotniczy  5   	       SystemLotniczy.DodajLot   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:SystemLotniczy     5   	     � Title$  	Dodaj lot��5   	   $	��350��6   $	��300��6(   .��5	      � $��Center=�6    � ColumnDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6   $��0��6    $��30��6-   $��10q�69   $��Center=�6E   .��6g   	Lotnisko:6r   �� 5   
   $��0��6   $��1��6    $��30��6-   $��10q�69   $��Center=�6E   .��6g   
Samolot:6q   �� 5   
   $��0��6   $��2��6    $��30��6-   $��10q�69   $��Center=�6E   .��6g   	Dokąd:6o   �� 5   
   $��0��6   $��3��6    $��30��6-   $��10q�69   $��Center=�6E   .��6g   
Dystans:6q   �� 5   
   $��0��6   $��4��6    $��30��6-   $��10q�69   $��Center=�6E   .��6g   Data odlotu:6u   �� 5   
   -   5         ��Name$ lotniskoCmbBox��5   j   $��1��6   $��0��6#   $��30��60   $��10q�6<   $��Center=�6H    �� Text 6�   �� *nazwa_lotniska+ �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnDataErrors$
 True�� =� ErrorTemplate 5      �� 5      .R�5      �� .+�5       �� �� 5!      
���  ����6$   �� *CurrentItem.ErrorContent+6N   5"      5#      5%      �� 5&   
   -   5        $ samolotCmbBox��5&   k   $��1��6   $��1��6#   $��30��60   $��10q�6<   $��Center=�6H    6�   �� *nazwa_samolotu+$ PropertyChanged=�$
 True�� 5'      �� 5(      .R�5)      �� .+�5*      �� �� 5+      
���  ����6$   �� *CurrentItem.ErrorContent+6N   5,      5-      5/      �� 50   
   -   5        $ miastoCmbBox��50   k   $��1��6   $��2��6#   $��30��60   $��10q�6<   $��Center=�6H    6�   �� *nazwa_trasy+$ PropertyChanged=�$
 True�� 51      �� 52      .R�53      �� .+�54      �� �� 55      
���  ����6$   �� *CurrentItem.ErrorContent+6N   56      57      59      �� 5;   
   -   5         ��Name$ dystansTxtBox��5;   u   $��1��6   $��3��6"   $	��150��6/   $��30��6;   $��10q�6G   $��Center=�6S   ��6�   �� *	dystans+$ PropertyChanged=�$
 True��	 �� StringFormat$	  ��.��6�    5<      �� 5=      .R�5>      �� .+�5?      �� �� 5@      
���  ����6$   �� *CurrentItem.ErrorContent+6N   5A      5B      .��5C   (   5D      (  "System.Windows.Controls.DatePicker  5E   
   -   5        
  Name$
 data_odlotu_DatePicker��5E   V   $��1��6   $��4��6%   $	��150��62   $��30��6>   $��10q�6J   $��Center=�6v      Text 6�   �� *data_odlotu+$ PropertyChanged=�$
 True�� 5F      �� 5G      .R�5H      �� .+�5I      �� �� 5J      
���  ����6$   �� *CurrentItem.ErrorContent+6N   5K      5L      5N      �� 5P   
   -   5        $��0��5P      $��2��6!   $��5��65   $	��150��6B   $��30��6N   $��10q�6Z   .��6x   	Dodaj lot6�   5Q      5R      