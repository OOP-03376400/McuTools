   M S B A M L   `   `   `  ����  McuTools.Interfaces5    /McuTools.Interfaces.Controls.ShaderTabPopoutWin   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          �Name$	  Win��5   V    � Title$ ShaderTabPopoutWin��6	   $	��400��6$   $	��700��61   
������  � WindowStartupLocation$ CenterScreen=�6�   .��5      � -   5         �Name$ MainGrid��5   5   
������ $��5,3,5,5q�6$    � RowDefinitions 5   
   �� 5      $��35 �6   �� 5       � ColumnDefinitions 5
   
   �� 5      �� 5      $��50 �6   �� 5      $	��150 �6   .+�5   
   �� $��Center=�6F   $��15(�6a   $��0��6o   $��0��6|    �� TextAlignment$ Center=�6�   ��6   ��  �� ElementName$	 Win�� �� Path$ 
GlassTitle�6�   o� 5   
   $��10,0,0,0q�6   $��0��6!   $��1��6.   $��Center=�6>   $��Right=�6Y   
������ .@�5      m� $
��Tool��6   .@�5      m� -   5        	 m�Name$	 WinClose��5      $��Close��6-   6<   m� 5      -   5        $	 
WinStayTop��5      $��Always top: False��6/   6J   5      5      � 5   
   -   5        $ Child��5      $��3��6   $��1��62   #��� ��6?   6�   5      5      