   M S B A M L   `   `   `  ����I  ESystemLotniczy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:SystemLotniczySystemLotniczy  5   	       SystemLotniczy.AdminView   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:SystemLotniczy     5   	     � Title$  	AdminView��5   	   $	��450��6   $	��800��6(   .��5
      �� .@�5   
   �� $
��Menu��6   .��5      �  � ColumnDefinitions 5      �� 5      $
��auto �6'   �� 5       � RowDefinitions 5      �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5      $
��auto �6$   .+�5      �� -   5        $��0��5      $��30��6&   $	��150��62   $��10q�6>   .��6\   	Dodaj lot6g   �� 5      $��1��6   $��30��6&   $	��150��62   $��10q�6>   .��6J   Dodaj lotnisko6Z   �� 5      $��2��6   $��30��6&   $	��150��62   $��10q�6>   .��6J   Zarządzaj samolotami6`   �� 5      $��3��6   $��30��6&   $	��150��62   $��10q�6>   .��6J   Zarządzaj lotami6\   5      5      �� 5   
   $��Klienci��6   .��5      &   System.Windows.Controls.DataGrid  -   5          Name$ gridKlienci��5         AutoGenerateColumns$ False��6,      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn   Header$ Imię��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *imie+  5!      $ Nazwisko��6)    6;   �� *
nazwisko+  5"      $
 Wiek��6)    67   �� *wiek+  5#      $ Adres��6)    68   �� *adres+  5$      $ Telefon��6)    6:   �� *nr_tel+  5%      $ E-mail��6)    69   �� *email+  5&      $ Firma��6)    68   �� *
id_firmy+5(      5)      �� 5*   
   $��Firmy��6   .��5+        -   5        $ 	gridFirmy��5+      $ False��6*    5,        5-      $ Nazwa��6)    68   �� *nazwa+  5.      $ Placowka��6)    6;   �� *
placowka+50      51      �� 52   
   $��Samoloty��6   .��53        -   5        $ gridSamoloty��53      $ False��6-    54        55      $ Nazwa��6)    68   �� *nazwa+  56      $ Pojemność��6)    6<   �� *
l_miejsc+58      59      �� 5:   
   $
��Loty��6   .��5;        -   5        $ gridLoty��5;      $ False��6)    5<        5=      $ Samolot��6)    6:   �� *id_samolotu+  5>      $ Dokąd��6)    68   �� *
id_trasy+  5?      $ Data odlotu��6)    6>   �� *data_odlotu+ �� StringFormat$ d��5A      5B      �� 5C   
   $��
Rezerwacje��6   .��5D        -   5        $ gridRezerwacje��5D      $ False��6/    5E        5F      $ Klient��6)    69   �� *
id_klienta+  5G      $	 Lot��6)    66   �� *	id_lotu+  5H      $
 Cena��6)    67   �� *cena+5J      5K      5L      5M      