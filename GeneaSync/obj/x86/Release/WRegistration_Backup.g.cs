﻿#pragma checksum "..\..\..\WRegistration_Backup.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5D2E798EA81CF88B5E1C311A44EA6630"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.239
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
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


namespace GedcomViewCompare {
    
    
    /// <summary>
    /// WRegistration_Backup
    /// </summary>
    public partial class WRegistration_Backup : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\..\WRegistration_Backup.xaml"
        internal System.Windows.Controls.ColumnDefinition spacerLeft;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\..\WRegistration_Backup.xaml"
        internal System.Windows.Controls.ColumnDefinition content;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\..\WRegistration_Backup.xaml"
        internal System.Windows.Controls.ColumnDefinition spacerRight;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\WRegistration_Backup.xaml"
        internal System.Windows.Controls.TextBox textBox1;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\WRegistration_Backup.xaml"
        internal System.Windows.Controls.Button buttonRegister;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\WRegistration_Backup.xaml"
        internal System.Windows.Controls.TextBlock textBlock1;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/GedcomViewCompare;component/wregistration_backup.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\WRegistration_Backup.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.spacerLeft = ((System.Windows.Controls.ColumnDefinition)(target));
            return;
            case 2:
            this.content = ((System.Windows.Controls.ColumnDefinition)(target));
            return;
            case 3:
            this.spacerRight = ((System.Windows.Controls.ColumnDefinition)(target));
            return;
            case 4:
            this.textBox1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.buttonRegister = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.textBlock1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
