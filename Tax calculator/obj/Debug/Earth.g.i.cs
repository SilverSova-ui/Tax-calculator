﻿#pragma checksum "..\..\Earth.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "902CE10B88B96154B8FEFC39171B91B1CBBC498119430CE3FCCE93564C910404"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using Tax_calculator;


namespace Tax_calculator {
    
    
    /// <summary>
    /// Earth
    /// </summary>
    public partial class Earth : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\Earth.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock title;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Earth.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image exit;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Earth.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label cadastral;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Earth.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox t_cadastral;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Earth.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Earth_rate;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Earth.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox combo_Earth_rate;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Earth.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ndfl;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Earth.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox t_ndfl;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Earth.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label result;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Earth.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock t_result;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Earth.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Remaining_sum;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Earth.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock t_Remaining_sum;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Earth.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Calculation;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Tax calculator;component/earth.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Earth.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.title = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.exit = ((System.Windows.Controls.Image)(target));
            
            #line 13 "..\..\Earth.xaml"
            this.exit.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.exit_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cadastral = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.t_cadastral = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Earth_rate = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.combo_Earth_rate = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.ndfl = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.t_ndfl = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.result = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.t_result = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.Remaining_sum = ((System.Windows.Controls.Label)(target));
            return;
            case 12:
            this.t_Remaining_sum = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 13:
            this.Calculation = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\Earth.xaml"
            this.Calculation.Click += new System.Windows.RoutedEventHandler(this.Calculation_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

