﻿#pragma checksum "..\..\UpdateStaff.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C2A63251F328B39B4FCAB8E2ED6620E32621C00961FD273C8BB8DD32022C034B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using TestFunW;


namespace TestFunW {
    
    
    /// <summary>
    /// UpdateStaff
    /// </summary>
    public partial class UpdateStaff : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\UpdateStaff.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btUPD;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\UpdateStaff.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbSurname1;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\UpdateStaff.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbName1;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\UpdateStaff.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbPatronymic1;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\UpdateStaff.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker date1;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\UpdateStaff.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Sub1;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\UpdateStaff.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Gen1;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\UpdateStaff.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btCLOSE;
        
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
            System.Uri resourceLocater = new System.Uri("/TestFunW;component/updatestaff.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UpdateStaff.xaml"
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
            this.btUPD = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\UpdateStaff.xaml"
            this.btUPD.Click += new System.Windows.RoutedEventHandler(this.btUPD_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tbSurname1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tbName1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tbPatronymic1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.date1 = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.Sub1 = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.Gen1 = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.btCLOSE = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\UpdateStaff.xaml"
            this.btCLOSE.Click += new System.Windows.RoutedEventHandler(this.btCLOSE_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

