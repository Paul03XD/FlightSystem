﻿#pragma checksum "..\..\..\Logowanie.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C6A8F03BBA472A63737C87D5692BD4B17609EB91"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using SystemLotniczy;


namespace SystemLotniczy {
    
    
    /// <summary>
    /// Logowanie
    /// </summary>
    public partial class Logowanie : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\Logowanie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox loginTxtBox;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Logowanie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox passTxtBox;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Logowanie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox usernameTxtBox;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Logowanie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox passwordTxtBox;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Logowanie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox imieTxtBox;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Logowanie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nazwiskoTxtBox;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Logowanie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox wiekTxtBox;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Logowanie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox adresTxtBox;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Logowanie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nrtelTxtBox;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Logowanie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox emailTxtBox;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\Logowanie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox firmaCmbBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SystemLotniczy;component/logowanie.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Logowanie.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.loginTxtBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.passTxtBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            
            #line 16 "..\..\..\Logowanie.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Zaloguj);
            
            #line default
            #line hidden
            return;
            case 4:
            this.usernameTxtBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.passwordTxtBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.imieTxtBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.nazwiskoTxtBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.wiekTxtBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.adresTxtBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.nrtelTxtBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.emailTxtBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            
            #line 58 "..\..\..\Logowanie.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.firmaActive);
            
            #line default
            #line hidden
            
            #line 58 "..\..\..\Logowanie.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.firmaActive);
            
            #line default
            #line hidden
            return;
            case 13:
            this.firmaCmbBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

