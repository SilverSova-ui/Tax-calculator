   M S B A M L   `   `   `  ���� I  ETax calculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Tax_calculatorTax_calculator      Tax_calculator.IncomeTax   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:Tax_calculator       � WindowStartupLocation$  CenterScreen=� � 
ResizeMode$ NoResize=� � Title$= 7Калькулятор налога на прибыль��$	��436��$	��692�� � Icon$ Tax_Icon.png��.��� .+��� -    ��Name$ title��$
��Left=�$��
199,27,0,0q�$
��Wrap=�$=��7Калькулятор налога на прибыль��$	��Top=�$��18(��� -    ��Name$
 exit��$
��Left=�$��43��$��	37,38,0,0q�$	��Top=�$��45��$��Strelka.png���� -    ��Name$ rate_Tax��$>��8Коэффициент налога
на прибыль��$
��Left=�$��
76,106,0,0q�$	��Top=�$��16(��� -    ��Name$ 
t_rate_Tax��$
��Left=�$��28��$��264,117,0,0q� �� TextWrapping$
 Wrap=�$�� ��$	��Top=�$	��327��$��16(��� -   $ sum_Expenses��$!��Сумма Расходов��$
��Left=�$��106,213,0,0q�$	��Top=�$��16(��� -   $ t_sum_Expenses��$
��Left=�$��30��$��264,213,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��327��$��16(��� -   $ sum_Revenue��$��Сумма Доходов��$
��Left=�$��110,164,0,0q�$	��Top=�$��16(��� -   $ t_sum_Revenue��$
��Left=�$��30��$��264,165,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��327��$��16(��� -	   $
 work��$2��,Оплата труда работникам��$
��Left=�$��
39,259,0,0q�$	��Top=�$��16(��� -
   $ t_work��$
��Left=�$��30��$��264,259,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��327��$��16(��� -   $	 Tax��$$��Налог на прибыль��$
��Left=�$��
91,306,0,0q�$	��Top=�$��16(��� -   $ t_Tax��$
��Left=�$��264,311,0,0q�$
��Wrap=�$�� ��$	��Top=�$��16(��� -   	 ��Name$	 Calculation��$��Расчет��$
��Left=�$��310,350,0,0q�$	��Top=�$��75��$��16(�