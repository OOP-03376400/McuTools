﻿#pragma checksum "..\..\..\ToolsDigital\LcdCharCalculator.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DEEFE57E2903727F5EF5BF20CD46844EE4EE09696B7D6A62D6A9350F10A042B3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MTools.Controls;
using McuTools.Interfaces.Controls;
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


namespace MTools {
    
    
    /// <summary>
    /// LcdCharCalculator
    /// </summary>
    public partial class LcdCharCalculator : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MTools.LcdCharCalculator LcdCharCalc;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Matrix;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Type5x7;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Type5x10;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnClear;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnLoadBMP;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSaveBmp;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbOutput;
        
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
            System.Uri resourceLocater = new System.Uri("/MTools.Tool;component/toolsdigital/lcdcharcalculator.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
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
            this.LcdCharCalc = ((MTools.LcdCharCalculator)(target));
            return;
            case 2:
            this.Matrix = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            
            #line 37 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Seg_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 38 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Seg_MouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 39 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Seg_MouseDown);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 40 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Seg_MouseDown);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 41 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Seg_MouseDown);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 43 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Seg_MouseDown);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 44 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Seg_MouseDown);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 45 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Seg_MouseDown);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 46 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Seg_MouseDown);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 47 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Seg_MouseDown);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 49 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Seg_MouseDown);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 50 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Seg_MouseDown);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 51 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Seg_MouseDown);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 52 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Seg_MouseDown);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 53 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Seg_MouseDown);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 55 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Seg_MouseDown);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 56 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Seg_MouseDown);
            
            #line default
            #line hidden
            return;
            case 20:
            
            #line 57 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Seg_MouseDown);
            
            #line default
            #line hidden
            return;
            case 21:
            
            #line 58 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Seg_MouseDown);
            
            #line default
            #line hidden
            return;
            case 22:
            
            #line 59 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Seg_MouseDown);
            
            #line default
            #line hidden
            return;
            case 23:
            
            #line 61 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Seg_MouseDown);
            
            #line default
            #line hidden
            return;
            case 24:
            
            #line 62 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Seg_MouseDown);
            
            #line default
            #line hidden
            return;
            case 25:
            
            #line 63 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Seg_MouseDown);
            
            #line default
            #line hidden
            return;
            case 26:
            
            #line 64 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Seg_MouseDown);
            
            #line default
            #line hidden
            return;
            case 27:
            
            #line 65 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Seg_MouseDown);
            
            #line default
            #line hidden
            return;
            case 28:
            
            #line 67 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Seg_MouseDown);
            
            #line default
            #line hidden
            return;
            case 29:
            
            #line 68 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Seg_MouseDown);
            
            #line default
            #line hidden
            return;
            case 30:
            
            #line 69 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Seg_MouseDown);
            
            #line default
            #line hidden
            return;
            case 31:
            
            #line 70 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Seg_MouseDown);
            
            #line default
            #line hidden
            return;
            case 32:
            
            #line 71 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Seg_MouseDown);
            
            #line default
            #line hidden
            return;
            case 33:
            
            #line 73 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Seg_MouseDown);
            
            #line default
            #line hidden
            return;
            case 34:
            
            #line 74 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Seg_MouseDown);
            
            #line default
            #line hidden
            return;
            case 35:
            
            #line 75 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Seg_MouseDown);
            
            #line default
            #line hidden
            return;
            case 36:
            
            #line 76 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Seg_MouseDown);
            
            #line default
            #line hidden
            return;
            case 37:
            
            #line 77 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Seg_MouseDown);
            
            #line default
            #line hidden
            return;
            case 38:
            
            #line 79 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Seg_MouseDown);
            
            #line default
            #line hidden
            return;
            case 39:
            
            #line 80 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Seg_MouseDown);
            
            #line default
            #line hidden
            return;
            case 40:
            
            #line 81 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Seg_MouseDown);
            
            #line default
            #line hidden
            return;
            case 41:
            
            #line 82 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Seg_MouseDown);
            
            #line default
            #line hidden
            return;
            case 42:
            
            #line 83 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Seg_MouseDown);
            
            #line default
            #line hidden
            return;
            case 43:
            
            #line 85 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Seg_MouseDown);
            
            #line default
            #line hidden
            return;
            case 44:
            
            #line 86 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Seg_MouseDown);
            
            #line default
            #line hidden
            return;
            case 45:
            
            #line 87 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Seg_MouseDown);
            
            #line default
            #line hidden
            return;
            case 46:
            
            #line 88 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Seg_MouseDown);
            
            #line default
            #line hidden
            return;
            case 47:
            
            #line 89 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Seg_MouseDown);
            
            #line default
            #line hidden
            return;
            case 48:
            
            #line 91 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Seg_MouseDown);
            
            #line default
            #line hidden
            return;
            case 49:
            
            #line 92 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Seg_MouseDown);
            
            #line default
            #line hidden
            return;
            case 50:
            
            #line 93 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Seg_MouseDown);
            
            #line default
            #line hidden
            return;
            case 51:
            
            #line 94 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Seg_MouseDown);
            
            #line default
            #line hidden
            return;
            case 52:
            
            #line 95 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Seg_MouseDown);
            
            #line default
            #line hidden
            return;
            case 53:
            this.Type5x7 = ((System.Windows.Controls.RadioButton)(target));
            
            #line 100 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            this.Type5x7.Checked += new System.Windows.RoutedEventHandler(this.RadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 54:
            this.Type5x10 = ((System.Windows.Controls.RadioButton)(target));
            
            #line 101 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            this.Type5x10.Checked += new System.Windows.RoutedEventHandler(this.RadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 55:
            this.BtnClear = ((System.Windows.Controls.Button)(target));
            
            #line 106 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            this.BtnClear.Click += new System.Windows.RoutedEventHandler(this.BtnClear_Click);
            
            #line default
            #line hidden
            return;
            case 56:
            this.BtnLoadBMP = ((System.Windows.Controls.Button)(target));
            
            #line 107 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            this.BtnLoadBMP.Click += new System.Windows.RoutedEventHandler(this.BtnLoadBMP_Click);
            
            #line default
            #line hidden
            return;
            case 57:
            this.BtnSaveBmp = ((System.Windows.Controls.Button)(target));
            
            #line 108 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            this.BtnSaveBmp.Click += new System.Windows.RoutedEventHandler(this.BtnSaveBmp_Click);
            
            #line default
            #line hidden
            return;
            case 58:
            this.TbOutput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 59:
            
            #line 112 "..\..\..\ToolsDigital\LcdCharCalculator.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
