   M S B A M L   `   `   `  ���� I  ETax calculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Tax_calculatorTax_calculator      Tax_calculator.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:Tax_calculator       � WindowStartupLocation$  CenterScreen=� � 
ResizeMode$ NoResize=� � Title$+ %Калькулятор налогов��$��404.333��$	��800�� � Icon$ Tax_Icon.png��.��� .+��� -    ��Name$ title��$
��Left=�$��
317,37,0,0q�$
��Wrap=�$+��%Калькулятор налогов��$	��Top=�$��18(��� -    ��Name$ choice_person��$��Выбор лица��$
��Left=�$��	17,98,0,0q�$	��Top=�$��16(� J� RenderTransformOrigin$ 0.514,0.527&��� -    ��Name$ combo_person��$
��Left=�$��
151,98,0,0q�$	��Top=�$	��178��$��28��$��16(�.@��� .��Физическое лицо�� .��!Юридическое лицо�� -   $ choosingTax��$��Выбор налога��$
��Left=�$��
435,95,0,0q�$	��Top=�$��16(��� -   $ 	combo_Tax��$
��Left=�$��
570,95,0,0q�$	��Top=�$	��191��$��16(�$��28���� -   $ Journal_log��$#��Журнал расчетов��$
��Left=�$��
17,174,0,0q�$	��Top=�$��16(��� -   $ 	combo_log��$
��Left=�$��184,174,0,0q�$	��Top=�$	��462��$��31��$��16(��� -    ��Name$ 	discharge��$%��Выгрузка журнала��$
��Left=�$��660,159,0,0q�$	��Top=�$	��113���� -	   $ clearing��$��Очищение��$
��Left=�$��660,190,0,0q�$	��Top=�$	��113���� -
   $ 
Transition��$0��*Перейти к калькулятору��$
��Left=�$��301,275,0,0q�$	��Top=�$	��193��$��16(�$��33��