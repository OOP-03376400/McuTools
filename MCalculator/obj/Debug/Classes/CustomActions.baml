   M S B A M L   `   `   `  ����  MCalculator.Tool'   !MCalculator.Classes.CustomActions   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $��25 �6   �� 5      $��22 �6   �� 5      .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��0��6.   $��Center=�6;   .+�5      �� -   5         ��Name$ BtnLoad��5   (   $��Load file ...��69   $��10,0,0,0q�6Q   �� 5      -   5        $ BtnSave��5   (   $��Save file ...��69   $
��10,0q�6Q   �� 5      -   5        $ 	BtnCreate��5   *   $��Create from input ...��6=   5      �� 5   
   $��1��6   $ 
Horizontal=�6"   .+�5      �� $��Action:��6   $��Center=�6'   $
��10,0q�6B   	� 5      -   5         	�Name$ RbExec��5      $��Execute��6*   $��Center=�6<    d� 	IsChecked$
 TrueY�6W   	� 5      -   5        $ RbEdit��5      $
��Edit��6*   $��Center=�69   $
��10,0q�6T   	� 5      -   5        $ RbDelete��5      $��Delete��6,   $��Center=�6=   5      �� 5   
   $��2��6   $
��Auto=�6$   .��5      � -   5         �Name$ Buttons��5      6+   5      5      5      