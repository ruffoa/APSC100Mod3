   M S B A M L   `   `   `  ����G  CMod3-Project, Version=2.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:Microsoft.Samples.Kinect.ControlsBasics'Microsoft.Samples.Kinect.ControlsBasics  5      2    ,Microsoft.Samples.Kinect.ControlsBasics.Help   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      d `Microsoft.Kinect.Wpf.Controls, Version=2.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e350k(http://schemas.microsoft.com/kinect/2014  5      Alocal5clr-namespace:Microsoft.Samples.Kinect.ControlsBasics  5      -   5        $��712.345��5
      $��979.388��6)   ��5      �� 5   
     �� Color$  White��6    �� Opacity$	 0.4Q�6(   .��5      0  *Microsoft.Kinect.Wpf.Controls.KinectRegion  -   5          Name$ kinectRegion��5      .��5   
   � 
������� � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $��* �6    .+�5      4  .Microsoft.Kinect.Wpf.Controls.KinectUserViewer  $��1��6!   $	��100��61   $��Right=�6>   $	��Top=�6Z   �� 5      -   5         ��Name$ goBack��5      $��Back to Home��6%   $
��Left=�6<   $��123,520,0,0q�6W   $��1��6l   $	��Top=�6y   $	��198��6�   $��52��6�   ���	#FF3DB93D6�   r� 5      -   5         r�Name$ MediaPlayer��5      $
��Left=�60   $	��357��6K   $��	10,10,0,0q�6X   $	��Top=�6k   $	��535��6�    r� Source$ Videos/guide1.mp4?�6�   $��1��6�   �� 5      -   5         ��Name$ instructions��5      $
��Left=�6.   $��	41,10,0,0q�6I   $
��Wrap=�6\   $)��#How to Use This Interactive Display��6p   $	��Top=�6�   $��48(�6�   �� 5      -   5        $
 next��5      $��Next Instruction��6#   $
��Left=�6>   $��638,520,0,0q�6Y   $��1��6n   $	��Top=�6{   $	��198��6�   $��52��6�   ���	#FF3DB93D6�   �� 5      -   5         ��Name$ 
scrollHelp��5      $
��Left=�6*   $	��465��6E   $��
560,10,0,0q�6R   $��1��6f   	 �� TextWrapping$
	 Wrap=�6s   $����The following guide will help you learn how to use the reposnsive Kinect display.  Hold out your hand towards the screen in order to be detected by the Kinect sensor.  A hand cursor will apear on screen when you are recognized.  This process may take a few seconds.  Try getting your cursor to appear on screen.��5      $	��Top=�5      $	��397��6   $��21.333(�6)   
�������6;   �� 5!      -   5        
 ��Name$
 
mainScreen��5!      
�������$��1��6<   $��684,297,49,185q�6I   $y�Hidden=�6a   �� 5"      -	   5         ��Name$ check��5"      $
��Left=�6#   $	��178��6>   $��638,297,0,0q�6K   $��1��6`   $	��Top=�6m   $	��198��6�   $.��(/Mod3-Project;component/Images/check.png��6�   $y�	Collapsed=�6�   �� 5$      -
   5        $��scrollViewer��5$      $
��Auto=�5%   #   $��Disabled=�5&   #      IsScrollInertiaEnabled . $��560,245,22,111q�5'   P   $��1��6h   $y�	Collapsed=�6u   .��5(      �� -   5        $��itemsControl��5(          Kinect250x250ItemTemplate#��[  64   $
��1315��6n   $	��226��6{   ��5)      �� 5*      .R�5+      � $��Center=�6(    � Orientation$ Vertical=�6C   $��9,0,29,0q�6Z   $	��204��6l   5,      5.      5/      �� 51      -   5        $��photoEx��51      $��1��6*   $
��Auto=�52      $
��Auto=�6<      IsHorizontalRailEnabled .    IsVerticalRailEnabled .    ZoomMode$ Enabled=�54      $��560,171,10,111q�69   $y�	Collapsed=�6Q   .��55      �� $
��None=�6   $��0��6'   $��0��67   $��Assets/sci19-small.png��6D   $	��396��6d   $	��409��6q   56      �� 57      -   5        $ 	testClick��57      $��Push Me!��6(   $
��Left=�6;   $	��138��6V   $��594,297,0,0q�6c   $��1��6x   $	��Top=�6�   $	��294��6�   $��48(�6�   ���	#FFFFAE00$y�	Collapsed=�6�   59      5:      5;      