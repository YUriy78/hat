   M S B A M L   `   `   `  ����  Hat    Hat.Views.MainWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      T PCatel.Extensions.Controls, Version=4.4.0.0, Culture=neutral, PublicKeyToken=nullE ACatel.MVVM, Version=4.4.0.0, Culture=neutral, PublicKeyToken=null'catelhttp://catel.codeplex.com   5        � 
ResizeMode$  NoResize=�5       � WindowStartupLocation$ CenterScreen=�5       � Icon$ /Img/hat.jpg��5      ���#fff0f5$	��650��5	      $	��627��5
      .��5      �  � RowDefinitions 5   
   �� 5      $	��150 �6   �� 5      �� 5      $	��130 �6   �� 5      $��60 �6    � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      .+�5   
   �� $��1��6    �� Orientation$ 
Horizontal=�6%   .+�5      �� $��30,0,0,0q�6   ��6&   �� *Header+5      �� 5   
   -   5        $��mList��5   z   
�������$��4��6%   ��66   �� *Items+ �� SelectedItem 6T   �� *SelectedItem+��5      �� 5      .R�5      �� $��5q�6   $	��130��6'   ��64   �� *Image+5      5!      �� 5#   
   $��1��6   $��1��6   .+�5$      �� $��
180,50,0,0q�6   ��6(   �� *CurrentAnimalImage+�� 5%      ��6   �� *	MarginHat+��61   �� *Hat+5&      �� 5)   
   $��Center=�6   $��1��61   $��2��6A   $��20(�6N   $��Verdana)�6\   
����  ���6�   �� *CurrentDescription+�� 5,      $��1��6   $��3��6&   $ 
Horizontal=�63   .+�5-      �� $��20,0,0,0q�6:   $	��200��6L   $��50��6X   $��Поднять шляпу��6d   {�6   �� *IsEnabledStart+��6|   �� *ShowCommand+�� 5.      $��20,0,0,0q�69   $	��200��6K   $��50��6W   $��Играть еще��6c   {�6   �� *IsEnabledNext+��6x   �� *NextCommand+5/      52      54      