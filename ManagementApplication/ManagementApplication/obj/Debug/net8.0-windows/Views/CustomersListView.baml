   M S B A M L   `   `   `  ����  ManagementApplication3    -ManagementApplication.Views.CustomersListView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      .��5      �   � RowDefinitions  5	   
   �� 5
      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   $��10q�6;   
�������.+�5      �� $��Customer Code:��6   $��Center=�6-   �� 5      -   5         ��Name$ txtCustomerCode��5      $	��200��6/   $��5q�6;   5      �� 5   
   $��1��6   $ 
Horizontal=�6"   $��10q�6;   
�������.+�5      �� $��Customer Name:��6   $��Center=�6-   �� 5      -   5        $ txtCustomerName��5      $	��200��6/   $��5q�6;   5      �� 5   
   $��2��6   $ 
Horizontal=�6"   $��10q�6;   
�������.+�5      �� $��Customer Gender:��6   $��Center=�6/   �� 5      -   5        $ txtCustomergender��5      $	��200��61   $��5q�6=   5       �� 5!   
   $��3��6   $ 
Horizontal=�6"   $��10q�6;   
�������.+�5"      �� $��Customer Phone:��6   $��Center=�6.   �� 5#      -   5        $ txtCustomerphone��5#      $	��200��60   $��5q�6<   5$      �� 5'   
   -   5         ��Name$ Add_customer��5'      $��Add Customer��6'   $��1��6>   $��Right=�6K   $��10q�6g   $��70��6�   $��27��6�   �� 5(   
   -   5        $ Delete_Customer��5(      $��Delete Customer��6*   $��2��6D   $��Right=�6Q   $��10q�6m   $��70��6�   $��27��6�   �� 5)   
   -   5        $ Edit_Customer��5)      $��Edit Customer��6(   $��3��6@   $��Right=�6M   $��10q�6i   $��70��6�   $��27��6�   &   System.Windows.Controls.DataGrid  5+   
   -   5          Name$ dgCustomers��5+      $��4��6(      AutoGenerateColumns$
 True��65   $��10q�6P      CanUserAddRows$ False��6\   5-      5.      5/      