   M S B A M L   `   `   `  ���� H  DTransportTask, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:vectorvector      vector.LoginWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     &localclr-namespace:vector     P LModernWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=c99d0cfbea7491efCustomhttp://modernwpf  -     � WindowStartupLocation$  CenterScreen=�   ModernStyle#���    � Title$ Login��$	��131��$	��385�� � 
ResizeMode$ NoResize=� � Icon$" Resources/icon1_XfI_icon.ico�� � 	Resources   StoryboardError �� TargetProperty �� 
TargetName<  6System.Windows.Media.Animation.EasingThicknessKeyFrame p� KeyTime p� Value	 �� 
TargetType  ModernWPF.Chrome
 �� Property �� Value   ActiveBorderBrush   InactiveBorderBrush  Button.Static.Background �� Color  Button.MouseOver.Background  Button.Pressed.Background  Button.Disabled.Background  ButtonStyle1 �� 
TargetType ��Name J� SnapsToDevicePixels ��Name �� Triggers P� Property P� Value �� 
TargetName  TextBox.MouseOver.Border  TextBox.Focus.Border 	 TextBoxStyle1-  'System.Windows.Input.KeyboardNavigation �� Padding ��Name3  -System.Windows.Media.Effects.DropShadowEffect   ShadowDepth   Color �� Triggers ]� 
Conditions �� Property �� Value 
 MinMaxCloseRestore  TextBox.Static.Border  TextBox.MouseOver.Border2  TextBox.Focus.Border2  PasswordBoxStyle1��%�  &	       &	  J    &	 �    &	 �    &	 �    &	     &	 &    7  7  7  7  &	 B    &	 W    &		 l    7  7  &	
 �    &	 @	    &	 U	    &	 j	    &	 	    7  7  7  �� .��r� $ (FrameworkElement.Margin)�$ 
ErrorBlock��.	�  $ 0��$ 0,8,0,0q�  $ 0:0:0.16��$ 0,8,25,0q�  $ 0:0:0.32��$ 25,8,0,0q�  $ 0:0:0.48��$ 0,8,10,0q�  $ 0:0:0.64��$ 10,8,0,0q�  $ 0:0:0.8��$ 0,8,0,0q�  $ 0:0:3��$ 0,8,0,0q�  $ 0:0:3.16��$ 0,8,0,0q��� "	 �.��� 
 �@ CaptionHeight$ 20Q��� 
 �@ Chrome    �	#FF4E8FCD �	#BB888888�� 
 � ��
 ������� $ 	#FFDDDDDD���� $ 	#FF00A800���� $ 	#FF00A207���� $ 	#FFF4F4F4���� "	 ��.��� 
 � ��8   �� 
 � ��# � ���� 
 � ��$ 1q��� 
 � ��$ Center=��� 
 � ��$ Center=��� 
 � ��$ 1q��� 
 � �� �� " ��.R��� $ border��#��z��#��z��#��z�� . ._��� $ contentPresenter��|�.  #��z��#��z����. # z #��z�� P�  �@��IsDefaulted . . ��� $ border��# � ��
 � ��P�  �@J�IsMouseOver . . ��� $ border��8  
 � ��P�  � �� . . ��� $ border��8  
 � ��P�  � {� .  . ��� $ border��8  
 � ���� $ 	#FF274D70���� $ 	#FF274D70���� "	 ��.��� 
 � ��# � ���� 
 � ��# � ���� 
 � ��# � ���� 
 � ��$ 1q��� 
 �@ TabNavigation$
 None=��� 
 � ��$
 Left=��� 
 �@�FocusVisualStyle Z� �� 
 �@J�	AllowDrop . �� 
 �@��PanningMode$ VerticalFirst=��� 
 �@��IsFlicksEnabled .  �� 
 � �� �� " ��.R��� $ border��$ 0,2,0,0q�#��z��#��z��#��z�� . ._��� $ PART_ContentHost��|�.  $��Hidden=�$��Hidden=�$��0q� P�  � {� .  . ��� $ border��
 �@J�Opacity$
 0.56Q�P�  �@J�IsMouseOver . . ��� $ border��8   
 � ��P�  �@J�IsKeyboardFocused . . ��� $ border��8  
 � ���� 
 �@J�Effect   $ 0Q�$ 	#FF569DE5�� ]�  �� + �@��#IsInactiveSelectionHighlightEnabled . ��  �@��IsSelectionActive .  ./��� 
 �@��SelectionBrush# � /��� "	 ��.��� 
 � |� .  �� 
 �@ IsHitTestVisible . �� 
 � �� �� " ��.R��� $ border��#��z��$��0q� . ._��� $ contentPresenter��|�.  $��Center=���. # z #��z�� P�  �@J�IsMouseOver . . ��� $ border��
 � �� �	#3F8D8D8DP�  � �� . . ��� $ border��
 � �� �	#5FFFFFFF�� $ 	#FFABAdB3���� $ 	#FF7EB4EA���� $ 	#FF569DE5���� "	 G�.��� 
 �@G�PasswordChar$	 ●���� 
 � ��# � ���� 
 � ��8   �� 
 � ��# � ���� 
 � ��$ 1q��� 
 �@ TabNavigation$
 None=��� 
 � ��$
 Left=��� 
 �@�FocusVisualStyle Z� �� 
 �@J�	AllowDrop . �� 
 �@��PanningMode$ VerticalFirst=��� 
 �@��IsFlicksEnabled .  �� 
 � �� �� " G�.R��� $ border��#��z��#��z��#��z�� . ._��� $ PART_ContentHost��|�.  $��Hidden=�$��Hidden=�$��0,3,0,0q�$��0,3,0,0q� P�  � {� .  . ��� $ border��
 �@J�Opacity$
 0.56Q�P�  �@J�IsMouseOver . . ��� $ border��8  
 � ��P�  �@J�IsKeyboardFocused . . ��� $ border��8  
 � ���� 
 �@J�Effect   $ 0Q�$ 	#FF569DE5�� ]�  �� + �@G�#IsInactiveSelectionHighlightEnabled . ��  �@G�IsSelectionActive .  ./��� 
 �@G�SelectionBrush# � /�.��� ���	#FF343434.+��� $
��Left=�$	��Top=�$"��Resources/icon1_XfI_icon.ico��$��0.5,0.5,0,0q�$��32�� J� Opacity$
 0.75Q��� $
��Left=�$��	30,40,0,0q�$
��Wrap=�$��Логин:��$	��Top=�
��������� $
��Left=�$��	22,77,0,0q�$
��Wrap=�$��Пароль:��$	��Top=�
��������� -     ��Name$  	TboxLogin��$��
84,35,87,0q�! �� TextWrapping$
! Wrap=�$	��Top=�$��14(�#��� 	 ���	#FF2A2A2A���	#FF2A2A2A
�������$��26��$��1q�G� -   " G�Name$" TboxPswd��$��
84,72,87,0q�$	��Top=�$��26��#���  ���	#FF2A2A2A���	#FF2A2A2A
�������$��1q��� -   # ��Name$# BtnLogin��$��	0,72,40,0q�$	��Top=�$��26��#���  $��0q����	#FF349334
�������$��Right=�$��47��.��F� 
�������a����@�}@]� Ѡ��    ���)    �@���n� �    �n� �     �� �@�� �� ���)�3�Ѡ���3��@�}@]� 	$��Center=�$��Center=�$ �� Stretch$
$ Fill=�$��7��$��10���� -   $# ButtonClose��$��34��$	��Top=�#��� 
 $��0q�$��26��$��Right=����	#00000000$��0q���Z� ��Z� .��F� $��10��$��Center=�$��0��$
$ Fill=�$��0,2,0,0q�$��8��$��Center=�
�������|����@�e�� � ��@KL ��M��� �@���� �@ɢ��[ �@����� ��M���� � ����j �@�e��� ��;G��� ��D���[ ��;G�� �@�e�� �� -   % ��Name$% 
ErrorBlock��& J� IsHitTestVisible& .  
���  ��$��Center=�$
��Wrap=�$	��Top=�$��0,8,0,0q�$��14(�' �� TextAlignment$' Center=��� -   ( ��Name$( 	labelLang��$��18,6,0,0q�$��RU��$��	0,35,40,0q�$	��Top=�
����������	#FF444343$��Right=�$��26��$��10(�$��47�����	#FF274D70$��0q��� -   $( 	labelCaps��$��0q�$��	0,72,89,0q�$	��Top=�
����������	#7FFF5353$��Right=�$��13��$��9(�$��41��$��	Caps Lock��$��0q�
�������