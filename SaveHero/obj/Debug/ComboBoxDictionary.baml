   M S B A M L   `   `   `  ����\  XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� MergedDictionaries �� Source   ComboBoxNormalBorderBrush �� Color ! ComboBoxNormalBackgroundBrush # ComboBoxDisabledForegroundBrush # ComboBoxDisabledBackgroundBrush  ComboBoxDisabledBorderBrush �� 
TargetType   ComboBoxToggleButtonTemplate � ColumnDefinitions �� CornerRadius �� Triggers P� Property P� Value	 �� 
TargetName
 �� Property �� Value N� EnterActions ��Name �� TargetProperty �� 
TargetName  SaveheroLightGreen	 �� To g� Duration N� ExitActions  ComboboxStandard �� 
TargetType  DefaultFont �� 	ClickMode d� 	IsChecked �� Path �� RelativeSource �� Mode J� IsHitTestVisible �� SelectionBoxItem �� SelectionBoxItemTemplate �� 
IsReadOnly �� 
IsReadOnly � AllowsTransparency �� IsDropDownOpen  J� SnapsToDevicePixels! � ActualWidth" �� MaxDropDownHeight-    'System.Windows.Input.KeyboardNavigation#    DirectionalNavigation�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml      5        5      �� 5   
   $ CoreDictionary.xaml?�6   %�  &	        &	 #     &	 B     &	 `     &	 ~     &	 �     7   7  7  7  7  7  7  7  &	 �    7  7  7   7  �� 5      $ 	LightGray��68   �� 5	      $ White��6<   �� 5
      $
 #888��6>   �� 5      $
 #eee��6>   �� 5      $
 #888��6:   �� 5      " d�6   .R�5   
   �  5      �� 5      �� 5      $��20 �6#   .+�5      �� $��Border��6)   $��2��6   8��  $ 0��5      $��
1, 1, 1, 1q�6    8�� 5      �� 5      $��ButtonBorder��6L   $��1��6   $��
1, 1, 1, 1q�6%   ���#444$ 
0, 0, 0, 0��5      $��
0, 0, 0, 0q�6)   8�� 5      F� 5      $��Arrow��6   $��1��6    =����        �    �� � 	= ��[ � z �� � z     � 	=  	= 	$��Center=�5      ���#444$��Center=�5      5        5!   
   P� 5#       �@J�IsMouseOver . . �5$      �� $	 ButtonBorder��65   
 � ��
 �����6O    5%      �� 5&      .��5'      �� $ MouseOverAnimation��6%   .��5(      �� $2 ,(Border.BorderBrush).(SolidColorBrush.Color)�6-   $ Border��5)   -   8  $ 0:0:0.1D�5+   -   5,      5-       5/      �� 50      .��51      �� $ MouseLeaveAnimation��6%   .��52      �� $2 ,(Border.BorderBrush).(SolidColorBrush.Color)�6-   $ Border��53   -   $ 	LightGrayX�54   -   $ 0:0:0.1D�55   -   56      57      59      P� 5:       �@d�	IsChecked$
 TrueY�68   . �5;      �� $	 ButtonBorder��65   
 � ��
 �����6O   �� 5<      $	 Arrow��6/   
 � �� �	#FF8D979E6B   5=      P� 5>       � {� .  . �5?      �� $	 Border��65   8  
 � ��6I   �� 5@      $	 ButtonBorder��65   8  
 � ��6O   �� 5A      $	 ButtonBorder��67   8  
 � ��6Q   �� 5B      8  
 � ��6;   �� 5C      $	 Arrow��6/   
 � �� �#9996B   5D      5F      �� 5H      " ��6&   .�5I   
   �� 
 �@J�SnapsToDevicePixels . 60   �� 5J   
   
 �@�OverridesDefaultStyle . 62   �� 5K   
   
 � ��$
 Auto=�6G   �� 5L   
   
 � ��$
 Auto=�6E   �� 5M   
   
 � �� . 6:   �� 5N   
   
 � ��
 �   �63   �� 5O   
   
 �@�FocusVisualStyle 6-   Z� �� 5P   
   
 � ��$ 0q�6,   �� 5Q   
   
 � ��8   6'   �� 5R   
   
 � ��
 �   �6'   �� 5S   
   
 � ��
 �����6'   �� 5T   
   
 �@�Cursor$
 Hand��6#   �� 5U   
   
 � ��$ 12(�6%   �� 5V   
   
 � �� 5W      �� 5X      " ��6"   .R�5Y      � .+�5Z      d� $��ToggleButton��6'   $��2��5[   '   $ Press=�5\   '   |�.  8��  5]   '   �� $ IsDropDownOpen� �� *TemplatedParent+$ TwoWay=�5^   '   �� 5_      $��ContentSite��6+   $��5, 3, 23, 3q�6>    .  $
��Left=�5`      $��Center=�6:   #��z 5a      #��z 5b      #��z��5c      �� 5d      $��PART_EditableTextBox��6"   $��3, 3, 23, 3q�5e   "   # z 5f   "   $y�Hidden=�5g   "   
������ $
��Left=�5h   "   $��Center=�6=   |�. .��5i   4   ��5j      �� 5k   "   " ��62   .R�5l   &   �� $��PART_ContentHost��6-   |�.  6E   5m   #   .��5n   0   5o      � 5p      $��Popup��6    $��Bottom=�6-   |�.   . #��z 5r       $��Slide=�5s       .��5t      � $��DropDown��6#     . #��z! 5u   #   #��z" 5v   #   .+�5w   "   �� $��DropDownBorder��6)   
�������$��
0, 1, 0, 0q�6R   $ 0��5x   )   $��1,1,1,1q�6:   8�� 5y   )   �� 5z   "   $��4q�6/     . .��5{   &   �� $# 	Contained=�65   5|   #   5}      5~      5       5�      P� 5�       �@��HasItems .  . �5�      �� $	 DropDownBorder��6K   
 � ��$ 95��6g   5�      P� 5�       � {� .  . �5�      �� 8  
 � ��6G   5�      P� 5�       �@��
IsGrouping . . �5�      �� 
 � �� .  6N   5�      P� 5�       �@��
IsEditable . . �5�      �� 
 �@  	IsTabStop .  6M   �� 5�      $	 PART_EditableTextBox��6E   
 � y�$ Visible=�6g   �� 5�      $	 ContentSite��6E   
 � y�$ Hidden=�6^   5�      5�      5�      5�      5�      