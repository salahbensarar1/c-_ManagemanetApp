   M S B A M L   `   `   `  ����P  LManagementApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:ManagementApplication.ViewsManagementApplication.Views  5      2    ,ManagementApplication.Views.BillingsListView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      ;local)clr-namespace:ManagementApplication.Views     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      -   5        .��5	      �   � ColumnDefinitions  5
   
   �� 5      $��0* �6   �� 5      $��7* �6   �� 5      $
��793* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��205* �6   �� 5      $
��101* �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   $��
3,10,10,10q�6;   
�������$��2��6b   .+�5      �� $��Billing Code:��6   $��Center=�6,   �� 5      -   5         ��Name$ txtBillingCode��5      ${�False��6.   $	��200��6@   $��5q�6L   5      �� 5   
   $��1��6   $ 
Horizontal=�6"   $��
3,10,10,10q�6;   
�������$��2��6b   .+�5      �� $��Customer Name:��6   $��Center=�6-   �� 5       -   5        $ txtCustomerName��5       $	��200��6/   $��5q�6;   5!      �� 5$   
   $��2��6   $ 
Horizontal=�6"   $��
3,10,10,10q�6;   
�������$��2��6b   .+�5%      �� $��Total Amount:��6   $��Center=�6,   
�������6G   �� 5&      -   5        $ txtTotalAmount��5&      $	��200��6.   $��5q�6:   5'      �� 5*   
   -   5         ��Name$ Add_Billing��5*      $��Add Billing��6&   $��0��6<   $
��Left=�6I   $��721,10,0,10q�6d   $��2��6�   $��70��6�   $��27��6�   �� 5+   
   -   5        $ Delete_Billing��5+      $��Delete Billing��6)   $��1��6B   $
��Left=�6O   $��721,10,0,10q�6k   $��2��6�   $��70��6�   $��27��6�   �� 5,   
   -   5        $ Edit_Billing��5,      $��Edit Billing��6'   $��2��6>   $
��left=�6K   $��721,10,0,10q�6g   $��70��6�   $��2��6�   $��27��6�   &   System.Windows.Controls.DataGrid  5.   
   -   5          Name$ 
dgBillings��5.      $��3��6'      AutoGenerateColumns$
 True��64   $��
3,10,10,10q�6O      CanUserAddRows$ False��6c   $��2��6�   $��2��6�   50      51      52      