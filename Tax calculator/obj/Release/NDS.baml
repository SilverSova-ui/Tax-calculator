   M S B A M L   `   `   `  ���� I  ETax calculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Tax_calculatorTax_calculator      Tax_calculator.NDS   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:Tax_calculator       � WindowStartupLocation$  CenterScreen=� � 
ResizeMode$ NoResize=� � Title$# Калькулятор НДС��$	��486��$	��800�� � Icon$ Tax_Icon.png��.��� .+��� -    ��Name$ title��$
��Left=�$��
332,34,0,0q�$
��Wrap=�$#��Калькулятор НДС��$	��Top=�$��18(��� -    ��Name$
 exit��$
��Left=�$��43��$��	37,53,0,0q�$	��Top=�$��45��$��Strelka.png���� -    ��Name$ price��$��Цена��$
��Left=�$��
85,113,0,0q�$	��Top=�$��16(��� -    ��Name$ t_price��$
��Left=�$��31��$��154,113,0,0q� �� TextWrapping$
 Wrap=�$�� ��$	��Top=�$	��322��$��16(��� -   $ choice��$��Выбор НДС��$
��Left=�$��499,113,0,0q�$	��Top=�$��16(��� -   	 ��Name$	 combo_choice��$
��Left=�$��610,113,0,0q�$	��Top=�$	��152��$��31��.@��� $��16(�.��Выделить НДС�� $��16(�.��Начислить НДС�� -   $
 rate��$��Ставка НДС��$
��Left=�$��
85,170,0,0q�$	��Top=�$��16(��� -   $	 
combo_rate��$
��Left=�$��234,170,0,0q�$	��Top=�$	��170��$��31��.@��� $��16(�.��10%�� $��16(�.��18%�� $��16(�.��20%�� -	   $	 sum��$�� ��$
��Left=�$��101,282,0,0q�$	��Top=�$��16(��� -
   $ t_sum��$
��Left=�$��523,292,0,0q�$
��Wrap=�$�� ��$	��Top=�$��16(��� -   $ 
NDS_result��$�� ��$
��Left=�$��101,327,0,0q�$	��Top=�$��16(��� -   $ t_NDS_result��$
��Left=�$��523,332,0,0q�$
��Wrap=�$�� ��$	��Top=�$��16(��� -   
 ��Name$
 Calculation��$��Расчет��$
��Left=�$��368,390,0,0q�$	��Top=�$��75��$��16(�