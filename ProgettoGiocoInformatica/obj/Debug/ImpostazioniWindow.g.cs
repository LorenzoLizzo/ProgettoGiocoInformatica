﻿#pragma checksum "..\..\ImpostazioniWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5D28EE1D2349697CE2D8ADB4E100B117EAEED668408B4BCC586F52BBA694F45D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

using ProgettoGiocoInformatica;
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


namespace ProgettoGiocoInformatica {
    
    
    /// <summary>
    /// ImpostazioniWindow
    /// </summary>
    public partial class ImpostazioniWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\ImpostazioniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ckXfx;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\ImpostazioniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ckIntero;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\ImpostazioniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ckMusica;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\ImpostazioniWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnIndietro;
        
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
            System.Uri resourceLocater = new System.Uri("/ProgettoGiocoInformatica;component/impostazioniwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ImpostazioniWindow.xaml"
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
            this.ckXfx = ((System.Windows.Controls.CheckBox)(target));
            
            #line 10 "..\..\ImpostazioniWindow.xaml"
            this.ckXfx.Checked += new System.Windows.RoutedEventHandler(this.ckXfx_Checked);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ckIntero = ((System.Windows.Controls.CheckBox)(target));
            
            #line 11 "..\..\ImpostazioniWindow.xaml"
            this.ckIntero.Checked += new System.Windows.RoutedEventHandler(this.ckIntero_Checked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ckMusica = ((System.Windows.Controls.CheckBox)(target));
            
            #line 12 "..\..\ImpostazioniWindow.xaml"
            this.ckMusica.Checked += new System.Windows.RoutedEventHandler(this.ckMusica_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnIndietro = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\ImpostazioniWindow.xaml"
            this.btnIndietro.Click += new System.Windows.RoutedEventHandler(this.btnIndietro_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

