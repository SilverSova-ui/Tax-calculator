   M S B A M L   `   `   `  ���� I  ETax calculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Tax_calculatorTax_calculator  "    Tax_calculator.Transport_Tax   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:Tax_calculator       � WindowStartupLocation$  CenterScreen=� � 
ResizeMode$ NoResize=� � Title$D >Калькулятор транспортного налога��$	��540��$	��800�� � Icon$ Tax_Icon.png��.��� .+��� -    ��Name$ title��$
��Left=�$��
260,38,0,0q�$
��Wrap=�$D��>Калькулятор транспортного налога��$	��Top=�$��18(��� -    ��Name$
 exit��$
��Left=�$��43��$��	37,38,0,0q�$	��Top=�$��45��$��Strelka.png���� -    ��Name$	 sum��$��
Сумма��$
��Left=�$��184,113,0,0q�$	��Top=�$��16(��� -    ��Name$ t_sum��$
��Left=�$��33��$��289,113,0,0q� �� TextWrapping$
 Wrap=�$�� ��$	��Top=�$	��291��$��16(��� -   $ Region��$��Регион��$
��Left=�$��181,159,0,0q�$	��Top=�$��16(��� -   	 ��Name$	 combo_Region��$
��Left=�$��289,159,0,0q�$	��Top=�$	��291��$��31��.@��� .��Москва�� .��!Тульская область�� .��Санкт-Петербург�� .��
Крым�� -   $ Term_of_ownership��$(��"Срок владения, мес.��$
��Left=�$��
84,206,0,0q�$	��Top=�$��16(��� -   $	 combo_Term_of_ownership��$
��Left=�$��289,206,0,0q�$	��Top=�$	��291��$��31���� -	   $ Power��$ ��Мощность в л.с.��$
��Left=�$��114,251,0,0q�$	��Top=�$��16(��� -
   $ t_Power��$
��Left=�$��31��$��289,251,0,0q�$�� ��$	��Top=�$	��291��$��16(��� -   $ Price��$,��&Цена автомобиля, руб.��$
��Left=�$��
64,298,0,0q�$	��Top=�$��16(��� -   $	 combo_Price��$
��Left=�$��31��$��289,298,0,0q�
 �� Text$
  ��$	��Top=�$	��291��$��16(�.@��� .��Нет�� .��#!От 3000000 до 5000000 руб.�� .��$"От 5000000 до 10000000 руб.�� .��%#От 10000000 до 15000000 руб.�� .��Более 15000000 руб.�� -   $ result��$:��4Размер транспортного налога��$
��Left=�$��
11,349,0,0q�$	��Top=�$��16(��� -   $ t_result��$
��Left=�$��289,354,0,0q�$
��Wrap=�$�� ��$	��Top=�$��16(��� -   $ Remaining_sum��$%��Оставшаяся сумма��$
��Left=�$��
95,398,0,0q�$	��Top=�$��16(��� -   $ t_Remaining_sum��$
��Left=�$��289,403,0,0q�$
��Wrap=�$�� ��$	��Top=�$��16(��� -    ��Name$ Calculation��$��Расчет��$
��Left=�$��354,449,0,0q�$	��Top=�$��75��$��16(�