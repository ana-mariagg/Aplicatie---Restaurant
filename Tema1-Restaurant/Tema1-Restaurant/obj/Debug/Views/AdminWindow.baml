   M S B A M L   `   `   `  ����K  GTema1-Restaurant, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Tema1_Restaurant.ViewsTema1_Restaurant.Views  5   	   I)clr-namespace:Tema1_Restaurant.ViewModelsTema1_Restaurant.ViewModels  5   	   (    "Tema1_Restaurant.Views.AdminWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:Tema1_Restaurant.Views     5   	   8vm)clr-namespace:Tema1_Restaurant.ViewModels     5   	   -   5          �Name$  CurrentWindow��5   	    � Title$ AdminWindow��5
   	   $	��482��6   $	��809��6*    � DataContext 5      /  )Tema1_Restaurant.ViewModels.AdminWindowVM  5   
   .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��0,0,200,202q�5   \   ��6   �� *CurrentList+ �� SelectedItem 67   �� *CurrentItem+6q   �� 5   
   $��View Employees��6   $
��Left=�6S   $��107,279,0,0q�6n   $	��Top=�6�   $��25��6�   $	��118��6�    J� RenderTransformOrigin$ 0.288,0.761&�6�   ��6*   �� *ViewEmployeesCommand+6�   �� 5   
   $��Add Employees��6   $
��Left=�6Q   $��107,325,0,0q�6l   $	��Top=�6�   $��25��6�   $	��118��6�   ��6)   �� *AddEmployeesCommand+6�   �� 5   
   $��Modify Employees��6   $
��Left=�6W   $��107,368,0,0q�6r   $	��Top=�6�   $��25��6�   $	��118��6�   ��6,   �� *ModifyEmployeesCommand+6�   �� 5   
   $��Delete Employees��6   $
��Left=�6W   $��107,407,0,0q�6r   $	��Top=�6�   $��25��6�   $	��118��6�   ��6,   �� *DeleteEmployeesCommand+6�   �� 5   
   $��View Products��6   $
��Left=�6Q   $��252,279,0,0q�6l   $	��Top=�6�   $��25��6�   $	��118��6�   ��6)   �� *ViewProductsCommand+6�   �� 5   
   $��Add Products��6   $
��Left=�6O   $��252,325,0,0q�6j   $	��Top=�6   $��25��6�   $	��118��6�   ��6(   �� *AddProductsCommand+6�   �� 5   
   $��Modify Products��6   $
��Left=�6T   $��252,368,0,0q�6o   $	��Top=�6�   $��25��6�   $	��118��6�   ��6+   �� *ModifyProductCommand+6�   �� 5   
   $��Delete Products��6   $
��Left=�6U   $��252,407,0,0q�6p   $	��Top=�6�   $��25��6�   $	��118��6�   ��6+   �� *DeleteProductsCommand+6�   �� 5   
   $��View Tables��6   $
��Left=�6S   $��397,279,0,0q�6n   $	��Top=�6�   $��25��6�   $	��118��6�   ��6'   �� *ViewDiningTablesCommand+6�   �� 5   
   $��
Add Tables��6   $
��Left=�6Q   $��397,325,0,0q�6l   $	��Top=�6�   $��25��6�   $	��118��6�   ��6&   �� *AddDiningTablesCommand+6�   �� 5   
   $��Modify Tables��6   $
��Left=�6W   $��397,368,0,0q�6r   $	��Top=�6�   $��25��6�   $	��118��6�   ��6)   �� *ModifyDiningTablesCommand+6�   �� 5   
   $��Delete Tables��6   $
��Left=�6W   $��397,407,0,0q�6r   $	��Top=�6�   $��25��6�   $	��118��6�   ��6)   �� *DeleteDiningTablesCommand+6�   �� 5    
   $��View Orders��6   $
��Left=�6M   $��542,279,0,0q�6h   $	��Top=�6}   $��25��6�   $	��118��6�   ��6'   �� *ViewOrdersCommand+6�   �� 5!   
   $��
Add Orders��6   $
��Left=�6K   $��542,325,0,0q�6f   $	��Top=�6{   $��25��6�   $	��118��6�   ��6&   �� *AddOrdersCommand+6�   �� 5"   
   $��Modify Orders��6   $
��Left=�6P   $��542,368,0,0q�6k   $	��Top=�6�   $��25��6�   $	��118��6�   ��6)   �� *ModifyOrderCommand+6�   �� 5#   
   $��Delete Orders��6   $
��Left=�6P   $��542,407,0,0q�6k   $	��Top=�6�   $��25��6�   $	��118��6�   ��6)   �� *DeleteOrderCommand+6�   �� 5%   
   $��Employee's Raport��6   $
��Left=�6S   $��
659,56,0,0q�6n   $	��Top=�6�   $��25��6�   $	��118��6�   ��6-   �� *TotalOrderCommand+6�   �� 5&   
   $��Monthly Raport��6   $
��Left=�6R   $��659,120,0,0q�6m   $	��Top=�6�   $��25��6�   $	��118��6�   ��6*   �� *MontlyRaportCommand+6�   �� 5'   
   $��Daily Raport��6   $
��Left=�6O   $��659,183,0,0q�6j   $	��Top=�6   $��25��6�   $	��118��6�   ��6(   �� *DailyRaportCommand+6�   ��5)   
   �� 5*       �� ImageSource$  D:\user\Pictures\meniu.jpg��6    j� Stretch$ UniformToFill=�6B    �� Opacity$	 0.9Q�6Z   5,      5-      