   M S B A M L   `   `   `  ����  ManagementApplication4    .ManagementApplication.Views.CategoriesListView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      .��5      �   � RowDefinitions  5	   
   �� 5
      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   $��10q�6;   
�������.+�5      �� $��Category Code:��6   $��Center=�6-   �� 5      -   5         ��Name$ txtCategoryCode��5      $	��200��6/   $��5q�6;   5      �� 5   
   $��1��6   $ 
Horizontal=�6"   $��10q�6;   
�������.+�5      �� $��Category Name:��6   $��Center=�6-   �� 5      -   5        $ txtCategoryName��5      $	��200��6/   $��5q�6;   6F   5      �� 5   
   -   5         ��Name$ Add_Category��5      $��Add Category��6'   $��0��6>   $��Right=�6K   $��10q�6g   6s   �� 5    
   -   5        $ Delete_Category��5       $��Delete Category��6*   $��1��6D   $��Right=�6Q   $��10q�6m   $��70��6�   $��27��6�   �� 5!   
   -   5        $ Edit_Category��5!      $��Edit Category��6(   $��2��6@   $��Right=�6M   $��10q�6i   $��70��6�   $��27��6�   &   System.Windows.Controls.DataGrid  5$   
   -   5          Name$ 
dgCategory��5$      $��3��6'      AutoGenerateColumns$
 True��64   $��10q�6O      CanUserAddRows$ False��6[   5&      5'      5(      