   M S B A M L   `   `   `  ����  TestGenerator.WPF%    TestGenerator.WPF.View.UserView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5      � $��10q�6     � RowDefinitions  5	   
   �� 5
      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,    � ColumnDefinitions 5   
   �� 5      6!   �� 5      $
��auto �6   6.   .+�5   
   �  � DataContext 6   �� *User+  5      �� 5      $
��auto �6    60   �� 5      $
��auto �6    60   �� 5      $
��auto �6    60   �� 5      $
��auto �6    60   �� 5      $
��auto �6    60   �� 5      $
��auto �6    60   �� 5      $
��auto �6    60   �� 5      $
��auto �6    60   �� 5      $
��auto �6    60    5      �� 5      $
��auto �6#   62   �� 5       $��* �6#   6/   .+�5"      �� $��1��6   	Registro:60   �� 5#      $��1��6   $��1��6#   ��63   �� *RegistrationNumber+ �� Mode$ TwoWay=�6e   �� 5$      $��2��6   CI:6*   �� 5%      $��2��6   $��1��6#   ��63   �� *UserCI+$ TwoWay=�6Y   �� 5&      $��3��6   Apellido Paterno:68   �� 5'      $��3��6   $��1��6#   ��63   �� *	FirstName+$ TwoWay=�6\   �� 5(      $��4��6   Apellido Materno:68   �� 5)      $��4��6   $��1��6#   ��63   �� *
LastName+$ TwoWay=�6[   �� 5*      $��5��6   
Nombres:6/   �� 5+      $��5��6   $��1��6#   ��63   �� *Names+$ TwoWay=�6X   �� 5,      $��6��6   Aula:6,   �� 5-      $��6��6   $��1��6#   ��63   �� *	Classroom+$ TwoWay=�6\   5.      � 5/   
   $��1��6     50      �� 51      6"   �� 52      $
��auto �6    60   .+�54      �� $	��200��61   $	��200��6=   ��6   �� *	ImagePath+6L   �� 55      $��1��6   ��6"   �� *SelectImageCommand+.��6I   SelectImage6V   56      �� 57   
   $��Right=�6   $��1��61   $��1��6>    �� Orientation$ 
Horizontal=�6N   .+�58      �� $	��100��6   {�6!   �� *IsSaveButtonEnabled+��6K   �� *SaveCommand+.��6k   	Guardar6t   �� 59      $	��100��6   {�6!   �� *IsSaveButtonEnabled+��6K   �� *CancelCommand+.��6m   
Cancelar6w   5:      � 5;   
   $��2��6    � IsIndeterminate . $��2��6f   y�6:   �� *IsProgressBarEnabled+6}   5<      5=      