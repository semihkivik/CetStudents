﻿#pragma checksum "..\..\..\CourseWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C1C87BCD9C7F7CA2B0697EB27FD5C7A55A0499C7"
//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

using CetStudents;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace CetStudents {
    
    
    /// <summary>
    /// CourseWindow
    /// </summary>
    public partial class CourseWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\..\CourseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCourseInsert;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\CourseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCourseUpdate;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\CourseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCourseDelete;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\CourseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid grdCourse;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\CourseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCourseName;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\CourseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCourseCode;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\CourseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCourseCredit;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\CourseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtMaxStudents;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CetStudents;component/coursewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\CourseWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\CourseWindow.xaml"
            ((CetStudents.CourseWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnCourseInsert = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\CourseWindow.xaml"
            this.btnCourseInsert.Click += new System.Windows.RoutedEventHandler(this.btnCourseInsert_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnCourseUpdate = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\CourseWindow.xaml"
            this.btnCourseUpdate.Click += new System.Windows.RoutedEventHandler(this.btnCourseUpdate_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnCourseDelete = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\CourseWindow.xaml"
            this.btnCourseDelete.Click += new System.Windows.RoutedEventHandler(this.btnCourseDelete_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.grdCourse = ((System.Windows.Controls.DataGrid)(target));
            
            #line 35 "..\..\..\CourseWindow.xaml"
            this.grdCourse.SelectedCellsChanged += new System.Windows.Controls.SelectedCellsChangedEventHandler(this.grdCourse_SelectedCellsChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtCourseName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtCourseCode = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.txtCourseCredit = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.txtMaxStudents = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

