   M S B A M L   `   `   `  ���� I  ETax calculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Tax_calculatorTax_calculator      Tax_calculator.NDFL   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:Tax_calculator       � WindowStartupLocation$  CenterScreen=� � 
ResizeMode$ NoResize=� � Title$% Калькулятор НДФЛ��$	��392��$	��800�� � Icon$ Tax_Icon.png��.��� .+��� -    ��Name$ title��$
��Left=�$��
330,37,0,0q�$
��Wrap=�$%��Калькулятор НДФЛ��$	��Top=�$��18(��� -    ��Name$
 exit��$
��Left=�$��43��$��	40,56,0,0q�$	��Top=�$��45��$��Strelka.png���� -    ��Name$	 Sum��$��
Сумма��$
��Left=�$��
90,120,0,0q�$	��Top=�$��16(��� -    ��Name$ t_Sum��$
��Left=�$��30��$��165,120,0,0q� �� TextWrapping$
 Wrap=�$�� ��$	��Top=�$	��231��$��16(��� -   $ tax_rate��$%��Налоговая ставка��$
��Left=�$��430,120,0,0q�$	��Top=�$��16(��� -   	 ��Name$	 
combo_rate��$
��Left=�$��596,120,0,0q�$	��Top=�$	��120��$��16(��� -   $ Tax_fee��$!��Налоговый сбор��$
��Left=�$��264,190,0,0q�$	��Top=�$��16(��� -   $ 	t_Tax_fee��$
��Left=�$��419,195,0,0q�$
��Wrap=�$�� ��$	��Top=�$��31��$��16(��� -	   $ Remaining_sum��$%��Оставшаяся сумма��$
��Left=�$��249,226,0,0q�$	��Top=�$��16(��� -
   $ t_Remaining_sum��$
��Left=�$��419,231,0,0q�$
��Wrap=�$�� ��$	��Top=�$��16(��� -   
 ��Name$
 Calculation��$��Расчет��$
��Left=�$��370,285,0,0q�$	��Top=�$��75��$��16(�