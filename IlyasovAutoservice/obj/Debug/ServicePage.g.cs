﻿#pragma checksum "..\..\ServicePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "549D022F87C934FE4F8C4E1648868B484D81441D879EC9139CAF3BB826A18D1F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using IlyasovAutoservice;
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


namespace IlyasovAutoservice {
    
    
    /// <summary>
    /// ServicePage
    /// </summary>
    public partial class ServicePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 19 "..\..\ServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TBCount;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\ServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TBAllRecords;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\ServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LeftDirButton;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\ServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox PageListBox;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\ServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RightDirButton;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\ServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBoxSearh;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\ServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboType;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\ServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RButtonUp;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\ServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RButtonDown;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\ServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddButton;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\ServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ServiceListView;
        
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
            System.Uri resourceLocater = new System.Uri("/IlyasovAutoservice;component/servicepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ServicePage.xaml"
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
            
            #line 9 "..\..\ServicePage.xaml"
            ((IlyasovAutoservice.ServicePage)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.Page_IsVisibleChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TBCount = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.TBAllRecords = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.LeftDirButton = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\ServicePage.xaml"
            this.LeftDirButton.Click += new System.Windows.RoutedEventHandler(this.LeftDirButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.PageListBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 22 "..\..\ServicePage.xaml"
            this.PageListBox.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.PageListBox_MouseUp);
            
            #line default
            #line hidden
            return;
            case 6:
            this.RightDirButton = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\ServicePage.xaml"
            this.RightDirButton.Click += new System.Windows.RoutedEventHandler(this.RightDirButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.TBoxSearh = ((System.Windows.Controls.TextBox)(target));
            
            #line 34 "..\..\ServicePage.xaml"
            this.TBoxSearh.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TBoxSearh_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ComboType = ((System.Windows.Controls.ComboBox)(target));
            
            #line 39 "..\..\ServicePage.xaml"
            this.ComboType.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboType_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.RButtonUp = ((System.Windows.Controls.RadioButton)(target));
            
            #line 51 "..\..\ServicePage.xaml"
            this.RButtonUp.Checked += new System.Windows.RoutedEventHandler(this.RButtonUp_Checked);
            
            #line default
            #line hidden
            return;
            case 10:
            this.RButtonDown = ((System.Windows.Controls.RadioButton)(target));
            
            #line 52 "..\..\ServicePage.xaml"
            this.RButtonDown.Checked += new System.Windows.RoutedEventHandler(this.RButtonDown_Checked);
            
            #line default
            #line hidden
            return;
            case 11:
            this.AddButton = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\ServicePage.xaml"
            this.AddButton.Click += new System.Windows.RoutedEventHandler(this.AddButton_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.ServiceListView = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 13:
            
            #line 80 "..\..\ServicePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EditButton_Click_1);
            
            #line default
            #line hidden
            break;
            case 14:
            
            #line 81 "..\..\ServicePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteButton_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

