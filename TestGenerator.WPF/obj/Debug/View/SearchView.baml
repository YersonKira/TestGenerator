   M S B A M L   `   `   `  ����c  _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity  5      k gGalaSoft.MvvmLight.Extras.WPF45, Version=4.3.31.28649, Culture=neutral, PublicKeyToken=0e27b6f8be9b2ef7pQclr-namespace:GalaSoft.MvvmLight.Command;assembly=GalaSoft.MvvmLight.Extras.WPF45GalaSoft.MvvmLight.Command 5       TestGenerator.WPF'   !TestGenerator.WPF.View.SearchView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5      ecommandQclr-namespace:GalaSoft.MvvmLight.Command;assembly=GalaSoft.MvvmLight.Extras.WPF45     5      .��5
      �   � RowDefinitions  5   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��1��6.   .+�5      �� Buscar6    �� 5      $	��200��6   ��6"   �� *
SearchText+ �� UpdateSourceTrigger$ PropertyChanged=�.��6b   .   (System.Windows.Interactivity.Interaction   Triggers 5      /   )System.Windows.Interactivity.EventTrigger  5         	EventName$ TextChanged��6%   .   (System.Windows.Interactivity.TriggerBase   Actions. 5      /  )GalaSoft.MvvmLight.Command.EventToCommand     PassEventArgsToCommand .    Command 61   �� *ChangeCommand+6s   5      .��5   *   5      5      �� 5   
   -   5        $
��list��5   >   $��2��6   ��6    �� *Users+ �� View 5      �� 5      .P�5      �� 	 �� Width$		 100��6%   $��CI��61   
 �� DisplayMemberBinding
 6=   �� *UserCI+6g   �� 5       $		 150��6%   $��Nombres��61   
 6B   �� *Names+6k   �� 5!      $		 100��6%   $��Paterno��61   
 6B   �� *	FirstName+6o   �� 5"      $		 100��6%   $��Materno��61   
 6B   �� *
LastName+6n   �� 5#      $		 100��6%    �� CellTemplate 5$      �� 5%      .R�5&   "   �� $��Editar��6)   $��80��6:   ��5'   )   ��  �� ElementName$
 list�� �� Path$ DataContext.EditCommand���5(   )   �� 6H   5)      5+      �� 5,      $		 100��6%    5-      �� 5.      .R�5/   "   �� $��Eliminar��6)   $��80��6<   ��50   )   �� $
 list��$ DataContext.DeleteCommand���51   )   �� 6H   52      54      55      57      59      5:      