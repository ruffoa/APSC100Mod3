   M S B A M L   `   `   `  ����G  CMod3-Project, Version=2.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:Microsoft.Samples.Kinect.ControlsBasics'Microsoft.Samples.Kinect.ControlsBasics  5      6    0Microsoft.Samples.Kinect.ControlsBasics.QuizPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      d `Microsoft.Kinect.Wpf.Controls, Version=2.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e350k(http://schemas.microsoft.com/kinect/2014  5      Alocal5clr-namespace:Microsoft.Samples.Kinect.ControlsBasics  5      .��5      �   J� Opacity$  0.995Q�6   ��5   
   �� 5       �� Color$ White��6    �� Opacity$	 0.4Q�6,    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ 	pageTitle��5      $��	Quiz Game��6'   $��10,10,10,278q�5      � 5   
   -   5         �Name$ gameArea��5      $��0��6!   $y�	Collapsed=�6.    � ColumnDefinitions 5      �� 5      $
��0.5* �6#   �� 5      $
��0.5* �6#   .+�5      �� -   5         ��Name$
 ansA��5      $��Button��6#   $
��Left=�64   $��
45,164,0,0q�6O   $	��Top=�6c   $	��406��6{   $	��100��6�   $��2��6�   �� 5      -   5        $
 ansB��5      $��Button��6#   $
��Left=�64   $��198,164,-254,0q�6O   $	��Top=�6g   $	��406��6   $	��100��6�   $��1��6�   �� 5      -   5        $
 ansC��5      $��Button��6#   $
��Left=�64   $��45,381,0,-162q�6O   $	��Top=�6f   $	��406��6~   $	��101��6�   $��2��6�   �� 5      -   5        $
 ansD��5      $��Button��6#   $
��Left=�64   $��198,381,-254,-162q�6O   $	��Top=�6j   $	��406��6�   $	��101��6�   $��1��6�   �� 5      -   5        $ questionNum��5      $
��Left=�6-   $��	10,64,0,0q�6H   $
��Wrap=�6[   $��	TextBlock��6o   $	��Top=�6�   $	��280��6�   $��18.667(�6�   $��2��6�   �� 5       -   5        $ question��5       $
��Left=�6*   $��10,94,-122,0q�6E   $
��Wrap=�6[   $��	TextBlock��6o   $	��Top=�6�   $	��412��6�   $��70��6�   $��16(�6�   $��2��6�   �� 5!      -	   5         ��Name$ correct��5!      $
��Left=�6%   $	��100��6@   $��	26,33,0,0q�6M   $	��Top=�6`   $	��100��6x   $��/Images/check.png��6�   $��1��6�   $y�	Collapsed=�6�   5"      �� 5#   
   -
   5        $��startButton��5#      $��Start!��6$   $
��Left=�65   $	��143��6P   $��78,147,-5,0q�6]   $	��Top=�6r   $	��227��6�   $��48(�6�   6�   �� 5$   
   -   5        	 ��Name$
	 test��5$      $
��Left=�6    $	��304��6;   $��305,0,-183,0q�6H   
 �� TextWrapping$

 Wrap=�6^   $��TextBox��6r   $	��Top=�6�   $	��178��6�   $y�	Collapsed=�6�   5&      5'      