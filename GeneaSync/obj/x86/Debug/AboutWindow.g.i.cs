﻿#pragma checksum "..\..\..\AboutWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7B5EFB3BFFF1FDA698B89E0C280C9E1F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.1
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
using System.Windows.Shell;


namespace GedcomViewCompare {
    
    
    /// <summary>
    /// AboutWindow
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class AboutWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\..\AboutWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ColumnDefinition columnLogo;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\..\AboutWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ColumnDefinition columnText;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\AboutWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle rectangleLogo;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\AboutWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelProgramTitle;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\AboutWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelCopyright;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\AboutWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelWolfi;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\AboutWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelVersion;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\AboutWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelHomepage;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\AboutWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelURI;
        
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
            System.Uri resourceLocater = new System.Uri("/GedcomViewCompare;component/aboutwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AboutWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.columnLogo = ((System.Windows.Controls.ColumnDefinition)(target));
            return;
            case 2:
            this.columnText = ((System.Windows.Controls.ColumnDefinition)(target));
            return;
            case 3:
            this.rectangleLogo = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 4:
            this.labelProgramTitle = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.labelCopyright = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.labelWolfi = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.labelVersion = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.labelHomepage = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.labelURI = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            
            #line 21 "..\..\..\AboutWindow.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.Hyperlink_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

