﻿#pragma checksum "..\..\..\..\Views\Logowanie.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F14FF117E25E2C4644C87A2E3F59579D349BD872"
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
        
        
        #line 17 "..\..\..\..\Views\Logowanie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox loginTxtBox;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\Views\Logowanie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passTxtBox;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Views\Logowanie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox loginFirmyTxtBox;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Views\Logowanie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passFirmyTxtBox;
        
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
            System.Uri resourceLocater = new System.Uri("/SystemLotniczy;V1.0.0.0;component/views/logowanie.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Logowanie.xaml"
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
            this.passTxtBox = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 3:
            
            #line 20 "..\..\..\..\Views\Logowanie.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Zaloguj);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 22 "..\..\..\..\Views\Logowanie.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Zarejstruj);
            
            #line default
            #line hidden
            return;
            case 5:
            this.loginFirmyTxtBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.passFirmyTxtBox = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 7:
            
            #line 30 "..\..\..\..\Views\Logowanie.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ZalogujFirma);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 32 "..\..\..\..\Views\Logowanie.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ZarejstrujFirme);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

