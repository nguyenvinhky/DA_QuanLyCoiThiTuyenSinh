﻿#pragma checksum "..\..\fDoiMatKhau_User.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3DBE3FB6107E213CA58B0053D3226F38ADBCE3ABF1BEC195C137B242571D19D8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using QuanLyCoiThiTuyenSinh;
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


namespace QuanLyCoiThiTuyenSinh {
    
    
    /// <summary>
    /// fDoiMatKhau_User
    /// </summary>
    public partial class fDoiMatKhau_User : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 54 "..\..\fDoiMatKhau_User.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTenTruyCap;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\fDoiMatKhau_User.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtMatKhauCu;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\fDoiMatKhau_User.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtMatKhauMoi;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\fDoiMatKhau_User.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtXacNhanMK;
        
        #line default
        #line hidden
        
        
        #line 122 "..\..\fDoiMatKhau_User.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCapNhatMK;
        
        #line default
        #line hidden
        
        
        #line 133 "..\..\fDoiMatKhau_User.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnHuyCapNhatMK;
        
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
            System.Uri resourceLocater = new System.Uri("/QuanLyCoiThiTuyenSinh;component/fdoimatkhau_user.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\fDoiMatKhau_User.xaml"
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
            this.txtTenTruyCap = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtMatKhauCu = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 3:
            this.txtMatKhauMoi = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 4:
            this.txtXacNhanMK = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 5:
            this.btnCapNhatMK = ((System.Windows.Controls.Button)(target));
            
            #line 123 "..\..\fDoiMatKhau_User.xaml"
            this.btnCapNhatMK.Click += new System.Windows.RoutedEventHandler(this.btnCapNhatMK_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnHuyCapNhatMK = ((System.Windows.Controls.Button)(target));
            
            #line 134 "..\..\fDoiMatKhau_User.xaml"
            this.btnHuyCapNhatMK.Click += new System.Windows.RoutedEventHandler(this.btnHuyCapNhatMK_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

