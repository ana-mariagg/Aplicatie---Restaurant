   M S B A M L   `   `   `  ����K  GTema1-Restaurant, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Tema1_Restaurant.ViewsTema1_Restaurant.Views  5   	   I)clr-namespace:Tema1_Restaurant.ViewModelsTema1_Restaurant.ViewModels  5   	   1    +Tema1_Restaurant.Views.AddDiningTableWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:Tema1_Restaurant.Views     5   	   8vm)clr-namespace:Tema1_Restaurant.ViewModels     5   	   -   5          �Name$  CurrentWindow��5   	    � Title$ AddDiningTableWindow��5
   	   $	��450��6&   $	��800��63    � DataContext 5      8  2Tema1_Restaurant.ViewModels.AddDiningTableWindowVM  5   
   .��5      � .+�5   
   �� $��AddDiningTable��6   $
��Left=�6�   $��400,309,0,0q�6�   $	��Top=�6�   $��41��6�   $��96��6�   ��6*   �� *AddDiningTableCommand+��6T   ��  �� ElementName$ CurrentWindow��6�   �� 5   
   $
��Left=�6   $��372,172,0,0q�6-    �� TextWrapping$
 Wrap=�6B   $	��Top=�6s   $	��175��6�   $��19��6�   ��6V   �� *TableNumber+6�   �� 5   
   $
��Left=�6   $��371,129,0,0q�6-   $
 Wrap=�6B   $	��Top=�6r   $	��175��6�   $��19��6�   ��6V   �� *
EmployeeID+6�   �� 5   
   $
��Left=�6   $��371,254,0,0q�6-   $
 Wrap=�6B   $	��Top=�6u   $	��175��6�   $��19��6�   ��6V   �� *OccupiedSeats+6�   �� 5   
   $
��Left=�6   $��371,214,0,0q�6-   $
 Wrap=�6B   $	��Top=�6t   $	��176��6�   $��19��6�   ��6V   �� *AviableSeats+6�   �� 5   
   $3��-To add a new table, introduce its datas below��6   $��DemiBold"�6H   $��Center=�6^   $��20(�6�   $��Center=�6�   $��0,65,0,0q�6�   $	��Top=�6�   $��38��6�   $	��492��6�   �� 5   
   $��Employee's ID:��6   $��Italic$�6)   $��SemiBold"�6<   $��Center=�6R   $��15(�6v   $
��Left=�6�   $��247,124,0,0q�6�   $	��Top=�6�   �� 5   
   $��Table Number:��6   $��Italic$�6(   $��SemiBold"�6;   $��Center=�6Q   $��15(�6u   $
��Left=�6�   $��247,167,0,0q�6�   $	��Top=�6�   �� 5   
   $��Number of seats:��6   $��Italic$�6+   $��SemiBold"�6>   $��Center=�6T   $��15(�6x   $
��Left=�6�   $��247,209,0,0q�6�   $	��Top=�6�   �� 5   
   $��Occupied seats:��6   $��Italic$�6*   $��SemiBold"�6=   $��Center=�6S   $��15(�6w   $
��Left=�6�   $��247,249,0,0q�6�   $	��Top=�6�   ��5   
   �� 5       �� ImageSource$# D:\user\Pictures\employee.jpg��6    j� Stretch$ UniformToFill=�6E    �� Opacity$	 0.9Q�6]   5      5      