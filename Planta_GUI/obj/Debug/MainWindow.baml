   M S B A M L   `   `   `  ����E  APlanta_GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Planta_GUI
Planta_GUI  5   	       Planta_GUI.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Planta_GUI     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ lblUsername��5
      $��Username��6%   $
��Left=�68   $��	73,81,0,0q�6S   $	��Top=�6f   �� 5   
   -   5        $ lblPassword��5      $��Password��6%   $
��Left=�68   $��
73,112,0,0q�6S   $	��Top=�6g   �� 5   
   -   5         ��Name$ txtUsername��5      $
��Left=�6'   $��
179,85,0,0q�6B    �� TextWrapping$ NoWrap=�6V   $	��Top=�6l   $	��165��6�   ��6�   �� *
Username+ �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnDataErrors .  � ToolTip 6�   �� *ErrorCollection[Username]+�� 5   
   -   5        $ txtPassword��5      $
��Left=�6'   $��179,116,0,0q�6B   $ NoWrap=�6W   $	��Top=�6m   $	��165��6�   ��6�   �� *
Password+$ PropertyChanged=� .  6�   �� *ErrorCollection[Password]+�� 5   
   -   5         ��Name$ btnLogin��5      $��Iniciar sesión��6#   $
��Left=�6<   $��159,162,0,0q�6W   $	��Top=�6l   $	��103��6�   {�6�   �� *DatosValidos+5      5      