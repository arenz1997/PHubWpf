   M S B A M L   `   `   `  ����E  AChatHubWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ChatHubWPF
ChatHubWPF  5   	       ChatHubWPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:ChatHubWPF     5   	   u qTelerik.Windows.Controls.EntityFramework, Version=2019.2.618.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7j fTelerik.Windows.Controls.Data, Version=2019.2.618.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7n jTelerik.Windows.Controls.GridView, Version=2019.2.618.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7{ wTelerik.Windows.Documents.FormatProviders.Xaml, Version=2019.2.618.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7{	 wTelerik.Windows.Documents.FormatProviders.Html, Version=2019.2.618.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7q
 mTelerik.Windows.Controls.ImageEditor, Version=2019.2.618.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7~ zTelerik.Windows.Documents.FormatProviders.OpenXml, Version=2019.2.618.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7a ]Telerik.Windows.Data, Version=2019.2.618.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Input, Version=2019.2.618.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7e aTelerik.Windows.Controls, Version=2019.2.618.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Documents.Core, Version=2019.2.612.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7s oTelerik.Windows.Controls.RichTextBoxUI, Version=2019.2.618.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7p lTelerik.Windows.Controls.Navigation, Version=2019.2.618.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7z vTelerik.Windows.Documents.FormatProviders.Rtf, Version=2019.2.618.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Media, Version=2019.2.618.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7f bTelerik.Windows.Documents, Version=2019.2.618.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7]telerik1http://schemas.telerik.com/2008/xaml/presentation     	 
           5   	     � Title$  ChatHub��5	   	   $	��450��6   $	��640��6&    � 
ResizeMode$ NoResize=�62    � WindowStartupLocation$ CenterScreen=�6H    � WindowStyle$
 None=�6m    � Icon$ Images/Favicon.png��6�   ��5
      �� 5   
   .��5      �  � OverridesDefaultStyle . $��	0,0,0,-15q�6(   ��5   
   �� 5       �� ImageSource$' !Images/RegistrationBackground.png��6   .+�5   
   � $
��Left=�6   $��60��6*   $	��Top=�66   $	��683��6N   ���	#FF101213.+�5      $  Telerik.Windows.Controls.Label  $��ChatHub��6   $
��Left=�6.   $	��Top=�6I   $��68��6a   $��
64,-4,0,-4q�6m   $	��202��6�   $��Comic Sans MS)�6�   $��40(�6�   
�������6�   �� 5      $
��Left=�6   $��50��6/   $	��Top=�6;   $��50��6S    J� RenderTransformOrigin$ 
0.885,0.81&�6^   $��Images/Favicon.png��6�   $��6,6,0,0q�6�   �� 5      -   5         ��Name$ ButtonClose��5      $��30��6)   $��
0,16,61,14q�65   $��Images/close.png��6I   $ 2.023,-0.566&�6�   	 � Cursor$
	 Hand��6�   $��Right=�6�   $��30��6�   
 J� OpacityMask
 5      �� 5      $ Images/close.png��6!   5      �� 5      -   5        $ ButtonMinimize��5      $��30��6,   $��
0,20,100,0q�68   $��Images/minimize.png��6L   $ 2.023,-0.566&�6i   $
	 Hand��6�   $��Right=�6�   $��30��6�   $	��Top=�6�   
 5      �� 5      $ Images/minimize.png��6!   5      5         5!   
   $��Sign In��6   $
��Left=�6*   $	��Top=�6E   $��	68,96,0,0q�6]   $��80��6p   $	��223��6|   $��Garamond)�6�   $��40(�6�   $
��Bold"�6�   
�������6�   2  ,Telerik.Windows.Controls.RadWatermarkTextBox  5"   
   -   5          Name$ SignInUsernameBox��5"   &   $
��Left=�6A   $��60��6\    �� TextWrapping$
 Wrap=�6h   $��Username��6|   $	��Top=�6�   $	��180��6�   $��
68,178,0,0q�6�      CurrentText$ Username��6�   
�������$��15(�6�   $
��Bold"�6�   ���	#FF1D1D1D$��1��6%  6�  -  'Telerik.Windows.Controls.RadPasswordBox  5#   
   -   5          Name$ SignInPasswordBox��5#   !   $
��Left=�6<   $��60��6W      Password$ password��6c   $
 Wrap=�6w   $��RadPasswordBox��6�   $	��Top=�6�   $	��180��6�      WatermarkContent$ Enter password��6�   $��
68,242,0,0q�6�   $ 0.675,0.789&�6�   $ ""��6  
�������$��15(�6M  $
��Bold"�6[  ���	#FF1D1D1D$��2��6�  6�  (  "Telerik.Windows.Controls.RadButton  5$   
   -   5          Name$ LoginButton��5$      $��Log in��61   $
��Left=�6B   $��50��6]   $	��Top=�6i   $	��180��6�   $ 1.571,5.386&�6�   $��
68,322,0,0q�6�   $��25(�6�   $��Elephant)�6�   
�������$
	 Hand��6  ���	#FF101213$��3��6:    5%   
   $��Sign Up��6   $
��Left=�6*   $	��Top=�6E   $��
348,93,0,0q�6]   $��81��6q   $	��277��6}   $��Garamond)�6�   $��40(�6�   $
��Bold"�6�   
�������6�     5&   
   -   5        $ SignUpNameBox��5&   &   $
��Left=�6=   $��43��6X   $
 Wrap=�6d   $	��Top=�6x   $	��216��6�   $��352,176,0,0q�6�   $ Username��6�   $
��Name��6�   
�������$��15(�6�   $
��Bold"�6�   ���	#FF1D1D1D$��4��6  6�    5'   
   -   5        $ SignUpEmailBox��5'   &   $
��Left=�6>   $��43��6Y   $
 Wrap=�6e   $	��Top=�6y   $	��216��6�   $��352,224,0,0q�6�   $ Username��6�   $��Email��6�   
�������$��15(�6�   $
��Bold"�6�   ���	#FF1D1D1D$��5��6   6�    5(   
   -   5        $ SignUpUsernameBox��5(   &   $
��Left=�6A   $��43��6\   $
 Wrap=�6h   $	��Top=�6|   $	��216��6�   $��352,278,0,0q�6�   $ Username��6�   $��Username��6�   
�������$��15(�6�   $
��Bold"�6�   ���	#FF1D1D1D$��6��6&  6�    5)   
   -	   5        $ RegistrationButton��5)      $��Registration��68   $
��Left=�6O   $��50��6j   $	��Top=�6v   $	��221��6�   $ 1.571,5.386&�6�   $��348,392,0,0q�6�   $��30(�6�   $��Elephant)�6�   
�������$
	 Hand��6*  ���	#FF101213$��8��6O    5*   
   -
   5        $ SignUpPasswordBox��5*   !   $
��Left=�6<   $��43��6W   $ password��6c   $
 Wrap=�6w   $��RadPasswordBox��6�   $	��Top=�6�   $	��216��6�   $ Enter password��6�   $��352,331,0,0q�6�   
�������$��15(�6  $
��Bold"�6  ���	#FF1D1D1D$��7��6F  6�  5+      5,      