﻿#pragma checksum "..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1EE863F6F8AB4F2D709AEA3D7AE6471E51422413"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Clicker_Vernost;
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


namespace Clicker_Vernost {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_About;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBox_Repet;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tb_click_x;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tb_click_y;
        
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
            System.Uri resourceLocater = new System.Uri("/Clicker_Vernost;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            
            #line 11 "..\..\MainWindow.xaml"
            ((Clicker_Vernost.MainWindow)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_Left_Mouse_Down);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn_About = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\MainWindow.xaml"
            this.btn_About.GotFocus += new System.Windows.RoutedEventHandler(this.OnGotFocusHandler);
            
            #line default
            #line hidden
            
            #line 34 "..\..\MainWindow.xaml"
            this.btn_About.LostFocus += new System.Windows.RoutedEventHandler(this.OnLostFocusHandler);
            
            #line default
            #line hidden
            
            #line 34 "..\..\MainWindow.xaml"
            this.btn_About.Click += new System.Windows.RoutedEventHandler(this.Btn_About_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 39 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnGotFocusHandler);
            
            #line default
            #line hidden
            
            #line 39 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.OnLostFocusHandler);
            
            #line default
            #line hidden
            
            #line 39 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TextBox_Repet = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tb_click_x = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.tb_click_y = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            
            #line 59 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnGotFocusHandler);
            
            #line default
            #line hidden
            
            #line 59 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.OnLostFocusHandler);
            
            #line default
            #line hidden
            
            #line 59 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Write);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 64 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnGotFocusHandler);
            
            #line default
            #line hidden
            
            #line 64 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.OnLostFocusHandler);
            
            #line default
            #line hidden
            
            #line 64 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Start);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 69 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnGotFocusHandler);
            
            #line default
            #line hidden
            
            #line 69 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.OnLostFocusHandler);
            
            #line default
            #line hidden
            
            #line 69 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Clear);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

