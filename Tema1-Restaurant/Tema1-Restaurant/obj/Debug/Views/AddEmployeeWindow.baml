   M S B A M L   `   `   `  ����K  GTema1-Restaurant, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Tema1_Restaurant.ViewsTema1_Restaurant.Views  5   	   I)clr-namespace:Tema1_Restaurant.ViewModelsTema1_Restaurant.ViewModels  5   	   .    (Tema1_Restaurant.Views.AddEmployeeWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:Tema1_Restaurant.Views     5   	   8vm)clr-namespace:Tema1_Restaurant.ViewModels     5   	   -   5          �Name$  CurrentWindow��5   	    � Title$ AddEmployeeWindow��5
   	   $	��450��6#   $	��800��60    � DataContext 5      5  /Tema1_Restaurant.ViewModels.AddEmployeeWindowVM  5   
   .��5      � .+�5   
   �� $��AddEmployee��6   $
��Left=�6�   $��386,267,0,0q�6�   $	��Top=�6�   $��41��6�   $��96��6�   ��6'   �� *AddEmployeeCommand+��6N   ��  �� ElementName$ CurrentWindow��6�   �� 5   
   $
��Left=�6   $��346,219,0,0q�6-    �� TextWrapping$
 Wrap=�6B   $	��Top=�6n   $	��175��6�   $��25��6�   ��6V   �� *UserID+6�   �� 5   
   $
��Left=�6   $��346,171,0,0q�6-   $
 Wrap=�6B   $	��Top=�6p   $	��176��6�   $��25��6�   ��6V   �� *
LastName+6�   �� 5   
   $
��Left=�6   $
 Wrap=�6-   $	��Top=�6\   $	��176��6t   $��25��6�   $��346,127,0,0q�6�   ��6A   �� *	FirstName+6�   �� 5   
   $?��9To add a new employee, introduce his personal datas below��6   $��DemiBold"�6T   $��Center=�6j   $��19(�6�   $��Center=�6�   $��0,66,0,0q�6�   $	��Top=�6�   $��38��6�   $	��529��6�   �� 5   
   $��First Name:��6   $��Italic$�6&   $��SemiBold"�69   $��Center=�6O   $��15(�6s   $
��Left=�6�   $��254,125,0,0q�6�   $	��Top=�6�   �� 5   
   $��
Last Name:��6   $��Italic$�6%   $��SemiBold"�68   $��Center=�6N   $��15(�6r   $
��Left=�6�   $��255,169,0,0q�6�   $	��Top=�6�   �� 5   
   $��UserID:��6   $��Italic$�6"   $��SemiBold"�65   $��Center=�6K   $��15(�6o   $
��Left=�6}   $��254,217,0,0q�6�   $	��Top=�6�   ��5   
   �� 5       �� ImageSource$# D:\user\Pictures\employee.jpg��6    j� Stretch$ UniformToFill=�6E    �� Opacity$	 0.9Q�6]   5      5      