   M S B A M L   `   `   `  ����?  ;STLS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:STLSSTLS  5   	   ?$clr-namespace:STLS.View.UserControlsSTLS.View.UserControls  5   	       STLS.MainView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:STLS     5   	   3uc$clr-namespace:STLS.View.UserControls     5   	     � Title$+  %Smart Traffic Light Simulator Project��5	   	   $
��1000��67   $
��1200��6E    � WindowState$ Normal=�6R   
���"�"� � 	Resources 5
         CarAnimationStoryBoard $  AngleRotateTransformAnimationKey �� TargetProperty   CarOnMouseOverExampleTrigger :� RoutedEvent W� From	 W� To g� Duration  CarGoDataTrigger �� Value	 �� Binding
 N� EnterActions % !CarTrafficLightWarningDataTrigger  CarStopDataTrigger  RotateToRigthTransform �� Angle��%�  &	        &	      &	 d     &	 0    &	     &	 �    &	     �� 5   
   5      W� 5   
   $9 3(UIElement.RenderTransform).(RotateTransform.Angle)�6C   :� 5   
   $ 
MouseEnter��6<   .[�5      �� .��5      �� .��5      W� $ 0X�6&   $ -1000X�5   &   $ 00:00:01.500D�5   &   $ (Canvas.Top)�5   &   5      5      5      �� 5   
   $
 true��6H   	 6/   �� *IsGo+
 5      �� 5      .��5      �� .��5      W� $ 0X�6*   $	 500X�5   &   $ 00:00:01.500D�5   &   $ (Canvas.Left)�5    &   5!      5"      5$      �� 5%   
   $
 true��6^   	 6@   �� *	IsWarning+
 5&      �� 5'      .��5(      �� 5*      5+      5-      �� 5.   
   $
 true��6L   	 61   �� *IsStop+
 5/      �� 50      .��51      �� 53      54      56      V� 57   
   .~�58      �� �� 59      �� 5:      $ 32Q�6   T� 5;      5<      5=      .��5>      �  � ColumnDefinitions 5D   
   �� 5E      $��3* �6   �� 5F      $��50 �6   �� 5G      $��0.01* �6   �� 5H      $��50 �6   �� 5I      $��3* �6    � RowDefinitions 5K   
   �� 5L      $��3* �6   �� 5M      $��50 �6   �� 5N      $��0.02* �6   �� 5O      $��50 �6   �� 5P      $��3* �6   .+�5V   
   �� $��1��6   $��5q�6!   
�������
�������5W      �� 5X   
   $��3��6   $��5q�6!   
�������
�������5Y      �� 5Z   
   $��1��6   $��4��6!   $��5q�6.   
�������
�������5[      �� 5\   
   $��3��6   $��4��6!   $��5q�6.   
�������
�������5]      �� 5`   
   $��1��6   $��3��6   $��5q�6/   
�������
�������5a      �� 5c   
   $��2��6   $��Stretch=�6    �� StrokeDashArray$	 2 2R�6:   $��6��6P   
���   �	 �� X2$
 1000��6s   $��Center=�6}   �� 5e   
   $��1��6   $��4��6   $��3��6.   $��5q�6?   
�������
�������5f      �� 5g   
   $��2��6   $��4��6   $��Stretch=�6,   $	 2 2R�6J   $��6��6`   
���   �$
 1000��6�   $��Center=�6�   �� 5i   
   $��1��6   $��3��6!   $��1��65   $��3��6B   
�������
��� ���$��5q�5k   &   ._�5l      �� .+�5m      F� 
��� ���$��4��6#   ����        ��*d ��	 J� RenderTransformOrigin$ 0.5,0.5&�6O    �� Left$
 0.37��6o    �� Stretch$
 Fill=�6�   
 �� Top$ -0.092��6�   $��88.184��6�   $��92.26��6�   z�5n      V� 5o      .~�5p      �� �� 5q      �� 5r      $ 0.364Q�6*   T� 5s      5t      5v      F� 5w      
��� ���$��4��6'   ����        ��*d ��	$ 0.5,0.5&�6S   $ -13.148��6s   $
 Fill=�6�   $ 13.204��6�   $��62.972��6�   $��119.748��6�   z�5x      V� 5y      .~�5z      �� �� 5{      �� 5|      $ 108.895Q�6*   T� 5}      5~      5�      5�      5�      1   +STLS.View.UserControls.TrafficLightControlT  5�   
   -   5          Name$ FromEastToWestOrNorthTF��5�   "   $��Bottom=�6q   $��Right=�6�    � DataContext 6C   ��  �� Path$ TrafficLights[3]�6�   1   +STLS.View.UserControls.TrafficLightControlL  5�   
   -   5          Name$ FromNorthToSouthOrWestTF��5�   "   $��4��6D   $	��Top=�6   $��Right=�6�    6Q   �� $ TrafficLights[2]�6�   1   +STLS.View.UserControls.TrafficLightControlB  5�   
   -   5          Name$ FromWestToEastOrSouthTF��5�   "   $��4��6C   $��4��6P   $	��Top=�6�   $
��Left=�6�    6`   �� $ TrafficLights[0]�6�   1   +STLS.View.UserControls.TrafficLightControlR  5�   
   -   5          Name$ FromSouthToNorthOrEastTF��5�   "   $��4��6D   $��Bottom=�6�   $
��Left=�6�    6T   �� $ TrafficLights[1]�6�   �� 5�   
   -   5         ��Name$ ToNorthRoadCanvas��5�      $��1��6,   �� 5�   
   -   5        $ FromNorthRoadCanvas��5�      $��3��6.   5�      �� 5�   
   -   5        $ ToWestRoadCanvas��5�      $��4��6+   $��1��68   �� 5�   
   -   5        $ FromWestRoadCanvas��5�      $��4��6-   $��3��6:   �� 5�   
   -	   5        $ ToSouthRoadCanvas��5�      $��3��6,   $��4��69   �� 5�   
   -
   5        $ FromSouthRoadCanvas��5�      $��1��6.   $��4��6;   �� 5�   
   -   5        $ ToEastRoadCanvas��5�      $��0��6+   $��3��68   �� 5�   
   -   5        $ FromEastRoadCanvas��5�      $��0��6-   $��1��6:   �� 5�   
   -   5        $ FromEastRoadCanvas2��5�      $��0��6.   $��1��6;   �� 5�   
   $	��Top=�6   $
��Left=�6-   .+�5�      ��  �� Orientation$ 
Horizontal=�6   .+�5�      �� -   5         ��Name$ Trial1Button��5�      $��Trial 1��6/   $��2q�6A   �� 5�      -   5        $ Trial2Button��5�      $��Trial 2��6/   $��2q�6A   �� 5�      -   5        $ Trial3Button��5�      $��Trial 3��6/   $��2q�6A   5�      &   System.Windows.Controls.DataGrid  5�      $��0��6   $	��Top=�6'   $
��Left=�6?      AutoGenerateColumns .     CanUserAddRows .     CanUserDeleteRows .    �� AlternationCount$  2��5�      !   AlternatingRowBackground
! �������5�      �� *SimulatorTrials+"   Columns" 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn#   Header$# Route��6)   $   
IsReadOnly$ . 1  +System.Windows.Controls.DataGridBoundColumn%   Binding% 68   �� *Route.Route+6X     5�      $# Number Of Vehicles��6)   % 6E   �� *NumberOfVehicle+  5�      $# Go (s)��6)   % 69   �� *Route.GoTicksInSeconds+  5�      $# Stop (s)��6)   % 6;   �� *Route.StopTicksInSeconds+5�      �� 5�      -   5        $ StartSimulatorButton��5�      $
��Left=�63   $��2q�6N   .��6Y   Start simulator!6k   �� 5�      $ 
Horizontal=�6   .+�5�      �� & d� 	IsChecked& 6   �� *SmartTrafficActivated+�� 5�      $�� Activate Smart Traffic��6   5�      5�      5�      5�      