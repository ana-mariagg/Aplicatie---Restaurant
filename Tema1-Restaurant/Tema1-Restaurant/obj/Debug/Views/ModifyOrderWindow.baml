   M S B A M L   `   `   `  ����K  GTema1-Restaurant, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Tema1_Restaurant.ViewsTema1_Restaurant.Views  5   	   I)clr-namespace:Tema1_Restaurant.ViewModelsTema1_Restaurant.ViewModels  5   	   .    (Tema1_Restaurant.Views.ModifyOrderWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:Tema1_Restaurant.Views     5   	   8vm)clr-namespace:Tema1_Restaurant.ViewModels     5   	   -   5          �Name$  CurrentWindow��5   	    � Title$ ModifyOrderWindow��5
   	   $	��450��6#   $	��800��60    � DataContext 5      6  0Tema1_Restaurant.ViewModels.ModifyOrdersWindowVM  5   
   .��5      � .+�5   
   �� $��Modify Product��6   $
��Left=�6�   $��400,302,0,0q�6�   $	��Top=�6�   $��41��6�   $��96��6�   ��6*   �� *ModifyOrderCommand+��6Q   ��  �� ElementName$ CurrentWindow��6�   �� 5   
   $
��Left=�6   $��	356,0,0,0q�6-    �� TextWrapping$
 Wrap=�6@   $��Center=�6o   $	��175��6�   $��22��6�   ��6T   �� *	TotalCost+6�   �� 5   
   $
��Left=�6   $��357,161,0,0q�6-   $
 Wrap=�6B   $	��Top=�6n   $	��175��6�   $��22��6�   ��6V   �� *Status+6�   �� 5   
   $
��Left=�6   $��356,113,0,0q�6-   $
 Wrap=�6B   $	��Top=�6o   $	��176��6�   $��22��6�   ��6V   �� *	TableID+6�   �� 5   
   $3��-To modify an order, introduce its datas below��6   $��DemiBold"�6H   $��Center=�6^   $��23(�6�   $��Center=�6�   $��0,38,0,0q�6�   $	��Top=�6�   $��38��6�   $	��528��6�   �� 5   
   $��Table's ID:��6   $��Italic$�6&   $��SemiBold"�69   $��Center=�6O   $��15(�6s   $
��Left=�6�   $��245,109,0,0q�6�   $	��Top=�6�   �� 5   
   $��Status:��6   $��Italic$�6"   $��SemiBold"�65   $��Center=�6K   $��15(�6o   $
��Left=�6}   $��245,157,0,0q�6�   $	��Top=�6�   �� 5   
   $��Total cost:��6   $��Italic$�6&   $��SemiBold"�69   $��Center=�6O   $��15(�6s   $
��Left=�6�   $��	245,0,0,0q�6�   $��Center=�6�   �� 5   
   $��Order's date:��6   $��Italic$�6(   $��SemiBold"�6;   $��Center=�6Q   $��15(�6u   $
��Left=�6�   $��245,245,0,0q�6�   $	��Top=�6�   (  "System.Windows.Controls.DatePicker  5   
   $
��Left=�6   $��357,248,0,0q�6S   $	��Top=�6h      SelectedDate 60   �� *	OrderTime+6h   ��5   
   �� 5       �� ImageSource$# D:\user\Pictures\employee.jpg��6    j� Stretch$ UniformToFill=�6E    �� Opacity$	 0.9Q�6]   5      5      