﻿#pragma checksum "..\..\..\..\Windows\UserWindows\ProfileUserWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1FE9C426339F542F2CD0A659A1DBDAA085D3C62BFD0DA1160181BCA77FA82BF8"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using BookApplication.Windows.UserWindows;
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


namespace BookApplication.Windows.UserWindows {
    
    
    /// <summary>
    /// ProfileUserWindow
    /// </summary>
    public partial class ProfileUserWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\..\Windows\UserWindows\ProfileUserWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnClose;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\..\Windows\UserWindows\ProfileUserWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbEmail;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\..\Windows\UserWindows\ProfileUserWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbLName;
        
        #line default
        #line hidden
        
        
        #line 133 "..\..\..\..\Windows\UserWindows\ProfileUserWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbFName;
        
        #line default
        #line hidden
        
        
        #line 164 "..\..\..\..\Windows\UserWindows\ProfileUserWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PbPassword;
        
        #line default
        #line hidden
        
        
        #line 176 "..\..\..\..\Windows\UserWindows\ProfileUserWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CbPassword;
        
        #line default
        #line hidden
        
        
        #line 194 "..\..\..\..\Windows\UserWindows\ProfileUserWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbMName;
        
        #line default
        #line hidden
        
        
        #line 221 "..\..\..\..\Windows\UserWindows\ProfileUserWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DpDateOfBirth;
        
        #line default
        #line hidden
        
        
        #line 232 "..\..\..\..\Windows\UserWindows\ProfileUserWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSave;
        
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
            System.Uri resourceLocater = new System.Uri("/BookApplication;component/windows/userwindows/profileuserwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\UserWindows\ProfileUserWindow.xaml"
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
            
            #line 14 "..\..\..\..\Windows\UserWindows\ProfileUserWindow.xaml"
            ((BookApplication.Windows.UserWindows.ProfileUserWindow)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BtnClose = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\..\Windows\UserWindows\ProfileUserWindow.xaml"
            this.BtnClose.Click += new System.Windows.RoutedEventHandler(this.BtnClose_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TbEmail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TbLName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TbFName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.PbPassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 7:
            this.CbPassword = ((System.Windows.Controls.CheckBox)(target));
            
            #line 181 "..\..\..\..\Windows\UserWindows\ProfileUserWindow.xaml"
            this.CbPassword.Checked += new System.Windows.RoutedEventHandler(this.CbPassword_Checked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.TbMName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.DpDateOfBirth = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 10:
            this.BtnSave = ((System.Windows.Controls.Button)(target));
            
            #line 243 "..\..\..\..\Windows\UserWindows\ProfileUserWindow.xaml"
            this.BtnSave.Click += new System.Windows.RoutedEventHandler(this.BtnSave_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
