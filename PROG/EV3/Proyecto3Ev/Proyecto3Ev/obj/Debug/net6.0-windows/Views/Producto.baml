   M S B A M L   `   `   `  ����F  BProyecto3Ev, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Proyecto3Ev.ViewsProyecto3Ev.Views  5           Proyecto3Ev.Views.Producto   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:Proyecto3Ev.Views     5      
������   � 	Resources  5
         TextBox.Static.Border �� Color  TextBox.MouseOver.Border  TextBox.Focus.Border  TextBoxStyle �� 
TargetType �� Property �� Value-  'System.Windows.Input.KeyboardNavigation �� 
TargetType ��Name �� CornerRadius J� SnapsToDevicePixels	 ��Name
 �� Triggers P� Property P� Value �� 
TargetName �� Triggers ]� 
Conditions �� Property �� Value �� 
ResourceId �� TypeInTargetAssembly&   System.Windows.Controls.DataGrid ��Name �Name J� Opacity � Points �� Stretch  DataGridStyle �� Padding � ColumnDefinitions � RowDefinitions   SelectAllCommand7  1System.Windows.Controls.DataGridHeadersVisibility
   All �� ConverterParameter!   HeadersVisibilityConverter  �� 	Converter! �� RelativeSource" �� AncestorTypeG  ASystem.Windows.Controls.Primitives.DataGridColumnHeadersPresenter#  Name$   Column% ��Name& �� CanContentScroll' ��Name( �� ScrollableHeight) � Maximum* �� Orientation+ �� ViewportHeight, �� ViewportSize*- �� #ComputedVerticalScrollBarVisibility. � Value/ �� Mode0 �� ScrollableWidth1 �� ViewportWidth,2 �� %ComputedHorizontalScrollBarVisibility=  7System.Windows.Controls.Primitives.DataGridColumnHeader*  $System.Windows.Controls.DataGridCell��%O  &	        &	 #     &	 F     &	 i     7   7  7  (�� �    58      $" DataGridSelectAllButtonStyle��"  )&	 q    '  �    '  �    �� 5   
   $ 	#FFABAdB3��68   �� 5   
   $ 	#FF7EB4EA��6;   �� 5   
   $ 	#FF569DE5��67   �� 5   
   " ��6%   .�5      ��  � ��# � ��6+   �� 5       � ��8   6,   �� 5       � ��# � ��6+   �� 5       � ��$ 1q�60   �� 5       �@ TabNavigation$
 None=�6A   �� 5       � ��$
 Left=�6;   �� 5       �@�FocusVisualStyle 61   Z� �� 5       �@J�	AllowDrop$
 true��6*   �� 5       �@��PanningMode$ VerticalFirst=�69   �� 5       �@��IsFlicksEnabled$ False��67   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $ border��63   $ 10��6!   #��z��6C   #��z��6m   #��z��6�   $
 True��6�   ._�5      �� $	 PART_ContentHost��6+   $|�false��6E   $��Hidden=�6W   $��Hidden=�6~   5      
 5       P� 5!       � {�$ false��6;   . �5"   "   �� $ border��6<    �@J�Opacity$
 0.56Q�6P   5#      P� 5$       �@J�IsMouseOver$
 true��6=   . �5%   "   �� $ border��6@   8   � ��6T   5&      P� 5'       �@J�IsKeyboardFocused$
 true��6C   . �5(   "   �� $ border��6@   8   � ��6T   5)      5+      5-       5.      ]� 5/       50      �� 51      + �@��#IsInactiveSelectionHighlightEnabled$
 true��6S   �� 52       �@��IsSelectionActive$ false��6A   ./�54      ��  �@��SelectionBrush# � /�67   55      57      �� 58   
   " ��6   .�59      ��  � �� 5:      �� 5;      " ��6&   .R�5<      � .+�5=      �� $ Border��6(   #��� ��68   $
 True��6y   � 5>      $ Arrow��6&   
���   �$��Right=�6B   $��8,8,3,3q�6^   $
 0.15Q�6o    �   ��� ��� ��� ��� $ Uniform=�6�   $��Bottom=�6�   5?      
 5@      P� 5A       �@J�IsMouseOver$
 True��6=   . �5B   "   �� $ Border��6;   # � ��6O    � ��5C      P� 5D       � ��$
 True��6;   . �5E   "   �� $ Border��69   # � ��6M    � ��5F      P� 5G       � {�$ False��6;   . �5H   "   �� $ Arrow��6?    � y�$ 	Collapsed=�6R   5I      5K      5M      5N      �� 5Q   
   "  6&   .�5R      ��  � ��# � ��6+   �� 5S       � ��# � ��6+   �� 5T       � ��
 ��d�6,   �� 5U       � ��$ 1q�60   �� 5V        �@ RowDetailsVisibilityMode$ VisibleWhenSelected=�69   �� 5W       � ��$
 true��6>   �� 5X       �@��PanningMode$
 Both=�69   �� 5Y       �@��IsFlicksEnabled$ False��67   �� 5Z       � �� 5[      �� 5\      "  6&   .R�5]      �� #��z��6!   #��z��6K   #��z��6w   # z��6�   $
 True��6�   ._�5^      �� $	 DG_ScrollViewer��6+   $|�false��6D   ��5_   "   �� 5`   &   " ��66   .R�5a   *   �  5b   .   �� 5c   2   $
��Auto �6C   �� 5d   2   $��* �6C   �� 5e   2   $
��Auto �6C    5g   .   �� 5h   2   $
��Auto �6@   �� 5i   2   $��* �6@   �� 5j   2   $
��Auto �6@   .+�5l   .   �� #��Z 65   $|�false��6d   ��6v   C� *�� $" DataGridSelectAllButtonStyle��"  +y�6�   �� *HeadersVisibility+# Z #  Z ! �� ""  ��6�  �� *CellsPanelHorizontalOffset+! �� ""    5m   .   $!# PART_ColumnHeadersPresenter��6M   $��1��6r   y�6�   �� *HeadersVisibility+# Z$ #  Z ! �� ""  �� 5n   .   $!% PART_ScrollContentPresenter��6E   #& z��6j   $��2��6�   $��1��6�   �� 5o   .   $' PART_VerticalScrollBar��68   $��2��6X   #) z( 6h   $* Vertical=�6�   $��1��6�   #, z+ 6  #y�z- 6H  . 6�   �� *VerticalOffset+$/ OneWay=�! �� *TemplatedParent+6H  � 5p   .   $��1��63   $��2��6C    5q   2   �� 5r   6   ��6G   �� **(NonFrozenColumnsViewportHorizontalOffset+! �� ""  �� 5s   6   $��* �6G   .+�5u   2   �� $' PART_HorizontalScrollBar��6<   $��1��6^   #) z0 6n   $* 
Horizontal=�6�   #, z1 6  #y�z2 6C  . 6�   �� *HorizontalOffset+$/ OneWay=�! �� *TemplatedParent+6C  5v   /   5w   +   5x   '   .��5z   "   �� # z 61   5{      5|      5}      5       5�      ]� 5�       5�      �� 5�       �@��
IsGrouping$
 true��6:   �� 5�      " �@%�IsVirtualizingWhenGrouping$ false��6\   ./�5�      ��  � ��$ false��6F   5�      5�      �� 5�   
   "  6   .�5�      ��  � ��
 ��d�6+   �� 5�       � ��$ SemiBold"�6+   �� 5�       � ��
 �����6+   �� 5�       � ��$ 20��6'   �� 5�       � ��$ Center=�6;   5�      �� 5�   
   "  6    5�      P� 5�       �@ 
IsSelected$
 True��60   . �5�      ��  � �� �#C8E1FF63   �� 5�       � ��
 ���� 64   �� 5�       � ��
 �   �63   5�      5�      5�      .��5�      �� $ 10��6   
������ ._�5�   
   � -   5        3 �Name$3 GridProductos��5�      .+�5�      � -   5        $3 	Contenido��5�      $��0��5�      $��0��5�      $��6��5�      $��8��5�       5�      �� 5�      $��20 �6'   �� 5�      �� 5�      �� 5�      �� 5�      �� 5�      $��20 �6'    5�      �� 5�      $��50 �6$   �� 5�      $��20 �6$   �� 5�      $��30 �6$   �� 5�      $��20 �6$   �� 5�      �� 5�      �� 5�      �� 5�      $��20 �6$   .+�5�      �� $��0��6   $��6��5�      $ ��Mantenimiento de Productos��5�      
���   �$��30(�5�      $��Center=�5�      $��Center=�5�      �� 5�      $��Buscar Producto:��6   $��Right=�5�      $��Center=�5�      $��1��5�      $��2��5�      $��15(�5�      $��0,0,10,0q�5�      �� 5�      -   5        4 ��Name$4 tbBuscar��5�      #���  5�      5 �� TextAlignment$5 Center=�6A   
������ 
����d�$��2��5�      $��2��5�      $��20(�5�      5�      �� 5�      -   5        6 ��Name$6 	BtnBuscar��5�      $��3��5�      $��2��5�      
����d�
����d�$��10,0,0,0q�5�      7 � Cursor$
7 Help��5�      $	��100��5�      $
��Left=�5�      .��5�      �� $��Buscar��6    
���   �$��15(�5�      5�      �� 5�      -   5        $6 BtnCrearProducto��5�      
�������
�������$��4��5�      $��2��5�      $7 AppStarting��5�      $	��150��5�      .��5�      �� $��Agregar Producto��6    
���   �$��15(�5�       5�        5�      -   5        8  Name$8 	GridDatos��5�      #���  5�      $��4��6C   $��1��5�      $��2��5�      $��4��5�      9   AutoGenerateColumns$9 False��5�      
����������#C8E1FF:   CanUserAddRows$: False��5�      ;   CanUserResizeColumns$
; True��5�      <   CanUserResizeRows$< False��5�      =   CanUserSortColumns$= False��5�      >   RowBackground
> ���� ?   HeadersVisibility$? Column=�5      @   GridLinesVisibility$@ 
Horizontal=�5     A   HorizontalGridLinesBrushA �#C8E1FFB   ColumnsB 5     4  .System.Windows.Controls.DataGridTemplateColumn  5     ,  &System.Windows.Controls.DataGridColumnC   Header$ C Opciones del Administrador��61   D   Width5	  /System.Windows.Controls.DataGridLengthConverter$	D 245	 5  -   E   CellTemplateE 5     �� 5  "   .R�5  &   ]� .+�5
  *   �� $6 BtnConsultar��5  -   -   5        $��	Consultar��5
  1   
����d�$��80��5  -   
������ 
���   ���5  -   �� *
IdArticulo+�� 5  *   $6 BtnModificar��5  -   -   5        $��	Modificar��5  1   
�������$��80��5  -   
������ 
���   ���5  -   �� *
IdArticulo+�� 5  *   $6 BtnElliminar��5  -   -	   5        $��Eliminar��5  1   
����d�$��80��5  -   
������ 
���   ���5  -   �� *
IdArticulo+6U   5  '   5   #   5"     0
  *System.Windows.Controls.DataGridTextColumn
  5#     $C Código��6-   $	D 150	 5$  )   1  +System.Windows.Controls.DataGridBoundColumnF   BindingF 5%  )   �� *Codigo+
  5&     $C Nombre��6-   $	D 100	 5'  )   F 5(  )   �� *Nombre+
  5)     $C Cantidad��6-   $	D 100	 5*  )   F 5+  )   �� *
Cantidad+
  5,     $C Precio Unitario��6-   $	D 100	 5-  )   F 5.  )   �� *Precio+
  5/     $C Descripcion��6-   $D *	 50  )   F 51  )   �� *Descripcion+53     55      � 57     -
   5        G  �Name$G FrameProducto��57     $��0��58     $��0��59     $��8��5:     $��6��5;     5=     5>     5A     