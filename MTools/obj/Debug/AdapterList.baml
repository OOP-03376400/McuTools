   M S B A M L   `   `   `  ����  MTools.Tool    MTools.AdapterList   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$  Select Network card��5   	   $	��250��6%   $	��500��62    � WindowStartupLocation$ CenterScreen=�6U    � 
ResizeMode$ NoResize=�6z    � WindowStyle$ 
ToolWindow=�6�   .��5      �  � RowDefinitions 5   
   �� 5      �� 5      $��30 �6   .+�5
   
   �� -   5         ��Name$ AdaptersList��5
      $��0��6   $��14(�65   5      �� 5   
   -   5         ��Name$ AdapterSelected��5      $��OK��6   $��1��6U   $��5q�6b   {�6m   ��  �� ElementName$ AdapterList�� �� Path$ SelectedItems.Count�5      5      