   M S B A M L   `   `   `  ���� G  CMod3-Project, Version=2.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:Microsoft.Samples.Kinect.ControlsBasics'Microsoft.Samples.Kinect.ControlsBasics  2    ,Microsoft.Samples.Kinect.ControlsBasics.Help   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     d `Microsoft.Kinect.Wpf.Controls, Version=2.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e350k(http://schemas.microsoft.com/kinect/2014  Alocal5clr-namespace:Microsoft.Samples.Kinect.ControlsBasics  -   $��712.345��$��979.388������   �� Color$  White�� �� Opacity$	 0.4Q�.��0  *Microsoft.Kinect.Wpf.Controls.KinectRegion  -     Name$ kinectRegion��.��� 
������� � RowDefinitions �� $
��Auto ��� $��* �.+�4  .Microsoft.Kinect.Wpf.Controls.KinectUserViewer  $��1��$	��100��$��Right=�$	��Top=��� -    ��Name$ goBack��$��Back to Home��$
��Left=�$��123,520,0,0q�$��1��$	��Top=�$	��198��$��52�����	#FF3DB93Dr� -    r�Name$ MediaPlayer��$
��Left=�$	��357��$��	10,10,0,0q�$	��Top=�$	��535�� r� Source$ Videos/guide1.mp4?�$��1���� -    ��Name$ instructions��$
��Left=�$��	41,10,0,0q�$
��Wrap=�$)��#How to Use This Interactive Display��$	��Top=�$��48(��� -   $
 next��$��Next Instruction��$
��Left=�$��638,520,0,0q�$��1��$	��Top=�$	��198��$��52�����	#FF3DB93D�� -    ��Name$ 
scrollHelp��$
��Left=�$	��465��$��
560,10,0,0q�$��1��	 �� TextWrapping$
	 Wrap=�$����The following guide will help you learn how to use the reposnsive Kinect display.  Hold out your hand towards the screen in order to be detected by the Kinect sensor.  A hand cursor will apear on screen when you are recognized.  This process may take a few seconds.  Try getting your cursor to appear on screen.��$	��Top=�$	��397��$��21.333(�
��������� -   
 ��Name$
 
mainScreen��
�������$��1��$��684,297,49,185q�$y�Hidden=��� -	    ��Name$ check��$
��Left=�$	��178��$��638,297,0,0q�$��1��$	��Top=�$	��198��$.��(/Mod3-Project;component/Images/check.png��$y�	Collapsed=��� -
   $��scrollViewer��$
��Auto=�$��Disabled=�   IsScrollInertiaEnabled . $��560,245,22,111q�$��1��$y�	Collapsed=�.���� -   $��itemsControl��   Kinect250x250ItemTemplate#��[  $
��1315��$	��226������ .R�� $��Center=� � Orientation$ Vertical=�$��9,0,29,0q�$	��204���� -   $��photoEx��$��1��$
��Auto=�$
��Auto=�   IsHorizontalRailEnabled .    IsVerticalRailEnabled .    ZoomMode$ Enabled=�$��560,171,10,111q�$y�	Collapsed=�.���� $
��None=�$��0��$��0��$��Assets/sci19-small.png��$	��396��$	��409���� -   $ 	testClick��$��Push Me!��$
��Left=�$	��138��$��594,297,0,0q�$��1��$	��Top=�$	��294��$��48(����	#FFFFAE00$y�	Collapsed=�