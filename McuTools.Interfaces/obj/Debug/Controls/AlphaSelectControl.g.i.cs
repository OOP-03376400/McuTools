﻿#pragma checksum "..\..\..\Controls\AlphaSelectControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "455CF903BCF3B2233B0D4F2C62F0CEBD6971F5EFD785F53AE26FC20C3C8CA72A"
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


namespace McuTools.Interfaces.Controls {
    
    
    /// <summary>
    /// AlphaSelectControl
    /// </summary>
    public partial class AlphaSelectControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\..\Controls\AlphaSelectControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LayoutRoot;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Controls\AlphaSelectControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.GradientStop displayColor;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Controls\AlphaSelectControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle rectMonitor;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Controls\AlphaSelectControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas rectMarker;
        
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
            System.Uri resourceLocater = new System.Uri("/McuTools.Interfaces;component/controls/alphaselectcontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Controls\AlphaSelectControl.xaml"
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
            this.LayoutRoot = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.displayColor = ((System.Windows.Media.GradientStop)(target));
            return;
            case 3:
            this.rectMonitor = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 24 "..\..\..\Controls\AlphaSelectControl.xaml"
            this.rectMonitor.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.rectMonitor_MouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 25 "..\..\..\Controls\AlphaSelectControl.xaml"
            this.rectMonitor.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.rectMonitor_MouseLeftButtonUp);
            
            #line default
            #line hidden
            
            #line 26 "..\..\..\Controls\AlphaSelectControl.xaml"
            this.rectMonitor.MouseMove += new System.Windows.Input.MouseEventHandler(this.rectMonitor_MouseMove);
            
            #line default
            #line hidden
            
            #line 27 "..\..\..\Controls\AlphaSelectControl.xaml"
            this.rectMonitor.LostMouseCapture += new System.Windows.Input.MouseEventHandler(this.rectMonitor_LostMouseCapture);
            
            #line default
            #line hidden
            return;
            case 4:
            this.rectMarker = ((System.Windows.Controls.Canvas)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

