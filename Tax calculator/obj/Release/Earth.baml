   M S B A M L   `   `   `  ���� I  ETax calculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Tax_calculatorTax_calculator      Tax_calculator.Earth   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:Tax_calculator       � WindowStartupLocation$  CenterScreen=� � 
ResizeMode$ NoResize=� � Title$> 8Калькулятор земельного налога��$	��479��$	��765�� � Icon$ Tax_Icon.png��.��� .+��� -    ��Name$ title��$
��Left=�$��
260,38,0,0q�$
��Wrap=�$>��8Калькулятор земельного налога��$	��Top=�$��18(��� -    ��Name$
 exit��$
��Left=�$��43��$��	37,38,0,0q�$	��Top=�$��45��$��Strelka.png���� -    ��Name$ 	cadastral��$/��)Кадастровая стоимость��$
��Left=�$��143,103,0,0q�$	��Top=�$��16(��� -    ��Name$ t_cadastral��$
��Left=�$��31��$��381,103,0,0q� �� TextWrapping$
 Wrap=�$�� ��$	��Top=�$	��295��$��16(��� -   $ 
Earth_rate��$4��.Ставка земельного налога��$
��Left=�$��121,158,0,0q�$	��Top=�$��16(��� -   	 ��Name$	 combo_Earth_rate��$
��Left=�$��31��$��381,158,0,0q�
 �� Text$
  ��$	��Top=�$	��295��$��16(��� -   $
 ndfl��$9��3Не облагаемая налогом сумма��$
��Left=�$��
88,216,0,0q�$	��Top=�$��16(��� -   $ t_ndfl��$
��Left=�$��31��$��381,216,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��295��$��16(��� -	   $ result��$4��.Размер земельного налога��$
��Left=�$��117,271,0,0q�$	��Top=�$��16(��� -
   $ t_result��$
��Left=�$��381,276,0,0q�$
��Wrap=�$�� ��$	��Top=�$��16(��� -   $ Remaining_sum��$%��Оставшаяся сумма��$
��Left=�$��121,319,0,0q�$	��Top=�$��16(��� -   $ t_Remaining_sum��$
��Left=�$��381,329,0,0q�$
��Wrap=�$�� ��$	��Top=�$��16(��� -    ��Name$ Calculation��$��Расчет��$
��Left=�$��329,385,0,0q�$	��Top=�$��75��$��16(�