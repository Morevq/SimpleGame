﻿#pragma checksum "..\..\Oformlenie.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1E225FACFC4986F8B3C5F1C1B23A988A207B9749313FEB4DA25A3B37E9845262"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using SimpleGame;
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


namespace SimpleGame {
    
    
    /// <summary>
    /// Oformlenie
    /// </summary>
    public partial class Oformlenie : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\Oformlenie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid holst;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Oformlenie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView back_check;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Oformlenie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView shar_check;
        
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
            System.Uri resourceLocater = new System.Uri("/SimpleGame;component/oformlenie.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Oformlenie.xaml"
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
            this.holst = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            
            #line 15 "..\..\Oformlenie.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.safe);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 16 "..\..\Oformlenie.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.back);
            
            #line default
            #line hidden
            return;
            case 4:
            this.back_check = ((System.Windows.Controls.ListView)(target));
            return;
            case 5:
            
            #line 20 "..\..\Oformlenie.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.white_back);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 21 "..\..\Oformlenie.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.red_back);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 22 "..\..\Oformlenie.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.yellow_back);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 23 "..\..\Oformlenie.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.green_back);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 24 "..\..\Oformlenie.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.pink_back);
            
            #line default
            #line hidden
            return;
            case 10:
            this.shar_check = ((System.Windows.Controls.ListView)(target));
            return;
            case 11:
            
            #line 29 "..\..\Oformlenie.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.black_shar);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 30 "..\..\Oformlenie.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.blue_shar);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
