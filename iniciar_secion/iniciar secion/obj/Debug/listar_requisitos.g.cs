﻿#pragma checksum "..\..\listar_requisitos.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0A319178F4D7B8BD07095121F9188DDB2F0F1F3CE1AC6388F2973FE11A672C56"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
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
using iniciar_secion;


namespace iniciar_secion {
    
    
    /// <summary>
    /// listar_requisitos
    /// </summary>
    public partial class listar_requisitos : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\listar_requisitos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid data_final;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\listar_requisitos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboX_requerimiento;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\listar_requisitos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comBO_prioridad;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\listar_requisitos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox che_pendiente;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\listar_requisitos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox che_resulato;
        
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
            System.Uri resourceLocater = new System.Uri("/iniciar secion;component/listar_requisitos.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\listar_requisitos.xaml"
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
            this.data_final = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.comboX_requerimiento = ((System.Windows.Controls.ComboBox)(target));
            
            #line 13 "..\..\listar_requisitos.xaml"
            this.comboX_requerimiento.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comboX_requerimiento_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.comBO_prioridad = ((System.Windows.Controls.ComboBox)(target));
            
            #line 18 "..\..\listar_requisitos.xaml"
            this.comBO_prioridad.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comBO_prioridad_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.che_pendiente = ((System.Windows.Controls.CheckBox)(target));
            
            #line 23 "..\..\listar_requisitos.xaml"
            this.che_pendiente.Checked += new System.Windows.RoutedEventHandler(this.fin);
            
            #line default
            #line hidden
            return;
            case 5:
            this.che_resulato = ((System.Windows.Controls.CheckBox)(target));
            
            #line 24 "..\..\listar_requisitos.xaml"
            this.che_resulato.Checked += new System.Windows.RoutedEventHandler(this.fin);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 25 "..\..\listar_requisitos.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

