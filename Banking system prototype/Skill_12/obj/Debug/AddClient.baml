   M S B A M L   `   `   `  ����C  ?Skill_12, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Skill_12Skill_12  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	       Skill_12.AddClient   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Skill_12     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5   	    � Title$ 	AddClient��5
   	   $	��740��6   $	��430��6(    � 	Resources 5         FontSizeText 
 Height��%H   &	        &	      X�5   
   20Q�6.   X�5   
   25Q�6(   5      .��5      � 
���OO/�.+�5   
   �� .+�5      �� $��20, 5, 20, 15q�6   #��[ 5      $+��%Введите имя клиента:��6:   
�������#��[  5      �� 5      -   5         ��Name$ TbFirstName��5      $	��390��5      #��[ 5      $��20,-10,20,15q�5      
�������#��[  5      �� 5      $��20, 0, 20, 15q�6   #��[ 5      $3��-Введите фамилию клиента:��5      
�������#��[  5      �� 5       -   5        $ 
TbLastName��5       $	��390��5!      #��[ 5"      $��20,-10,20,20q�5#      
�������#��[  5%      �� 5&      $��20, 0, 20, 15q�6   #��[ 5'      $5��/Введите отчество клиента:��5(      
�������#��[  5*      �� 5+      -   5        $ TbPatrynomic��5+      $	��390��5,      #��[ 5-      $��20,-10,20,15q�5.      
�������#��[  50      �� 51      $��20, 0, 20, 15q�6   #��[ 52      $@��:Введите номер телефона клиента:��53      
�������#��[  55      �� 56      -   5        $ TbPhoneNumber��56      #��[ 57      $��20,-10,20,15q�58      
�������#��[  5:      �� 5;      $��20, 0, 20, 15q�6   #��[ 5<      $@��:Введите серию паспорта клиента:��5=      
�������#��[  5?      �� 5@      -   5        $ TbPassportSeries��5@      #��[ 5A      $��20,-10,20,15q�5B      
�������#��[  5D      �� 5E      $��20, 0, 20, 15q�6   #��[ 5F      $@��:Введите номер паспорта клиента:��5G      
�������#��[  5I      �� 5J      -   5        $ TbPassportID��5J      $	��390��5K      #��[ 5L      $��20,-10,20,15q�5M      
�������#��[  5O      �� 5P      $��20, 0, 20, 15q�6   #��[ 5Q      $)��#Выберите тип счета:��5R      
�������#��[  5T      �� 5U      -   5         ��Name$ CbTypeOfAccount��5U      $��20, 0, 20, 15q�5V      $��30��5W      
�������$��15(�5Y      .@�5Z      �� $��Депозитный��6   �� 5[      $��Не депозитный��6   5\      �� 5]      $��20, 0, 20, 15q�6   #��[ 5^      $3��-Выберете статус клиента:��5_      
�������#��[  5a      �� 5b      -	   5        $ Status��5b      $��20, 0, 20, 15q�5c      $��30��5d      
�������$��15(�5f      .@�5h      �� $#��Обычные клиенты��6   �� 5i      $��VIP клиенты��6   �� 5j      $%��Юридические лица��6   5k      5m      �� 5n   
   -
   5         ��Name$ Finish��5n      $��Comic Sans MS)�5o      $��10,614,10,10q�5p      ��5q      �� 5r       �� 
TargetType" ��6"   .R�5s      � $��	0,-20,0,0q�6   .+�5t      �� 
������ $��3q�6:   ���	#FFABADB3 �� CornerRadius$ 3��6f   ._�5u      �� 
�������6(   5v      �� 5x      $��Подтвердить��5y      $��Center=�5z      $��Center=�5{      $��30(�5|      $��Comic Sans MS)�5}      $
��Bold"�5~      
�������$	��210��5   0    �� TextAlignment$ Center=�5�      5�      5�      5�      5�      5�      