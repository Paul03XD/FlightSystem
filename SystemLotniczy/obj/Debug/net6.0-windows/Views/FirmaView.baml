   M S B A M L   `   `   `  ����I  ESystemLotniczy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:SystemLotniczy.WidokiSystemLotniczy.Widoki  5   	   %    SystemLotniczy.Widoki.FirmaView   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:SystemLotniczy.Widoki     5   	     � Title$  	FirmaView��5   	   $	��450��6   $	��800��6(   .��5	      ]� .+�5
   
   ��  �� Orientation$ 
Horizontal=�6   $	��Top=�6.   .+�5      �� -   5        $	��120��5      $��30��6"   $��10q�6.   .��6J   	Wyloguj6S   �� 5      -   5         ��Name$ zalogowanyJako��5   e   $��Right=�6   $��Center=�67   $��10q�6Y   .��6}   Zalogowany jako:6�   5      �� 5   
   .@�5      �� $��Lista Pracowników��6   .��5      ]� .+�5      �� $ 
Horizontal=�6!   $	��Top=�6:   .+�5      �� -   5        $��10q�5   !   $	��120��6-   $��30��69   .��6^   Dodaj pracownika6p   5      &   System.Windows.Controls.DataGrid  5      -   5          Name$ gridPracownicy��5         AutoGenerateColumns$ False��67      CanUserAddRows$ False��6S      CanUserDeleteRows$ False��6j      
IsReadOnly$
 True��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Imię��61   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6?   �� *imie+  5      $	 Nazwisko��61   
 6C   �� *
nazwisko+  5      $
	 Wiek��61   
 6?   �� *wiek+  5       $	 Adres��61   
 6@   �� *adres+  5!      $	 Nr.tel��61   
 6A   �� *nr_tel+  5"      $	 E-mail��61   
 6A   �� *email+5$      5%      5&      �� 5'      $��Loty Pracowników��6   .��5(      ]� .+�5)      �� $ 
Horizontal=�6!   $	��Top=�6:   .+�5*      �� -   5        $��10q�5*   !   $��30��6-   $	��120��69   .��6W   	Kup Bilet6b   5+        5,      -   5        $ gridRezerwacje��5,      $ False��67   $ False��6S   $ False��6j   $
 True��6�    5-        5.      $	 Klient��61   
 6A   �� *klient+  5/      $	 Skąd��61   
 6?   �� *nazwa_lotniska+  50      $	 Dokąd��61   
 6@   �� *nazwa_trasy+  51      $	 Dystans��61   
 6B   �� *	dystans+  52      $	 Data odlotu��61   
 6F   �� *data_odlotu+ �� StringFormat$ d��  53      $	 Samolot��61   
 6B   �� *nazwa_samolotu+  54      $
	 Cena��61   
 6?   �� *cena+56      57      58      59      5:      5;      