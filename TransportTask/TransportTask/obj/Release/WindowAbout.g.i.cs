﻿#pragma checksum "..\..\WindowAbout.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FAB1B71F409CB664B5BB79550D312D6F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ModernWPF;
using ModernWPF.Controls;
using ModernWPF.Converters;
using ModernWPF.Resources;
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
using vector;


namespace vector {
    
    
    /// <summary>
    /// WindowAbout
    /// </summary>
    public partial class WindowAbout : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 106 "..\..\WindowAbout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockTitle;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\WindowAbout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockMain;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\WindowAbout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.VisualBrush SecondTiledBgVisual;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\WindowAbout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonAuth;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\WindowAbout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonData;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\WindowAbout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonMeth;
        
        #line default
        #line hidden
        
        
        #line 139 "..\..\WindowAbout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonProg;
        
        #line default
        #line hidden
        
        
        #line 142 "..\..\WindowAbout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonMinimize;
        
        #line default
        #line hidden
        
        
        #line 145 "..\..\WindowAbout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonRestore;
        
        #line default
        #line hidden
        
        
        #line 148 "..\..\WindowAbout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonMaximize;
        
        #line default
        #line hidden
        
        
        #line 151 "..\..\WindowAbout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonClose;
        
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
            System.Uri resourceLocater = new System.Uri("/TransportTask;component/windowabout.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WindowAbout.xaml"
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
            
            #line 10 "..\..\WindowAbout.xaml"
            ((vector.WindowAbout)(target)).StateChanged += new System.EventHandler(this.Window_StateChanged);
            
            #line default
            #line hidden
            
            #line 10 "..\..\WindowAbout.xaml"
            ((vector.WindowAbout)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            
            #line 10 "..\..\WindowAbout.xaml"
            ((vector.WindowAbout)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TextBlockTitle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.TextBlockMain = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.SecondTiledBgVisual = ((System.Windows.Media.VisualBrush)(target));
            return;
            case 5:
            this.buttonAuth = ((System.Windows.Controls.Button)(target));
            
            #line 136 "..\..\WindowAbout.xaml"
            this.buttonAuth.Click += new System.Windows.RoutedEventHandler(this.buttons_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.buttonData = ((System.Windows.Controls.Button)(target));
            
            #line 137 "..\..\WindowAbout.xaml"
            this.buttonData.Click += new System.Windows.RoutedEventHandler(this.buttons_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.buttonMeth = ((System.Windows.Controls.Button)(target));
            
            #line 138 "..\..\WindowAbout.xaml"
            this.buttonMeth.Click += new System.Windows.RoutedEventHandler(this.buttons_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.buttonProg = ((System.Windows.Controls.Button)(target));
            
            #line 139 "..\..\WindowAbout.xaml"
            this.buttonProg.Click += new System.Windows.RoutedEventHandler(this.buttons_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ButtonMinimize = ((System.Windows.Controls.Button)(target));
            
            #line 142 "..\..\WindowAbout.xaml"
            this.ButtonMinimize.Click += new System.Windows.RoutedEventHandler(this.ButtonCommonClick);
            
            #line default
            #line hidden
            return;
            case 10:
            this.ButtonRestore = ((System.Windows.Controls.Button)(target));
            
            #line 145 "..\..\WindowAbout.xaml"
            this.ButtonRestore.Click += new System.Windows.RoutedEventHandler(this.ButtonCommonClick);
            
            #line default
            #line hidden
            return;
            case 11:
            this.ButtonMaximize = ((System.Windows.Controls.Button)(target));
            
            #line 148 "..\..\WindowAbout.xaml"
            this.ButtonMaximize.Click += new System.Windows.RoutedEventHandler(this.ButtonCommonClick);
            
            #line default
            #line hidden
            return;
            case 12:
            this.ButtonClose = ((System.Windows.Controls.Button)(target));
            
            #line 151 "..\..\WindowAbout.xaml"
            this.ButtonClose.Click += new System.Windows.RoutedEventHandler(this.ButtonCommonClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

