   M S B A M L   `   `   `  ����_  [ClarissaJoyFlores.ArtGallery.Windows, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullg8clr-namespace:ClarissaJoyFlores.ArtGallery.Windows.Users*ClarissaJoyFlores.ArtGallery.Windows.Users  5   	   5    /ClarissaJoyFlores.ArtGallery.Windows.Users.List   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Jlocal8clr-namespace:ClarissaJoyFlores.ArtGallery.Windows.Users     5   	     � Title$
  List��5   	   $	��450��6   $	��800��6#   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgUsers��5
      $
��Left=�6$   $	��214��6?   $��
46,102,0,0q�6L   $	��Top=�6`   $	��704��6x      AutoGenerateColumns .     CanUserAddRows .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	FirstName��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 5   3   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6   �� *	FirstName+63     5      $ LastName��6%   $ * 5   2    6   �� *
LastName+62     5      $ Address��6%   $ * 5   1    6   �� *	Address+61     5      $	 Sex��6%   $ * 5   -    6   �� *Sex+6-     5      $ ContactNumber��6%   $ * 5   7    6   �� *ContactNumber+67     5      $ Email��6%   $ * 5   /    6   �� *Email+6/     5      $ Password��6%   $ * 5   2    6   �� *
Password+62   4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate 5      �� 5      .R�5      �� 	 ��Name$	 	btnUpdate��6%   -   5        $��Update��5   P   5      5         5!       5"      �� 5#      .R�5$      �� $	 	btnDelete��6%   -   5        $��Delete��5$   P   5%      5'        5(       5)      �� 5*      .R�5+      �� $	 btnDeactivate��6%   -   5        $��
Deactivate��5+   X   5,      5.      51      �� 52   
   -   5        
 ��Name$
 cboSortOrder��52      $
��Left=�6)   $��
629,34,0,0q�6D   $	��Top=�6X   $	��120��6p   6|   �� 53   
   -   5         ��Name$ lblSortOrder��53      $��
Sort Order��6&   $
��Left=�6;   $��29��6V   $��
537,34,0,0q�6b   $	��Top=�6v   $��87��6�    J� RenderTransformOrigin$ 0.783,0.576&�6�   �� 54   
   -   5        $
 	cboSortBy��54      $
��Left=�6&   $��
407,34,0,0q�6A   $	��Top=�6U   $	��120��6m   6y   �� 55   
   -   5        $ 	lblSortBy��55      $��Sort By��6#   $
��Left=�65   $��29��6P   $��
315,34,0,0q�6\   $	��Top=�6p   $��87��6�   $ 0.783,0.576&�6�   �� 56   
   -	   5        $	 btnFirst��56      $��First��6#   $
��Left=�63   $	��Top=�6N   $��75��6f   $��18��6q   $��
46,340,0,0q�6}   6�   �� 57   
   -
   5        $	 btnLast��57      $
��Last��6"   $
��Left=�61   $	��Top=�6L   $��75��6d   $��18��6o   $��286,340,0,0q�6{   6�   �� 58   
   -   5        $	 btnNext��58      $
��Next��6"   $
��Left=�61   $	��Top=�6L   $��75��6d   $��18��6o   $��206,340,0,0q�6{   $ 0.615,2.311&�6�   6�   �� 59   
   -   5        $	 btnPrevious��59      $��Previous��6&   $
��Left=�69   $	��Top=�6T   $��75��6l   $��18��6w   $��126,340,0,0q�6�   6�   �� 5:   
   -   5         ��Name$ txtPageSize��5:      $��5��6'   $
��Left=�60   $��23��6K    �� TextWrapping$
 Wrap=�6W   $	��Top=�6k   $��75��6�   $��126,363,0,0q�6�   6�   �� 5;   
   -   5        $ lblPageSize��5;      $��	Page Size��6%   $
��Left=�69   $	��Top=�6T   $��
46,363,0,0q�6l   �� 5<   
   -   5        $ 
lblFilters��5<      $��Filters��6$   $
��Left=�66   $��29��6Q   $��	46,68,0,0q�6]   $	��Top=�6p   $��87��6�   $ 0.783,0.576&�6�   �� 5=   
   -   5        $ 
txtKeyword��5=      $
��Left=�6&   $��23��6A   $��
100,67,0,0q�6M   $
 Wrap=�6a   $	��Top=�6u   $	��648��6�   6�   �� 5>   
   -   5        $	 btnAdd��5>      $��Add New��6!   $
��Left=�63   $	��Top=�6N   $��75��6f   $��18��6q   $��673,340,0,0q�6}   6�   �� 5?   
   -   5        $	 	btnArtist��5?      $��List Artist��6$   $
��Left=�6:   $	��Top=�6U   $��75��6m   $��18��6x   $��	46,19,0,0q�6�   6�   �� 5@   
   -   5        $	 
btnArtwork��5@      $��List Artwork��6%   $
��Left=�6<   $	��Top=�6W   $��75��6o   $��18��6z   $��
138,19,0,0q�6�   $ 0.5,0.5&�6�   z�5A      V� 5B      .~�5C      �� �� 5D      �� 5E       �� Angle$ 0.092Q�6&   T� 5F      5G      5I      5K      5L      