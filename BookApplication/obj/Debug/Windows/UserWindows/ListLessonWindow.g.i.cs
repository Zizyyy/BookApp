﻿#pragma checksum "..\..\..\..\Windows\UserWindows\ListLessonWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "082971826A6B436895CAEC83D92C2582EA32BBB5C59DCDF2AA92AEAF2799E7B1"
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
    /// ListLessonWindow
    /// </summary>
    public partial class ListLessonWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 36 "..\..\..\..\Windows\UserWindows\ListLessonWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnClose;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\Windows\UserWindows\ListLessonWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnLesson;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\..\Windows\UserWindows\ListLessonWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnTest;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\..\..\Windows\UserWindows\ListLessonWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnVideoLesson;
        
        #line default
        #line hidden
        
        
        #line 170 "..\..\..\..\Windows\UserWindows\ListLessonWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TblName;
        
        #line default
        #line hidden
        
        
        #line 174 "..\..\..\..\Windows\UserWindows\ListLessonWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LvLesson;
        
        #line default
        #line hidden
        
        
        #line 254 "..\..\..\..\Windows\UserWindows\ListLessonWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbSearch;
        
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
            System.Uri resourceLocater = new System.Uri("/BookApplication;component/windows/userwindows/listlessonwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\UserWindows\ListLessonWindow.xaml"
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
            
            #line 14 "..\..\..\..\Windows\UserWindows\ListLessonWindow.xaml"
            ((BookApplication.Windows.UserWindows.ListLessonWindow)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BtnClose = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\..\Windows\UserWindows\ListLessonWindow.xaml"
            this.BtnClose.Click += new System.Windows.RoutedEventHandler(this.BtnClose_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnLesson = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.BtnTest = ((System.Windows.Controls.Button)(target));
            
            #line 113 "..\..\..\..\Windows\UserWindows\ListLessonWindow.xaml"
            this.BtnTest.Click += new System.Windows.RoutedEventHandler(this.BtnTest_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnVideoLesson = ((System.Windows.Controls.Button)(target));
            
            #line 146 "..\..\..\..\Windows\UserWindows\ListLessonWindow.xaml"
            this.BtnVideoLesson.Click += new System.Windows.RoutedEventHandler(this.BtnVideoLesson_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TblName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.LvLesson = ((System.Windows.Controls.ListView)(target));
            return;
            case 9:
            this.TbSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 262 "..\..\..\..\Windows\UserWindows\ListLessonWindow.xaml"
            this.TbSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TbSearch_TextChanged);
            
            #line default
            #line hidden
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
            case 8:
            
            #line 215 "..\..\..\..\Windows\UserWindows\ListLessonWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnOpen_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

