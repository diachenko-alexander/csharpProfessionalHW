   M S B A M L   `   `   `  ����@  <Task4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Task4Task4  5   	       Task4.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   X TXceed.Wpf.Toolkit, Version=3.8.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	   localclr-namespace:Task4  5   	   -   5          � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)   .��5
      �� $
��Left=�6   $	��390��6,   $��	19,24,0,0q�69   $	��Top=�6L   $	��759��6d   .@�5   
   �� $
��Text��6   .��5      � ���	#FFE5E5E5 � ColumnDefinitions 5      �� 5      $��0* �6'   �� 5      $��0* �6'   �� 5      .+�5      �� -   5        $��	TextBlock��5      $
��Left=�6-   $��1,21,0,0q�6H   $
��Wrap=�6Z   $����Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.��6n   $	��Top=�63  $	��317��6K  $	��710��6X  $��1��6d  $��2��6t  5      5      �� 5   
   $��Settings��6   .��5      � ���	#FFE5E5E5 5      �� 5      $��0* �6'   �� 5      $��5* �6'   �� 5      $
��246* �6'   .+�5      #  Xceed.Wpf.Toolkit.ColorPicker  -   5        $ ��ColorPickerBackgroundColor��5   #   $��140,16,360,310q�6E      DisplayColorAndName . !   AvailableColorsSortingMode$ HueSaturationBrightness=�6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   $��2��6  5      �� 5      -   5        $��
SaveButton��5      $
��Save��6+   $
��Left=�6:   $��	7,295,0,0q�6U   $	��Top=�6h   $	��130��6�   $��41��6�   $��2��6�   �� 5       $��Background Color��6   $
��Left=�63   $��7,20,0,0q�6N   $	��Top=�6`   $��29��6x   $	��109��6�   $��2��6�   �� 5!      $��
Text Color��6   $
��Left=�6-   $��7,81,0,0q�6H   $	��Top=�6Z   $��30��6r   $	��109��6~   $��2��6�   �� 5"      $��	Text Size��6   $
��Left=�6,   $��	7,146,0,0q�6G   $	��Top=�6Z   $��36��6r   $	��109��6~   $��2��6�   �� 5#      $��Style��6   $
��Left=�6(   $��	7,213,0,0q�6C   $	��Top=�6V   $��36��6n   $	��109��6z   $��2��6�     5$      -   5          Name$ ColorPickerTextColor��5$   #   $��143,75,361,252q�6A    . $ HueSaturationBrightness=�6�   $ 0.5,0.5&�6�   $��2��6�   5&      �� 5'      -   5        $��TextSizeBox��5'      $
��Left=�6.   $��139,146,0,0q�6I   $	��Top=�6^   $	��237��6v   $��36��6�   $��2��6�   �� 5(      -   5        $��StyleBox��5(      $
��Left=�6+   $��139,213,0,0q�6F   $	��Top=�6[   $	��237��6s   $��36��6   $��2��6�   5)      5*      5+      5,      