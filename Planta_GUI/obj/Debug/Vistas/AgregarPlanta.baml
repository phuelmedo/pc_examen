   M S B A M L   `   `   `  ����E  APlanta_GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Planta_GUI.VistasPlanta_GUI.Vistas  5   	   %    Planta_GUI.Vistas.AgregarPlanta   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Planta_GUI.Vistas     5   	     � Title$  AgregarPlanta��5   	   $	��450��6   $	��800��6,   .��5	      � .+�5
   
   �� -   5         ��Name$ lblNombreComun��5
      $��Nombre Comun��6(   $
��Left=�6?   $��	73,81,0,0q�6Z   $	��Top=�6m   �� 5   
   -   5        $ lblNombreCientifico��5      $��Nombre Cientifico��6-   $
��Left=�6I   $��
73,112,0,0q�6d   $	��Top=�6x   �� 5   
   -   5        $ lblTipoPlanta��5      $��Tipo Planta��6'   $
��Left=�6=   $��
73,143,0,0q�6X   $	��Top=�6l   �� 5   
   -   5        $ lblDescripcion��5      $��Descripcion��6(   $
��Left=�6>   $��
73,174,0,0q�6Y   $	��Top=�6m   �� 5   
   -   5        $ lblTiempoRiego��5      $��Tiempo Riego��6(   $
��Left=�6?   $��
73,205,0,0q�6Z   $	��Top=�6n   �� 5   
   -   5        $ lblCantidadAgua��5      $��Cantidad Agua��6)   $
��Left=�6A   $��
73,236,0,0q�6\   $	��Top=�6p   �� 5   
   -   5        $ lblEpoca��5      $��Epoca��6"   $
��Left=�62   $��
73,268,0,0q�6M   $	��Top=�6a   �� 5   
   -   5        $ lblEsVenenosa��5      $��Es Venenosa��6'   $
��Left=�6=   $��
73,300,0,0q�6X   $	��Top=�6l   �� 5   
   -	   5        $ lblEsAutoctona��5      $��EsAutoctona��6(   $
��Left=�6>   $��
73,332,0,0q�6Y   $	��Top=�6m   �� 5   
   -
   5         ��Name$ txtNombreComun��5      $
��Left=�6*   $��
179,85,0,0q�6E    �� TextWrapping$ NoWrap=�6Y   $	��Top=�6o   $	��519��6�   ��6�   �� *NombreComun+ �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnDataErrors .  � ToolTip 6�   �� *ErrorCollection[NombreComun]+�� 5   
   -   5        $ txtNombreCientifico��5      $
��Left=�6/   $��179,116,0,0q�6J   $ NoWrap=�6_   $	��Top=�6u   $	��519��6�   ��6�   �� *NombreCientifico+$ PropertyChanged=� .  6�   �� *#!ErrorCollection[NombreCientifico]+�� 5   
   -   5         ��Name$ txtTipoPlanta��5      $
��Left=�6*   $��179,143,0,0q�6E   $	��Top=�6Z   $	��519��6r    �� Text 6~   �� *
TipoPlanta+$ PropertyChanged=� .  6�   �� *ErrorCollection[TipoPlanta]+.@�5      �� $��	Herbácea��6   �� 5      $��Matorral��6   �� 5      $��Arbusto��6   �� 5      $��Árbol��6   5      �� 5   
   -   5        $ txtDescripcion��5      $
��Left=�6*   $��179,174,0,0q�6E   $ NoWrap=�6Z   $	��Top=�6p   $	��519��6�   ��6�   �� *Descripcion+$ PropertyChanged=� .  6�   �� *ErrorCollection[Descripcion]+�� 5   
   -   5        $ txtTiempoRiego��5      $
��Left=�6L   $��179,207,0,0q�6g   $ NoWrap=�6|   $	��Top=�6�   $	��519��6�   ��6�   �� *TiempoRiego+$ PropertyChanged=� .  6  �� *ErrorCollection[TiempoRiego]+�� 5   
   -   5        $ txtCantidadAgua��5      $
��Left=�6M   $��179,238,0,0q�6h   $ NoWrap=�6}   $	��Top=�6�   $	��519��6�   ��6�   �� *CantidadAgua+$ PropertyChanged=� .  6  �� *ErrorCollection[CantidadAgua]+�� 5   
   -   5        $ txtEpoca��5      $
��Left=�6%   $��179,270,0,0q�6@   $	��Top=�6U   $	��519��6m    6y   �� *Epoca+$ PropertyChanged=� .  6�   �� *ErrorCollection[Epoca]+.@�5      �� $��Verano��6   �� 5       $��Invierno��6   �� 5!      $��Otoño��6   �� 5"      $��	Primavera��6   5#      �� 5$   
   -   5        	 ��Name$	 chkEsVenenosa��5$      $��Si��6*   $
��Left=�67   $��179,305,0,0q�6R   $	��Top=�6g   
 d� 	IsChecked
 6   �� *
EsVenenosa+$ PropertyChanged=� . �� 5%   
   -   5        $	 chkEsAuctoctona��5%      $��Si��6,   $
��Left=�69   $��179,336,0,0q�6T   $	��Top=�6i   
 6�   �� *EsAuctoctona+$ PropertyChanged=� . �� 5&   
   -   5         ��Name$ btnAgregarPlanta��5&      $��Agregar planta��6+   $
��Left=�6D   $��343,380,0,0q�6_   $	��Top=�6t   {�6�   �� *DatosValidos+5'      5(      