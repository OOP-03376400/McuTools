   M S B A M L   `   `   `  ����  MTools.Tool-    'MTools.ToolsDigital.SyncCounterDesigner   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -   5        .��5      �� -   5          ��Name$
  Tabs��5   *    �� TabStripPlacement$
 Left=�6   .@�5	   
   �� $��Input��6   .��5
      �  � RowDefinitions 5      �� 5      $��25 �6$   �� 5      $��25 �6$   �� 5       � ColumnDefinitions 5      �� 5      �� 5      $	��150 �6'   .+�5      �� $��0��6   $��3��6*    �� Orientation$ 
Horizontal=�6>   $��Center=�6W   .+�5      �� $��Number of variables:��6    $��14(�6<   $��10, 0q�6J   �� 5      -   5         ��Name$ 
VarButtons��5   :   $ 
Horizontal=�6!   .+�5      	� -   5         	�Name$ Default��5   2   $��2��6&    d� 	IsChecked$
 TrueY�6a   $��14(�6r   $	��5,0q�6�   	� 5      -   5        $��3��5   &   $��14(�6P   $	��5,0q�6^   	� 5      -   5        $��4��5   &   $��14(�6P   $	��5,0q�6^   	� 5      -   5        $��5��5   &   $��14(�6P   $	��5,0q�6^   	� 5      -   5        $��6��5   &   $��14(�6P   $	��5,0q�6^   	� 5      -	   5        $��7��5   &   $��14(�6P   $	��5,0q�6^   	� 5      -
   5        $��8��5   &   $��14(�6P   $	��5,0q�6^   5      5      �� 5       $��Counter stages:��6   $��1��63   $��0��6@   $��Center=�6P   $��Center=�6k   �� 5!      $��Options:��6   $��1��6,   $��1��69   $��Center=�6I   $��Center=�6d   &   System.Windows.Controls.DataGrid  5#      -   5          Name$ CounterDesigner��5#   M   	 �� AlternationCount$	 1��6   $��0��60   $��2��6@   
   CanUserAddRows
 .    CanUserDeleteRows .    AutoGenerateColumns .     AlternatingRowBackground �	#FFF9D995"   VerticalScrollBarVisibility$ Visible=�6�      CanUserReorderColumns .     CanUserResizeColumns .     CanUserSortColumns .     CanUserResizeRows .     SelectionUnit$
 Cell=�6�  !   EnableColumnVirtualization . ��6f   ��    Columns 5$      4  .System.Windows.Controls.DataGridComboBoxColumn  5%      -   5        StageCurrent��,  &System.Windows.Controls.DataGridColumn   Header$ Current stage��5%   o      SortDirection$ 	AscendingX�6�      Width5  /System.Windows.Controls.DataGridLengthConverter$	 200 6�      SelectedItemBinding 61   �� *	Current+6�     5&      -   5        	StageNext��$ 
Next Stage��5&   i   $ 	AscendingX�6}   $	 200 6�    61   �� *Next+6�   5(      �� 5+      $��2��6   $��1��6*   .+�5,      �� $��Fliplop Type:��6    $��10,0,0,0q�65   $��14(�6G   	� 5-      -   5        $��SR��5-   "   $��14(�6/   $��
20,10,20,0q�6=   $
 TrueY�6Q   6b   	� 5.      -   5        $
��S'R'��5.   "   $��14(�61   $
��20,5q�6?   6M   	� 5/      -   5        $��JK��5/   "   $��14(�6/   $
��20,5q�6=   6K   	� 50      -   5        $��D��50   "   $��14(�6.   $
��20,5q�6<   6J   	� 51      -   5        $��T��51   "   $��14(�6.   $
��20,5q�6<   6J   �� 53      -   5         ��Name$ BtnAdd��53      $��	Add Stage��6-   $��14(�6A   $��
20,10,20,0q�6O   6c   �� 54      -   5        $ 	BtnDelete��54      $��Delete selected��60   $��14(�6J   $��
20,10,20,0q�6X   6l   �� 55      -   5        $ BtnClear��55      $��	Clear all��6/   $��14(�6C   $��
20,10,20,0q�6Q   6e   �� 57      -   5        $��Solve!��57      $��14(�6C   $��
20,30,20,0q�6Q   58      59      5:      �� 5;   
   $��Output��6   .��5<      �� -   5         ��Name$ 
DesignText��5<      $��14(�6*   5=      5>      5?      