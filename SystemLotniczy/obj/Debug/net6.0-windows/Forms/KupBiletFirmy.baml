   M S B A M L   `   `   `  ����I  ESystemLotniczy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:SystemLotniczy.ViewsSystemLotniczy.Views  5   	   (    "SystemLotniczy.Views.KupBiletFirmy   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:SystemLotniczy.Views     5   	     � Title$  KupBiletFirmy��5   	   $	��450��6   $	��800��6,   .��5
      ]� .+�5   
   �� $	��Top=�6   .+�5      �� -   5        $��Right=�5      $	��120��61   $��30��6=   $��10q�6I   .��6e   	Zamknij6n   5      � 5   
   -   5         �Name$ 
ticketGrid��5   $   $	��Top=�6   $y�	Collapsed=�68    � ColumnDefinitions 5      �� 5      $
��auto �6#   �� 5      �� 5      $	��150 �6#    � RowDefinitions 5      �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    .+�5      �� $��0��6   $��0��6$   .��61   	Lot do:6:   �� 5      $��0��6   $��1��6$   .��61   Z lotniska:6>   �� 5      $��0��6   $��2��6$   .��61   Wylot:69   �� 5      $��0��6   $��3��6$   .��61   
Dystans:6;   �� 5       $��0��6   $��4��6$   .��61   Cena:68   �� 5!      -   5         ��Name$ trasaTxt��5!   1   $��1��6   $��0��6$   6E   �� 5"      -   5        $ lotniskoTxt��5"   1   $��1��6   $��1��6$   6H   �� 5#      -   5        $ dataWylotuTxt��5#   1   $��1��6   $��2��6$   6J   �� 5$      -   5        $ 
dystatsTxt��5$   1   $��1��6   $��3��6$   6G   �� 5%      -   5        $ cenaTxt��5%   1   $��1��6   $��4��6$   6D   �� 5&      -   5        $ idTxt��5&   1   $��2��6   $��0��6$   $y�	Collapsed=�6@   6Y   �� 5'      -	   5        $ iloscMiejscTxt��5'   1   $��2��6   $��1��6$   $y�	Collapsed=�6I   6b   �� 5(      -
   5        $��2��5(      $��4��6%   $	��120��6C   $��30��6O   $��10q�6[   .��6g   Kup6l   5)      &   System.Windows.Controls.DataGrid  5*   
   -   5          Name$ gridLoty��5*         AutoGenerateColumns$ False��6%      CanUserAddRows$ False��6A      CanUserDeleteRows$ False��6X   	   
IsReadOnly$
	 True��6r   
   RowStyle
 5+      �� 5,       �� 
TargetType)  #System.Windows.Controls.DataGridRow"  6   .�5-      -   5        5/         Columns 51      0  *System.Windows.Controls.DataGridTextColumn  52      ,  &System.Windows.Controls.DataGridColumn   Header$ Samolot��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *nazwa_samolotu+  53      $ Skąd��6%    63   �� *nazwa_lotniska+  54      $ Dokąd��6%    64   �� *nazwa_trasy+  55      $ Dystans��6%    66   �� *	dystans+  56      $ id_lotu��6%      
Visibility$ 	Collapsed=�66    6M   �� *	id_lotu+  57      $ ilosc_wolnych_miejsc��6%   $ 	Collapsed=�6C    6[   �� *ilosc_wolnych_miejsc+  58      $ Data odlotu��6%    6:   �� *data_odlotu+ �� StringFormat$ d��5:      5;      5<      