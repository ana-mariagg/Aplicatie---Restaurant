   M S B A M L   `   `   `  ����K  GTema1-Restaurant, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Tema1_Restaurant.ViewsTema1_Restaurant.Views  5   	   I)clr-namespace:Tema1_Restaurant.ViewModelsTema1_Restaurant.ViewModels  5   	   0    *Tema1_Restaurant.Views.ModifyProductWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:Tema1_Restaurant.Views     5   	   8vm)clr-namespace:Tema1_Restaurant.ViewModels     5   	   -   5          �Name$  CurrentWindow��5   	    � Title$ ModifyProductWindow��5
   	   $	��450��6%   $	��800��62    � DataContext 5      7  1Tema1_Restaurant.ViewModels.ModifyProductWindowVM  5   
   .��5      � .+�5   
   �� $��
AddProduct��6   $
��Left=�6�   $��400,291,0,0q�6�   $	��Top=�6�   $��41��6�   $��96��6�   ��6&   �� *ModifyProductCommand+��6O   ��  �� ElementName$ CurrentWindow��6�   �� 5   
   $
��Left=�6   $��366,221,0,0q�6-    �� TextWrapping$
 Wrap=�6B   $	��Top=�6x   $	��175��6�   $��22��6�   ��6V   �� *ProductIsAviable+6�   �� 5   
   $
��Left=�6   $��367,176,0,0q�6-   $
 Wrap=�6B   $	��Top=�6t   $	��175��6�   $��22��6�   ��6V   �� *ProductPrice+6�   �� 5   
   $
��Left=�6   $��366,128,0,0q�6-   $
 Wrap=�6B   $	��Top=�6s   $	��176��6�   $��22��6�   ��6V   �� *ProductName+6�   �� 5   
   $8��2To modify a product, introduce its new datas below��6   $��DemiBold"�6M   $��Center=�6c   $��23(�6�   $��Center=�6�   $��0,48,0,0q�6�   $	��Top=�6�   $��38��6�   $	��553��6�   �� 5   
   $��Product's Name:��6   $��Italic$�6*   $��SemiBold"�6=   $��Center=�6S   $��15(�6w   $
��Left=�6�   $��233,124,0,0q�6�   $	��Top=�6�   �� 5   
   $��Product's Price:��6   $��Italic$�6+   $��SemiBold"�6>   $��Center=�6T   $��15(�6x   $
��Left=�6�   $��237,172,0,0q�6�   $	��Top=�6�   �� 5   
   $��Is Aviable:��6   $��Italic$�6&   $��SemiBold"�69   $��Center=�6O   $��15(�6s   $
��Left=�6�   $��237,217,0,0q�6�   $	��Top=�6�   ��5   
   �� 5       �� ImageSource$# D:\user\Pictures\employee.jpg��6    j� Stretch$ UniformToFill=�6E    �� Opacity$	 0.9Q�6]   5      5      