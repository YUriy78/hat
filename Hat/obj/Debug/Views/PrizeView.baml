   M S B A M L   `   `   `  ����  Hat    Hat.Views.PrizeView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      T PCatel.Extensions.Controls, Version=4.4.0.0, Culture=neutral, PublicKeyToken=nullE ACatel.MVVM, Version=4.4.0.0, Culture=neutral, PublicKeyToken=null'catelhttp://catel.codeplex.com   5      .gif"http://wpfanimatedgif.codeplex.com   5        � Icon$  /Img/275038.gif��5      .��5      �  � RowDefinitions 5	   
   �� 5
      �� 5      $
��auto �6   .+�5   
   �� .+�5      �� $��Center=�6   $��14(�65   $��Verdana)�6C   
����  �$$��Вы угадали 10 раз!��6k   �� 5      $��Center=�6   $��14(�65   $��Verdana)�6C   
���  ��$��Поздравляем!��6i   r� 5      -   5         r�Name$ Video��5   '   $	��350��6    r� Source$ video/1256.mp4?�66    r� LoadedBehavior 6N   �� *ControlVideo+5      �� 5   
    �� Orientation$ 
Horizontal=�6   $��1��6.   .+�5      �� -   5         ��Name$
 Play��5      $��Пуск��6$   $��23��63   $��74��6?   ��6J   �� *PlayCommand+�� 5      -   5        $
 Stop��5      $��Стоп��6$   $��23��63   $��74��6?   ��6J   �� *StopCommand+�� 5      -   5        $ Pause��5      $��
Пауза��6%   $��23��65   $��74��6A   ��6L   �� *PauseCommand+5      5      5      