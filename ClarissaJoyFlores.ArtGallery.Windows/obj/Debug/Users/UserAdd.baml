   M S B A M L   `   `   `  ����_  [ClarissaJoyFlores.ArtGallery.Windows, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullg8clr-namespace:ClarissaJoyFlores.ArtGallery.Windows.Users*ClarissaJoyFlores.ArtGallery.Windows.Users  5   	   8    2ClarissaJoyFlores.ArtGallery.Windows.Users.UserAdd   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Jlocal8clr-namespace:ClarissaJoyFlores.ArtGallery.Windows.Users     5   	     � Title$  UserAdd��5   	   $	��450��6   $	��800��6&   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��67* �6   �� 5      �� 5      $
��725* �6   .+�5   
   �� $��Add new User��6   $
��Left=�6'   $��32��6B   $��	46,10,0,0q�6N   $	��Top=�6a   $	��162��6y   $��3��6�   �� 5   
   $��
First Name��6   $
��Left=�6%   $��27��6@   $��	46,73,0,0q�6L   $	��Top=�6_   $	��108��6w   $��3��6�   �� 5   
   $��	Last Name��6   $
��Left=�6$   $��29��6?   $��
46,115,0,0q�6K   $	��Top=�6_   $	��136��6w   $��3��6�   �� 5   
   $��Address��6   $
��Left=�6"   $��29��6=   $��
46,159,0,0q�6I   $	��Top=�6]   $	��153��6u   $��3��6�   �� 5   
   $	��Sex��6   $
��Left=�6   $��29��6:   $��
46,204,0,0q�6F   $	��Top=�6Z   $	��153��6r   $��3��6~   �� 5   
   -   5         ��Name$ txtFirstName��5      $
��Left=�6(   $��24��6C   $��
141,73,0,0q�6O    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��152��6�   $��2��6�   �� 5   
   -   5        $ txtLastName��5      $
��Left=�6'   $��24��6B   $��141,115,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��152��6�   $��2��6�   �� 5   
   -   5        $ 
txtAddress��5      $
��Left=�6&   $��24��6A   $��141,159,0,0q�6M   $
 Wrap=�6b   $	��Top=�6v   $	��152��6�   $��2��6�   �� 5   
   -   5        $ txtSex��5      $
��Left=�6"   $��24��6=   $��141,198,0,0q�6I   $
 Wrap=�6^   $	��Top=�6r   $	��152��6�   $��2��6�   �� 5   
   -   5         ��Name$ 	btnCancel��5      $��Cancel��6$   $
��Left=�65   $��26��6P   $��252,383,0,0q�6\   $	��Top=�6q   $��99��6�   $��2��6�   �� 5   
   -   5        $ btnAdd��5      $	��Add��6!   $
��Left=�6/   $��26��6J   $��396,383,0,0q�6V   $	��Top=�6k   $��99��6�   $��2��6�   �� 5   
   $��Email��6   $
��Left=�6!   $��29��6<   $��
46,291,0,0q�6H   $	��Top=�6\   $	��153��6t   $��3��6�   �� 5   
   -   5        $ txtEmail��5      $
��Left=�6$   $��24��6?   $��141,285,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��152��6�   $��2��6�   �� 5   
   $��Contact-Number��6   $
��Left=�6*   $��29��6E   $��
46,243,0,0q�6Q   $	��Top=�6e   $	��153��6}   $��3��6�   �� 5   
   -   5        $ txtContactNumber��5      $
��Left=�6,   $��24��6G   $��141,243,0,0q�6S   $
 Wrap=�6h   $	��Top=�6|   $	��152��6�   $��2��6�   �� 5   
   $��Password��6   $
��Left=�6$   $��29��6?   $��
46,328,0,0q�6K   $	��Top=�6_   $	��153��6w   $��3��6�   �� 5   
   -	   5        $ txtPassword��5      $
��Left=�6'   $��24��6B   $��141,328,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��152��6�   $��2��6�   �� 5    
   -
   5         ��Name$ txtError��5       $��2��6&   $
��Left=�66   $��
335,73,0,0q�6Q   $
��Wrap=�6e   $	��Top=�6y   $��66��6�   $	��367��6�   5!      5"      