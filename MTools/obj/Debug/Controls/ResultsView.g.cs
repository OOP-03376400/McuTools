﻿#pragma checksum "..\..\..\Controls\ResultsView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A241F096D70044F24677393840A7FCDAFCAC65F87A4207A644B7DC8594640EA9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using McuTools.Interfaces.Controls;
using McuTools.Interfaces.WPF;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace MTools.Controls {
    
    
    /// <summary>
    /// ResultsView
    /// </summary>
    public partial class ResultsView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\..\Controls\ResultsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MTools.Controls.ResultsView Cntrl;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\Controls\ResultsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MenCopyName;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Controls\ResultsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MenCopyAdr;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Controls\ResultsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MenOpenWeb;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Controls\ResultsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MenOpenExpl;
        
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
            System.Uri resourceLocater = new System.Uri("/MTools.Tool;component/controls/resultsview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Controls\ResultsView.xaml"
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
            this.Cntrl = ((MTools.Controls.ResultsView)(target));
            return;
            case 2:
            this.MenCopyName = ((System.Windows.Controls.MenuItem)(target));
            
            #line 11 "..\..\..\Controls\ResultsView.xaml"
            this.MenCopyName.Click += new System.Windows.RoutedEventHandler(this.MenCopyName_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.MenCopyAdr = ((System.Windows.Controls.MenuItem)(target));
            
            #line 12 "..\..\..\Controls\ResultsView.xaml"
            this.MenCopyAdr.Click += new System.Windows.RoutedEventHandler(this.MenCopyAdr_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.MenOpenWeb = ((System.Windows.Controls.MenuItem)(target));
            
            #line 13 "..\..\..\Controls\ResultsView.xaml"
            this.MenOpenWeb.Click += new System.Windows.RoutedEventHandler(this.MenOpenWeb_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.MenOpenExpl = ((System.Windows.Controls.MenuItem)(target));
            
            #line 14 "..\..\..\Controls\ResultsView.xaml"
            this.MenOpenExpl.Click += new System.Windows.RoutedEventHandler(this.MenOpenExpl_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

