   M S B A M L   `   `   `  ����F  BCetStudents, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:CetStudentsCetStudents  5   	       CetStudents.CourseWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:CetStudents     5   	   -   5          � Title$  CourseWindow��5   	   $	��450��6   $	��800��6+   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��150 �6   6-   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   .+�5   
   �� $��	Ders Adı��6   $
��Left=�6#   $��Center=�6>   �� 5   
   $��	Ders Kodu��6   $
��Left=�6$   $��1��6?   $��Center=�6L   �� 5   
   $��Ders Kredisi��6   $
��Left=�6'   $��2��6B   $��Center=�6O   �� 5   
   $!��Maksimum Öğrenci Sayısı��6   $
��Left=�62   $��3��6M   $��Center=�6Z   �� 5    
   -   5        $��btnCourseInsert��5    "   $��Insert��6   $��2��6W   $
��Left=�6g   $��10,0,0,0q�6�   $��4��6�   $��Center=�6�   �� 5!   
   -   5        $��btnCourseUpdate��5!   "   $��Update��6   $��2��6W   $
��Left=�6g   $��	106,0,0,0q�6�   $��4��6�   $��Center=�6�   �� 5"   
   -   5        $��btnCourseDelete��5"   "   $��Delete��6   $��2��6W   $
��Left=�6g   $��	191,0,0,0q�6�   $��4��6�   $��Center=�6�   &   System.Windows.Controls.DataGrid  5#   
   -   5        $��	grdCourse��5#      $��5��6$   $��3��61   $��3��6E   6V   �� 5$   
   -   5        $��txtCourseName��5$   "   $��1��6   $��2��67   $��Center=�6K   $�� ��6h    �� TextWrapping$
 Wrap=�6p   $��Center=�6�   $	��600��6�   �� 5%   
   -   5        $��txtCourseCode��5%   "   $��1��6   $��2��67   $��Center=�6K   $��1��6i   $�� ��6v   $
 Wrap=�6~   $��Center=�6�   $	��600��6�   �� 5&   
   -   5        $��txtCourseCredit��5&   "   $��1��6   $��2��69   $��Center=�6M   $��2��6k   $�� ��6x   $
 Wrap=�6�   $��Center=�6�   $	��600��6�   �� 5'   
   -	   5        $��txtMaxStudents��5'   "   $��1��6   $��2��68   $��Center=�6L   $��3��6i   $�� ��6v   $
 Wrap=�6~   $��Center=�6�   $	��600��6�   5)      5*      