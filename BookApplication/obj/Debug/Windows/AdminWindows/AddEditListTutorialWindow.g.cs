﻿#pragma checksum "..\..\..\..\Windows\AdminWindows\AddEditListTutorialWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D6129225A642A95D55592FED02C9F0154916F77E73AC755D82A78A37E56A3D16"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using BookApplication.Windows.AdminWindows;
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


namespace BookApplication.Windows.AdminWindows {
    
    
    /// <summary>
    /// AddEditListTutorialWindow
    /// </summary>
    public partial class AddEditListTutorialWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\..\..\Windows\AdminWindows\AddEditListTutorialWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TblStatus;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\Windows\AdminWindows\AddEditListTutorialWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnClose;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\..\Windows\AdminWindows\AddEditListTutorialWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbTitle;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\..\..\Windows\AdminWindows\AddEditListTutorialWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbUrlPath;
        
        #line default
        #line hidden
        
        
        #line 153 "..\..\..\..\Windows\AdminWindows\AddEditListTutorialWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CbListLesson;
        
        #line default
        #line hidden
        
        
        #line 160 "..\..\..\..\Windows\AdminWindows\AddEditListTutorialWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnExit;
        
        #line default
        #line hidden
        
        
        #line 193 "..\..\..\..\Windows\AdminWindows\AddEditListTutorialWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddEdit;
        
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
            System.Uri resourceLocater = new System.Uri("/BookApplication;component/windows/adminwindows/addeditlisttutorialwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\AdminWindows\AddEditListTutorialWindow.xaml"
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
            
            #line 14 "..\..\..\..\Windows\AdminWindows\AddEditListTutorialWindow.xaml"
            ((BookApplication.Windows.AdminWindows.AddEditListTutorialWindow)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TblStatus = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.BtnClose = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\..\Windows\AdminWindows\AddEditListTutorialWindow.xaml"
            this.BtnClose.Click += new System.Windows.RoutedEventHandler(this.BtnClose_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TbTitle = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TbUrlPath = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.CbListLesson = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.BtnExit = ((System.Windows.Controls.Button)(target));
            
            #line 169 "..\..\..\..\Windows\AdminWindows\AddEditListTutorialWindow.xaml"
            this.BtnExit.Click += new System.Windows.RoutedEventHandler(this.BtnExit_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BtnAddEdit = ((System.Windows.Controls.Button)(target));
            
            #line 202 "..\..\..\..\Windows\AdminWindows\AddEditListTutorialWindow.xaml"
            this.BtnAddEdit.Click += new System.Windows.RoutedEventHandler(this.BtnAddEdit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

