﻿#pragma checksum "..\..\..\Controls\ShaderTabControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B5F7FE06975378D181560402B59DBB983AB37418A8AFC5A953B555260748EA2A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using McuTools.Interfaces.Controls.ShaderTransition;
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
    /// ShaderTabControl
    /// </summary>
    public partial class ShaderTabControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 463 "..\..\..\Controls\ShaderTabControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid;
        
        #line default
        #line hidden
        
        
        #line 464 "..\..\..\Controls\ShaderTabControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel Controls;
        
        #line default
        #line hidden
        
        
        #line 465 "..\..\..\Controls\ShaderTabControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CbItems;
        
        #line default
        #line hidden
        
        
        #line 480 "..\..\..\Controls\ShaderTabControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl Tabs;
        
        #line default
        #line hidden
        
        
        #line 482 "..\..\..\Controls\ShaderTabControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid PopupWin;
        
        #line default
        #line hidden
        
        
        #line 501 "..\..\..\Controls\ShaderTabControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock WindowText;
        
        #line default
        #line hidden
        
        
        #line 502 "..\..\..\Controls\ShaderTabControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnClose;
        
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
            System.Uri resourceLocater = new System.Uri("/McuTools.Interfaces;component/controls/shadertabcontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Controls\ShaderTabControl.xaml"
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
            this.grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.Controls = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.CbItems = ((System.Windows.Controls.ComboBox)(target));
            
            #line 465 "..\..\..\Controls\ShaderTabControl.xaml"
            this.CbItems.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CbItems_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 466 "..\..\..\Controls\ShaderTabControl.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Prev_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 469 "..\..\..\Controls\ShaderTabControl.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Next_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 472 "..\..\..\Controls\ShaderTabControl.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.PopOut_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 475 "..\..\..\Controls\ShaderTabControl.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Close_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Tabs = ((System.Windows.Controls.TabControl)(target));
            return;
            case 9:
            this.PopupWin = ((System.Windows.Controls.Grid)(target));
            return;
            case 10:
            this.WindowText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.BtnClose = ((System.Windows.Controls.Button)(target));
            
            #line 502 "..\..\..\Controls\ShaderTabControl.xaml"
            this.BtnClose.Click += new System.Windows.RoutedEventHandler(this.BtnClose_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

