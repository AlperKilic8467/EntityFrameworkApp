   M S B A M L   `   `   `  ����E  AUppgift3UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Uppgift3UI
Uppgift3UI  5   	       Uppgift3UI.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Uppgift3UI     5   	     � Title$  Homes for sale��5   	   $	��450��6    $	��800��6-    � WindowStartupLocation$ CenterScreen=�69   .��5	      � .+�5
   
   �� -   5        $��
CategoryCB��5
      $
��Left=�6%   $��
575,66,0,0q�6@   $	��Top=�6T   $	��158��6l   6x   �� 5   
   -   5        $��TypeCB��5      $
��Left=�6!   $��575,107,0,0q�6<   $	��Top=�6Q   $	��158��6i   6u   �� 5   
   -   5        $��	CountryCB��5      $
��Left=�6$   $��575,150,0,0q�6?   $	��Top=�6T   $	��158��6l   �� 5   
   -   5        $��CityTB��5      $
��Left=�6    $��23��6;   $��575,194,0,0q�6G    �� TextWrapping$
 Wrap=�6\   $	��Top=�6p   $	��158��6�   �� 5   
   -   5        $��StreetTB��5      $
��Left=�6"   $��23��6=   $��575,231,0,0q�6I   $
 Wrap=�6^   $	��Top=�6r   $	��158��6�   �� 5   
   -   5        $��ZipTB��5      $
��Left=�6   $��23��6:   $��575,270,0,0q�6F   $
 Wrap=�6[   $	��Top=�6o   $	��158��6�    J� RenderTransformOrigin$ 0.507,5.604&�6�   �� 5   
   $
��Left=�6   $��
520,66,0,0q�6+   $	��Top=�6?   $ 1.718,-0.39&�6W   �� 5   
   $
��Type��6   $
��Left=�6   $��520,107,0,0q�6:   $	��Top=�6O   $ 1.718,-0.39&�6g   �� 5   
   $��Country��6   $
��Left=�6"   $��503,150,0,0q�6=   $	��Top=�6R   $ 1.718,-0.39&�6j   �� 5   
   $
��City��6   $
��Left=�6   $��520,191,0,0q�6:   $	��Top=�6O   $ 1.718,-0.39&�6g   �� 5   
   $��Street��6   $
��Left=�6!   $��509,231,0,0q�6<   $	��Top=�6Q   $ 1.718,-0.39&�6i   �� 5   
   $��Zip-Code��6   $
��Left=�6#   $��502,267,0,0q�6>   $	��Top=�6S   $ 1.718,-0.39&�6k   �� 5   
   $��Category��6   $
��Left=�6#   $��
503,66,0,0q�6>   $	��Top=�6R   $ 1.718,-0.39&�6j   �� 5   
   $��	Listings:��6   $
��Left=�6$   $��	36,40,0,0q�6?   $	��Top=�6R   $ 1.718,-0.39&�6j   �� 5   
   -   5        $��	DeleteBtn��5      $��Delete��6"   $
��Left=�63   $��
10,317,0,0q�6N   $	��Top=�6b   $��75��6z   6�   �� 5   
   -   5        $��	AddModBtn��5      $��Add Modification��6"   $
��Left=�6=   $��610,298,0,0q�6X   $	��Top=�6m   $��96��6�   $ 0.518,-1.043&�6�   �� 5   
   -	   5        $��AddBtn��5      $	��Add��6   $
��Left=�6-   $��562,389,0,0q�6H   $	��Top=�6]   $��75��6u   6�   �� 5   
   -
   5        $��	ModifyBtn��5      $��Modify��6"   $
��Left=�63   $��668,389,0,0q�6N   $	��Top=�6c   $��75��6{   6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��Datagrid��5      $
��Left=�6#   $	��236��6>   $��	10,76,0,0q�6K   $	��Top=�6^   $	��487��6v      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        ID��,  &System.Windows.Controls.DataGridColumn   Header$ ID��5   1      
Visibility$ Hidden=�6\   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *
BuildingID+6\     5       $ Category��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6O    67   �� *Cat+6O     5!      $
 Type��6%   $	 80 6L    63   �� *Type+6L     5"      $ Country��6%   $	 80 6Y    66   �� *Adress.Country+6Y     5#      $
 City��6%   $	 80 6S    63   �� *Adress.City+6S     5$      $ Street��6%   $	 80 6W    65   �� *Adress.Street+6W     5%      $ Zip-Code��6%   $	 * 6V    67   �� *
Adress.Zip+6V   5(      5*      5+      