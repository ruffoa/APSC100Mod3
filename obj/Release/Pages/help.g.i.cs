﻿#pragma checksum "..\..\..\Pages\help.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6E637F7818B264354CFFEBD3030AE0F2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Kinect.Wpf.Controls;
using Microsoft.Samples.Kinect.ControlsBasics;
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


namespace Microsoft.Samples.Kinect.ControlsBasics {
    
    
    /// <summary>
    /// Help
    /// </summary>
    public partial class Help : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\Pages\help.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Kinect.Wpf.Controls.KinectRegion kinectRegion;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Pages\help.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button goBack;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Pages\help.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement MediaPlayer;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Pages\help.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock instructions;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Pages\help.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button next;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Pages\help.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox scrollHelp;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Pages\help.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas mainScreen;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Pages\help.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image check;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Pages\help.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer scrollViewer;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Pages\help.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl itemsControl;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Pages\help.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer photoEx;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Pages\help.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button testClick;
        
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
            System.Uri resourceLocater = new System.Uri("/Mod3-Project;component/pages/help.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\help.xaml"
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
            
            #line 10 "..\..\..\Pages\help.xaml"
            ((Microsoft.Samples.Kinect.ControlsBasics.Help)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.UserControl_KeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.kinectRegion = ((Microsoft.Kinect.Wpf.Controls.KinectRegion)(target));
            return;
            case 3:
            this.goBack = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\Pages\help.xaml"
            this.goBack.Click += new System.Windows.RoutedEventHandler(this.goBack_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.MediaPlayer = ((System.Windows.Controls.MediaElement)(target));
            return;
            case 5:
            this.instructions = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.next = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\Pages\help.xaml"
            this.next.Click += new System.Windows.RoutedEventHandler(this.next_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.scrollHelp = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.mainScreen = ((System.Windows.Controls.Canvas)(target));
            return;
            case 9:
            this.check = ((System.Windows.Controls.Image)(target));
            return;
            case 10:
            this.scrollViewer = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 11:
            this.itemsControl = ((System.Windows.Controls.ItemsControl)(target));
            return;
            case 12:
            this.photoEx = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 13:
            this.testClick = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\Pages\help.xaml"
            this.testClick.Click += new System.Windows.RoutedEventHandler(this.button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
