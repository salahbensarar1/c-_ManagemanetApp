   M S B A M L   `   `   `  ����P  LManagementApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:ManagementApplicationManagementApplication  5   	   "    ManagementApplication.Choice   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:ManagementApplication     5   	   _ [MaterialDesignThemes.Wpf, Version=5.0.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignFont#���  5   	    � Title$ Choice��5   	   $	��450��6   $	��800��6%   .��5      �  � ColumnDefinitions 5      �� 5      $	��40* �6#   64   �� 5      $	��40* �6#   62   .+�5   
   �� $��0��6   $��Assets/Logo_login.png��6    6A   �� 5   
   $��Center=�6   $��Center=�60    �� Orientation$ Vertical=�6M   $��1��6d   .+�5      �� $��Center=�6   $��36(�65   $	��235��6C   �� 6P    � Language$ fr-ma�6T   $�
Pick One !��6e   $��Gadugi)�6w   6�   �� 5      $��10��6   6&   �� 5      $ 
Horizontal=�6   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Register=�6*   $��30��6:   $��50��6E    � Cursor$ Cross��6Q   �� 6c   $��20��6m   6z   �� 5      $��20��6   6)   �� 5      $��1q�6   
�������
����p��$	��200��6[   $��50��6g    �� CornerRadius$ 25��6s   	 � 	Resources	 5      
 �� 
TargetType �� Property �� Value �� 
TargetType��%-  '��       �� 5!      "
 ��6    .�5#      ��  � ��
 �   �6;   �� 5%       � ��$ 0q�6@   �� 5'       � �� 5(   "   �� 5)   &   " ��66   .R�5*   *   �� #��z��61   $ 25��6[   ._�5+   .   �� $��Center=�6?   $��Center=�6\   5,   +   5-   '   5/      50      51      ._�52      �� -   5         ��Name$ Register_From_Choice_page��52      $��Register an employee��6i   $	��175��6�   $��40��6�   
����p��$��Microsoft YaHei UI Light)�6�   $��16(�6�   53      55      �� 56      $��10��6   6&   �� 57      $ 
Horizontal=�6   .+�58        $
 Work=�6*   $��30��66   $��50��6A   $ Cross��6M   �� 5;      $��40��6   6)   �� 5<      $��1q�6   
�������
����p��$	��200��6_   $��50��6k   $ 25��6w   	 5=      ��%-  '��       �� 5?      "
 ��6    .�5A      ��  � ��
 �   �6;   �� 5C       � ��$ 0q�6@   �� 5E       � �� 5F   "   �� 5G   &   " ��66   .R�5H   *   �� #��z��61   $ 25��6[   ._�5I   .   �� $��Center=�6?   $��Center=�6\   5J   +   5K   '   5M      5N      5O      ._�5P      �� -   5        $ Go_ToManage��5P      $��Start working��6M   $	��175��6e   $��40��6q   
����p��$��Microsoft YaHei UI Light)�6�   $��16(�6�   5Q      5S      5Y      5Z      5[      