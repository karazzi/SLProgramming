   M S B A M L   `   `   `  ����?  ;Krig, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:KrigKrig  5   	       Krig.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Krig     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � IsSharedSizeScope$
 True��6   $	��434��6)   $��Bottom=�66    � RowDefinitions 5
   
   �� 5      $	��60* �6   �� 5      $	��68* �6   �� 5      $	��20* �6   �� 5      $	��44* �6   �� 5      $	��10* �6   �� 5      $	��40* �6   �� 5      $	��10* �6   �� 5      $	��44* �6   �� 5      $	��20* �6   �� 5      $	��68* �6   �� 5      $	��60* �6    � ColumnDefinitions 5   
   �� 5       z� SharedSizeGroup$ A��6   $	��50* �63   �� 5      $
��140* �6   �� 5      $
��156* �6   �� 5      $
��109* �6   �� 5      $
��155* �6   �� 5      $
��140* �6   �� 5      $��50 �6   $ A��6*   .+�5!   
   �� -   5        $��
DealButton��5!      $��5��6#   $��3��60   $y�Hidden=�6@   .��6m   Deal6s   �� 5"   
   -   5        $��
PlayButton��5"      $��5��6#   $��3��60   $y�Visible=�6@   .��6n   Play6t   �� 5$   
   $��1��6   $��2��6   .��6-   
Player 167   �� 5%   
   $��9��6   $��2��6   .��6-   
Computer67   �� 5'   
   -   5        $��GameOverLabel��5'      $��5��6%   $��2��62   $y�Hidden=�6B   .��6V   
Game Over!6b   �� 5)   
   -   5        $��PlayerOneCardBox��5)      $��3��6*   $��3��6:   �� 5*   
   -   5        $��PlayerOnePointsBox��5*      $��3��6,   $��1��6<   $��Score: ��6I   �� 5+   
   -   5        $��PlayerTwoCardBox��5+      $��3��6*   $��7��6:   �� 5,   
   -   5        $��PlayerTwoPointsBox��5,      $��3��6,   $��9��6<   $��Score: ��6I   5-      5.      