   M S B A M L   `   `   `  ����   Mod3-Project1    +Microsoft.Samples.Kinect.ControlsBasics.CMS   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -   $��630.345��$��979.388������   �� Color$  White�� �� Opacity$	 0.4Q�.��� 
������� � RowDefinitions �� $
��Auto ��� $��* �.+�� -   $��
fileChange��$��2��$y�Visible=� �� $	��16* ��� $	��19* �.+��� -    ��Name$ 	pageTitle��$��10,10,-10,214q��� $�Content Management System���� �� �� -    ��Name$ bOpenFileDialog��$��Browse��$��30��$	��191��$��453,196,0,0q�$
��Left=�$	��Top=��� -    ��Name$ textBox1��$
��Left=�$��30��$��
10,196,0,0q� �� TextWrapping$
 Wrap=�$��Choose a File��$	��Top=�$	��438���� -   $ 
chooseOpen��$��Browse��$��30��$	��191��$��
453,16,0,0q�$
��Left=�$	��Top=�$��1���� -   $ 
ChooseFile��$
��Left=�$��30��$��	10,16,0,0q�$
 Wrap=�$��Choose a File��$	��Top=�$	��438��$��1���� -   $ 	textBlock��$
��Left=�$��37��$��
10,154,0,0q�$
��Wrap=�$	��Top=�$	��438��$��16(��� $�New File���� $�:���� -	   $ textBlock_Copy1��$
��Left=�$��37��$��
10,262,0,0q�$
��Wrap=�$��File to replace:��$	��Top=�$	��438��$��16(�$��2���� -
   $ goBack��$��Back to Home��$
��Left=�$��123,205,0,0q�$��1��$	��Top=�$	��198��$��30�����	#FF3DB93D�� -   $ QuestionMode��$��Edit Quiz Questions��$
��Left=�$��379,205,0,0q�$��1��$	��Top=�$	��198��$��30�����	#FF3DB93D�� -   $ editBut��$��Change��$��30��$	��198��$��123,106,0,0q�$
��Left=�$	��Top=�$��1���� -   $ goBack_Copy��$��Edit Info Page��$
��Left=�$��637,205,0,0q�$��1��$	��Top=�$	��198��$��30�����	#FF3DB93D� -   $��
infoChange��$��2��$y�	Collapsed=� �� $	��16* ��� $	��19* �.+��� -   $ textBox��$
��Left=�$	��431��$��2��$
 Wrap=�$	��Top=�$	��208��$��
10,106,0,0q��� -   $ textBox2��$
��Left=�$	��431��$��2��$
 Wrap=�$	��Top=�$	��208��$��259,106,0,0q��� -   $ infoBox��$
��Left=�$	��431��$��2��$
 Wrap=�$	��Top=�$	��459��$��510,106,0,0q��� -   $ 
textBlock5��$
��Left=�$��	10,10,0,0q�$
��Wrap=�$	��Top=��� $�	Info Page���� �� �� -    ��Name$ textSelector��$
��Left=� �� Text$ Go to Question��$��706,280,0,0q�$	��Top=�$	��263��$��30��$��1���� -   $ button��$��Change Text��$
��Left=�$��30��$��	10,54,0,0q�$	��Top=�$	��208���� -   $ button2��$��Change Text��$
��Left=�$��30��$��
259,54,0,0q�$	��Top=�$	��208���� -   $ addInfo��$��Add New Text Field��$
��Left=�$��30��$��
510,54,0,0q�$	��Top=�$	��208���� -   $ saveInfo��$��Change Text��$
��Left=�$��30��$��
761,54,0,0q�$	��Top=�$	��208��	 J� RenderTransformOrigin$	 4.154,0.467&��� -   $ button5��$��Back to main CMS��$
��Left=�$��30��$��
10,280,0,0q�$	��Top=�$	��208��$��1���� -   
 ��Name$
 
selectInfo��$!��Select Which Text to Update��$
��Left=�$��34��$��510,282,0,0q�$��1��$	��Top=�$	��196���� -    ��Name$ check��$
��Left=�$	��214��$��650,226,0,0q�$	��Top=�$	��220��$.��(/Mod3-Project;component/Images/check.png��$��2��$y�	Collapsed=�� -   $��
quizChange��$��2��$y�	Collapsed=�.+��� -   $ qSave��$��Save Changes��$��30��$	��191��$��
40,500,0,0q�$
��Left=�$	��Top=��� -   $
 ansA��$
��Left=�$��30��$��265,258,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��676���� -   $
 ansB��$
��Left=�$��30��$��265,313,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��676���� -   $
 ansC��$
��Left=�$��30��$��265,369,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��676���� -    $
 ansD��$
��Left=�$��30��$��265,423,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��676���� -!   $ questionText��$
��Left=�$	��133��$��265,100,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��676���� -"   $ qInfo��$
��Left=�$��	40,42,0,0q�$
��Wrap=�$��Editing Question Number��$	��Top=�$	��586���� -#   $ addQuestion��$��Add New Question��$��30��$	��191��$��265,500,0,0q�$
��Left=�$	��Top=��� -$   $ deleteQuestion��$��Delete Question��$��30��$	��191��$��499,500,0,0q�$
��Left=�$	��Top=��� -%   $ 	qSelector��$
��Left=�$ Go to Question��$��733,500,0,0q�$	��Top=�$	��208��$��30���� -&   $ 
textBlock1��$
��Left=�$��
93,142,0,0q�$
��Wrap=�$��Question��$	��Top=�$��48��$	��133���� -'   $ 
textBlock2��$
��Left=�$��
93,423,0,0q�$
��Wrap=�$��Answer D��$	��Top=�$��30��$	��133���� -(   $ 
textBlock3��$
��Left=�$��
93,373,0,0q�$
��Wrap=�$��Answer C��$	��Top=�$��30��$	��133���� -)   $ 
textBlock4��$
��Left=�$��
93,262,0,0q�$
��Wrap=�$��Answer A��$	��Top=�$��30��$	��133���� -*   $ textBlock15��$
��Left=�$��
93,317,0,0q�$
��Wrap=�$��Answer B��$	��Top=�$��30��$	��133��	� -+    	�Name$
 selA��$�� ��
 � Tag$ a��$
��Left=�$��
40,272,0,0q�$	��Top=�$��16��$��21��	� -,   $
 selB��$�� ��$ b��$
��Left=�$��
40,331,0,0q�$	��Top=�$��16��$��21��	� --   $
 selC��$�� ��$ c��$
��Left=�$��
40,383,0,0q�$	��Top=�$��16��$��21��	� -.   $
 selD��$�� ��$ d��$
��Left=�$��
40,432,0,0q�$	��Top=�$��16��$��21���� -/   $ goBack1��$��Back to Home��$
��Left=�$��122,568,0,0q�$	��Top=�$	��198��$��30�����	#FF3DB93D�� -0   $ fileMode��$��
Edit Files��$
��Left=�$��397,568,0,0q�$	��Top=�$	��198��$��30�����	#FF3DB93D�� -1   $ clearAll��$��Clear All Questions��$
��Left=�$��655,568,0,0q�$	��Top=�$	��198��$��30�����	#FF3DB93D