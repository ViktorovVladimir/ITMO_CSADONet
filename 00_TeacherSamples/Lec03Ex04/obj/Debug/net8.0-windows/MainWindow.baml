   M S B A M L   `   `   `  ����D  @Lec03Ex02, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Lec03Ex02	Lec03Ex02  5   	       Lec03Ex02.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Lec03Ex02     5   	   -   5          � Title$  Connection Pools��5   	   $	��800��6"   $
��1200��6/   .��5	      � .+�5
   
   �� -   5         ��Name$ lstConnections��5
      $��	0,371,0,0q�6+   ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value 63   �� *Color+5       � ContextMenu 5      �� 5      .@�5      m� -   5        $��Open Connection��5       m� CommandParameter 6U   ��  �� RelativeSource ��  �� AncestorType" ��m� 5      -   5        $��Change Context��5       6S   ��  �� " ��m� 5      -   5        $��Close Connection��5       6W   ��  �� " ��m� 5      -   5        $!��Close and Remove Connection��5       6c   ��  �� " ��5      	 �� View	 5      �� 5      .P�5      �� 
 �� Width$
 40��6%   $��ID��60    �� DisplayMemberBinding 6<   �� *ID+�� 5      $	
 120��6%   $��Provider��61    6C   �� *
Provider+�� 5      $	
 800��6%   $��Connection String��61    6L   �� *Connection.ConnectionString+�� 5      $	
 100��6%   $��Previous State��61    6I   �� *PreviousState+�� 5      $	
 100��6%   $��Current State��61    6H   �� *Connection.State+5      5!      �� 5"   
   $��Connections:��6   $
��Left=�6'   $��
10,340,0,0q�6B   $	��Top=�6V   �� 5#   
   -   5        $ lstConnectionStrings��5#      $��0,182,0,449q�61   ��5$      �� 5%      " ��6   .�5&      ��  � �� 63   �� *Color+5'       5)      �� 5*      .@�5+      m� -   5        $��Create Connection��5+       6Y   ��  �� " ��m� 5,      -	   5        $��Remove Connection String��5,       6f   ��  �� " ��5-      	 5/      �� 50      .P�51      �� $
 40��6%   $��ID��60    6<   �� *ID+�� 52      $	
 150��6%   $
��Name��61    6?   �� *Name+�� 53      $	
 150��6%   $��Provider��61    6C   �� *
Provider+�� 54      $	
 800��6%   $��Connection String��61    6L   �� *ConnectionStringValue+55      57      �� 58   
   -
   5         ��Name$ lblConnectionStrings��58      $��Connection Strings:��6.   $
��Left=�6L   $��	4,151,0,0q�6g   $	��Top=�6z   �� 59   
   -   5        $ 	lblServer��59      $��Server:��6#   $
��Left=�65   $��
165,92,0,0q�6P   $	��Top=�6d   �� 5:   
   -   5        $ lblDatabase��5:      $��	Database:��6%   $
��Left=�69   $��
348,92,0,0q�6T   $	��Top=�6h   �� 5;   
   -   5        $ lblProvider��5;      $��	Provider:��6%   $
��Left=�69   $��4,92,0,0q�6T   $	��Top=�6f   �� 5<   
   -   5        $ lblOther��5<      $��Other options:��6"   $
��Left=�6;   $��
550,92,0,0q�6V   $	��Top=�6j   �� 5>   
   -   5         ��Name$ 	txtServer��5>      $
��Left=�6%   $��
211,96,0,0q�6@    �� TextWrapping$
 Wrap=�6T   $	��Top=�6h   $	��120��6�   �� 5?   
   -   5        $ txtDatabase��5?      $
��Left=�6'   $��
415,96,0,0q�6B   $
 Wrap=�6V   $	��Top=�6j   $	��120��6�   �� 5@   
   -   5        $ txtOther��5@      $
��Left=�6$   $��
636,96,0,0q�6?   $
 Wrap=�6S   $	��Top=�6g   $	��375��6   .��6�    � ToolTip 5A      _� 5B      .��5C      ]� .+�5E      �� Try the following options:�� 5F      For SQL Server�� 5H      -------------�� 5J      Integrated Security=True;�� 5L      Integrated Security=SSPI;�� 5N      Pooling=False;�� 5P      Min Pool Size=5;�� 5R      Max Pool Size=3;�� 5T      ,*Connect Timeout=1;Connection Lifetime=120;�� 5V      �� 5W      For PostgreSQL�� 5Y      -------------�� 5[      Persist Security Info=False;�� 5]      Persist Security Info=True;5_      5`      5a      .��5b      5c      �� 5d   
   -   5         ��Name$ btnAddConnectionString��5d      $��Add connection string��61   $
��Left=�6Q   $��1041,95,0,0q�6l   $	��Top=�6�   6�   �� 5e   
   -   5        $��panelRadioProvider��5e      $��61,64,1040,620q�6/    � 	Resources 5f      ��%X   '	�       �� 5g      " 	�6   .�5h      ��  � ��$ 0,10,0,0q�6/   5i      5j      .+�5k      	� -   5         	�Name$ radioSQLServer��5k      $��
SQL Server��62   $
��Left=�6G   $	��Top=�6b    	� 	GroupName$ Provider��6z    d� 	IsChecked$
 TrueY�6�   	� 5l      -   5        $ radioPostgreSQL��5l      $��
PostgreSQL��63   $
��Left=�6H   $	��Top=�6c   $ Provider��6{   	� 5m      -   5        $ 
radioMySQL��5m      $��MySQL��6.   $
��Left=�6>   $	��Top=�6Y   $ Provider��6q   5n      5o      5p      