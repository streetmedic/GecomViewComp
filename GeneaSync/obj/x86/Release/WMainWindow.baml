   M S B A M L   `   `   `  ����   GedcomViewCompare#    GedcomViewCompare.WMainWindow   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    8x,http://schemas.microsoft.com/winfx/2006/xaml    >d2http://schemas.microsoft.com/expression/blend/2008    Hmc;http://schemas.openxmlformats.org/markup-compatibility/2006    -     � Title$  GEDCOM View and Compare��$	��390��$	��700�� � WindowStyle$ ThreeDBorderWindow=����	#FFE0E0EC
���   � � Icon$> 8/GedcomViewCompare;component/Images/GVC_Logo_100x100.png��.��� ���	#00000000 � RowDefinitions �� -    �Name$ rowMenu��$��23 ��� -   $ rowInformation��$��20 ��� -   $ rowData��$
��270* ��� -   $ rowDecorator��$��10 � � ColumnDefinitions �� -   $ columnDecorator��$��10 ��� -   $ GridColumn1���� -   $ GridColumn2���� -	   $ GridColumn3��$��80 ��� -
   $ columnDecorator2��$��10 �.+�o� -   $��menuFile��$��2��$��20��$
��Left=�$	��Top=�$
��Auto�����	#FFE0E0EC.@�m� $��_File��.@�m� -   $��_Open File(s)�� m� IsCheckable .  m� -   $��_Save File(s) As...�� .  �� m� $��_Help��{�. .@�m� -   $��_About�� .  {�. �� -   $��textBoxGDI1��$��1��$��2��$��Stretch=�$��Stretch=�$��1q�" �� VerticalScrollBarVisibility$ Visible=� �� 
IsReadOnly . �� -   $��textBoxGDI2��$��2��$��2��$��Stretch=�$��Stretch=�$��1q�$ Visible=� . �� -   $��
headerGDI1��$��1��$��1��$��Stretch=�$��Stretch=��� -   $��
headerGDI2��$��1��$��2��$��Stretch=�$��Stretch=��� -   $��
buttonSort��$��Surname Sort��$��2��$��3��$��23��$
��Left=�$��0,0,0,0q�$	��Top=�$��75��	 � ToolTip$3	 -Sort entries by surname of individual persons���� -   $��buttonHighlight��$��Compare��$��2��$��3��$��23��$
��Left=�$��0,25,0,0q�$	��Top=�$��75��$;	 5Highlight persons that are available only in one file���� -   $��
buttonDiff��$��
Difference��$��2��$��3��$��23��$
��Left=�$��0,50,0,0q�$	��Top=�$��75��$B	 <Create a new document with perons available in only one file��{�.  �� -   $��buttonIntersection��$��Intersection��$��2��$��3��$��23��$
��Left=�$��0,75,0,0q�$	��Top=�$��75��$^	 XJoin the two files and create a new document, duplicate entries will be converted to one��{�.  �� -   $��buttonUnion��$��Union��$��2��$��3��$��23��$
��Left=�$��	0,100,0,0q�$	��Top=�$��75��$\	 VJoin the two files and create a new document, with all persons available in both files��{�.  