   M S B A M L   `   `   `  ����I  ESystemLotniczy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:SystemLotniczy.DodawanieSystemLotniczy.Dodawanie  5   	   /    )SystemLotniczy.Dodawanie.RejestracjaFirmy   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:SystemLotniczy.Dodawanie     5   	     � Title$  RejestracjaFirmy��5   	   $	��350��6"   $	��700��6/   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      $
��auto �6   �� 5      $	��150 �6   �� 5       � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��1��6   $��0��6    $��2��6-   $��Center=�6A   $��Center=�6^   $��24(�6y   $
��Bold"�6�   .��6�   Rejestracja Firmy6�   �� 5   
   $��1��6   $��1��6    .��6-   Nazwa firmy:6;   �� 5   
   $��1��6   $��2��6    .��6-   
Placówka:68   �� 5   
   $��1��6   $��3��6    .��6-   Login:65   �� 5   
   $��1��6   $��4��6    .��6-   	Password:68   �� 5   
   $��2��6   $��1��6"    �� 	MaxLength$ 20��6/   $��3,3,3,30q�6>   ��6P   �� *nazwa+ �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnDataErrors$
 True��.��6�    =� ErrorTemplate 5       �� 5!      .R�5"      �� .+�5#      �� �� 5$      
���  ����6$   �� *CurrentItem.ErrorContent+6N   5%      5&      .��5'   (   5(      �� 5)   
   $��2��6   $��2��6"   $ 20��6/   $��3,3,3,20q�6>   ��6P   �� *
placowka+$ PropertyChanged=�$
 True��.��6�    5*      �� 5+      .R�5,      �� .+�5-      �� �� 5.      
���  ����6$   �� *CurrentItem.ErrorContent+6N   5/      50      .��51   (   52      �� 53   
   $��2��6   $��3��6"   $ 20��6/   $��3,3,3,20q�6>   ��6P   �� *login+$ PropertyChanged=�$
 True��.��6�    54      �� 55      .R�56      �� .+�57      �� �� 58      
���  ����6$   �� *CurrentItem.ErrorContent+6N   59      5:      .��5;   (   5<      �� 5=   
   $��2��6   $��4��6"   $ 20��6/   $��3,3,3,20q�6>   ��6P   �� *
password+$ PropertyChanged=�$
 True��.��6�    5>      �� 5?      .R�5@      �� .+�5A      �� �� 5B      
���  ����6$   �� *CurrentItem.ErrorContent+6N   5C      5D      .��5E   (   5F      �� 5G   
   -   5        $��1��5G      $��5��6!   $��2��6.   $��30��6B   $	��120��6N   .��6n   Zarejestruj firmę6�   5H      5I      