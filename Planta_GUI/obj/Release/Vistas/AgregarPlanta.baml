   M S B A M L   `   `   `  ���� E  APlanta_GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Planta_GUI.VistasPlanta_GUI.Vistas  %    Planta_GUI.Vistas.AgregarPlanta   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     1localclr-namespace:Planta_GUI.Vistas       � Title$  AgregarPlanta��$	��450��$	��800��.��� .+��� -    ��Name$ lblNombreComun��$��Nombre Comun��$
��Left=�$��	73,81,0,0q�$	��Top=��� -   $ lblNombreCientifico��$��Nombre Cientifico��$
��Left=�$��
73,112,0,0q�$	��Top=��� -   $ lblTipoPlanta��$��Tipo Planta��$
��Left=�$��
73,143,0,0q�$	��Top=��� -   $ lblDescripcion��$��Descripcion��$
��Left=�$��
73,174,0,0q�$	��Top=��� -   $ lblTiempoRiego��$��Tiempo Riego��$
��Left=�$��
73,205,0,0q�$	��Top=��� -   $ lblCantidadAgua��$��Cantidad Agua��$
��Left=�$��
73,236,0,0q�$	��Top=��� -   $ lblEpoca��$��Epoca��$
��Left=�$��
73,268,0,0q�$	��Top=��� -   $ lblEsVenenosa��$��Es Venenosa��$
��Left=�$��
73,300,0,0q�$	��Top=��� -	   $ lblEsAutoctona��$��EsAutoctona��$
��Left=�$��
73,332,0,0q�$	��Top=��� -
    ��Name$ txtNombreComun��$
��Left=�$��
179,85,0,0q� �� TextWrapping$ NoWrap=�$	��Top=�$	��519������ *NombreComun+ �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnDataErrors .  � ToolTip �� *ErrorCollection[NombreComun]+�� -   $ txtNombreCientifico��$
��Left=�$��179,116,0,0q�$ NoWrap=�$	��Top=�$	��519������ *NombreCientifico+$ PropertyChanged=� .  �� *#!ErrorCollection[NombreCientifico]+�� -    ��Name$ txtTipoPlanta��$
��Left=�$��179,143,0,0q�$	��Top=�$	��519�� �� Text �� *
TipoPlanta+$ PropertyChanged=� .  �� *ErrorCollection[TipoPlanta]+.@��� $��	Herbácea���� $��Matorral���� $��Arbusto���� $��Árbol���� -   $ txtDescripcion��$
��Left=�$��179,174,0,0q�$ NoWrap=�$	��Top=�$	��519������ *Descripcion+$ PropertyChanged=� .  �� *ErrorCollection[Descripcion]+�� -   $ txtTiempoRiego��$
��Left=�$��179,207,0,0q�$ NoWrap=�$	��Top=�$	��519������ *TiempoRiego+$ PropertyChanged=� .  �� *ErrorCollection[TiempoRiego]+�� -   $ txtCantidadAgua��$
��Left=�$��179,238,0,0q�$ NoWrap=�$	��Top=�$	��519������ *CantidadAgua+$ PropertyChanged=� .  �� *ErrorCollection[CantidadAgua]+�� -   $ txtEpoca��$
��Left=�$��179,270,0,0q�$	��Top=�$	��519�� �� *Epoca+$ PropertyChanged=� .  �� *ErrorCollection[Epoca]+.@��� $��Verano���� $��Invierno���� $��Otoño���� $��	Primavera���� -   	 ��Name$	 chkEsVenenosa��$��Si��$
��Left=�$��179,305,0,0q�$	��Top=�
 d� 	IsChecked
 �� *
EsVenenosa+$ PropertyChanged=� . �� -   $	 chkEsAuctoctona��$��Si��$
��Left=�$��179,336,0,0q�$	��Top=�
 �� *EsAuctoctona+$ PropertyChanged=� . �� -    ��Name$ btnAgregarPlanta��$��Agregar planta��$
��Left=�$��343,380,0,0q�$	��Top=�{��� *DatosValidos+