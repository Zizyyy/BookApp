﻿#pragma checksum "..\..\..\Windows\RegistrationWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "62135026875ABD1046685E7AD94E3FBFD1DF1C0403DE50DB47879C642982CFE2"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using BookApplication.Windows;
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


namespace BookApplication.Windows {
    
    
    /// <summary>
    /// RegistrationWindow
    /// </summary>
    public partial class RegistrationWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\Windows\RegistrationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnClose;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\Windows\RegistrationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbEmail;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\Windows\RegistrationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbLName;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\..\Windows\RegistrationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbFName;
        
        #line default
        #line hidden
        
        
        #line 156 "..\..\..\Windows\RegistrationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbMName;
        
        #line default
        #line hidden
        
        
        #line 184 "..\..\..\Windows\RegistrationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PbPassword;
        
        #line default
        #line hidden
        
        
        #line 212 "..\..\..\Windows\RegistrationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DpDateOfBirth;
        
        #line default
        #line hidden
        
        
        #line 216 "..\..\..\Windows\RegistrationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TblErrorMaessage;
        
        #line default
        #line hidden
        
        
        #line 223 "..\..\..\Windows\RegistrationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSignUp;
        
        #line default
        #line hidden
        
        
        #line 254 "..\..\..\Windows\RegistrationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TblSignIn;
        
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
            System.Uri resourceLocater = new System.Uri("/BookApplication;component/windows/registrationwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\RegistrationWindow.xaml"
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
            
            #line 14 "..\..\..\Windows\RegistrationWindow.xaml"
            ((BookApplication.Windows.RegistrationWindow)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BtnClose = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\Windows\RegistrationWindow.xaml"
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
            this.TbMName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.PbPassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 8:
            this.DpDateOfBirth = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 9:
            this.TblErrorMaessage = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.BtnSignUp = ((System.Windows.Controls.Button)(target));
            
            #line 230 "..\..\..\Windows\RegistrationWindow.xaml"
            this.BtnSignUp.Click += new System.Windows.RoutedEventHandler(this.BtnSignUp_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.TblSignIn = ((System.Windows.Controls.TextBlock)(target));
            
            #line 260 "..\..\..\Windows\RegistrationWindow.xaml"
            this.TblSignIn.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.TblSignIn_MouseDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

