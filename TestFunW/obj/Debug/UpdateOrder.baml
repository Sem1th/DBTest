   M S B A M L   `   `   `  ����C  ?TestFunW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:TestFunWTestFunW  5   	       TestFunW.UpdateOrder   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   
   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:TestFunW     5   	     � Title$  WindowOrderUpdate��5   	   $��256.118��6#   $��503.782��64    � 
ResizeMode$ NoResize=�6D    � WindowStartupLocation$ CenterScreen=�6Z   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��119* �6   �� 5      $
��130* �6   .+�5   
   �� $��Номер заказа��6   $
��Left=�6'   $��	41,31,0,0q�6B   $	��Top=�6U   �� 5   
   $#��Название товара��6   $
��Left=�6*   $��
187,31,0,0q�6E   $	��Top=�6Y   $��2��6q   �� 5   
   $��Сотрудник��6   $
��Left=�6$   $��127.587,31,0,0q�6?   $	��Top=�6W   $��1��6o   �� 5   
   -   5         ��Name$ tbNumberUPD��5      $
��Left=�6'   $��23��6B   $��	28,76,0,0q�6N    �� TextWrapping$
 Wrap=�6a   $�� ��6u   $	��Top=�6}   $	��120��6�   �� 5   
   -   5        $ 	tbNameUPD��5      $
��Left=�6%   $��23��6@   $��
187,77,0,0q�6L   $
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��120��6�   $��2��6�   �� 5   
   -   5         ��Name$ comboSTAFFUPD��5       �� SelectedValuePath$ Id��6B    �� DisplayMemberPath$ Surname��6Y   $��121.587,77,18,0q�6u   $	��Top=�6�   $	��120��6�   	 �� 
IsEditable	 . $��1��6�   ��6*   �� 6�   �� 5   
   -   5        
 ��Name$
 	btSaveUPD��5      $+��%Сохранить изменения��6$   $
��Left=�6B   $��
63,176,0,0q�6]   $	��Top=�6q   $	��180��6�   ���	#FF44C514$��2��6�   �� 5   
   -   5        $
 
btCloseUPD��5      $��Отмена��6%   $
��Left=�66   $��71.587,176,0,0q�6Q   $	��Top=�6i   $	��125��6�   ���	#FFFF7F7F$��1��6�   5      5      