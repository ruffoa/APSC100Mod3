   M S B A M L   `   `   `  ���� G  CMod3-Project, Version=2.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:Microsoft.Samples.Kinect.ControlsBasics'Microsoft.Samples.Kinect.ControlsBasics  6    0Microsoft.Samples.Kinect.ControlsBasics.QuizPage   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     d `Microsoft.Kinect.Wpf.Controls, Version=2.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e350k(http://schemas.microsoft.com/kinect/2014  Alocal5clr-namespace:Microsoft.Samples.Kinect.ControlsBasics  .���   J� Opacity$  0.995Q�����  �� Color$ White�� �� Opacity$	 0.4Q� � RowDefinitions �� $
��Auto ��� $��* �.+��� -    ��Name$ 	pageTitle��$��	Quiz Game��$��10,10,10,278q�� -    �Name$ gameArea��$��0��$y�	Collapsed=� � ColumnDefinitions �� $
��0.5* ��� $
��0.5* �.+��� -    ��Name$
 ansA��$��Button��$
��Left=�$��
45,164,0,0q�$	��Top=�$	��406��$	��100��$��2���� -   $
 ansB��$��Button��$
��Left=�$��198,164,-254,0q�$	��Top=�$	��406��$	��100��$��1���� -   $
 ansC��$��Button��$
��Left=�$��45,381,0,-162q�$	��Top=�$	��406��$	��101��$��2���� -   $
 ansD��$��Button��$
��Left=�$��198,381,-254,-162q�$	��Top=�$	��406��$	��101��$��1���� -   $ questionNum��$
��Left=�$��	10,64,0,0q�$
��Wrap=�$��	TextBlock��$	��Top=�$	��280��$��18.667(�$��2���� -   $ question��$
��Left=�$��10,94,-122,0q�$
��Wrap=�$��	TextBlock��$	��Top=�$	��412��$��70��$��16(�$��2���� -	    ��Name$ correct��$
��Left=�$	��100��$��	26,33,0,0q�$	��Top=�$	��100��$��/Images/check.png��$��1��$y�	Collapsed=��� -
   $��startButton��$��Start!��$
��Left=�$	��143��$��78,147,-5,0q�$	��Top=�$	��227��$��48(��� -   	 ��Name$
	 test��$
��Left=�$	��304��$��305,0,-183,0q�
 �� TextWrapping$

 Wrap=�$��TextBox��$	��Top=�$	��178��$y�	Collapsed=�