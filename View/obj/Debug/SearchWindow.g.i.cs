﻿#pragma checksum "..\..\SearchWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02BC3BB5F5B1644DEE631238AB8EB7EEF70D2642"
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
using View;


namespace View {
    
    
    /// <summary>
    /// SearchWindow
    /// </summary>
    public partial class SearchWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\SearchWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid searchDataGrid;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\SearchWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox figureComboBox;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\SearchWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox allFigure;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\SearchWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox searchListBox;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\SearchWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox allFigureWithParam;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\SearchWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox figureParamTextBox;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\SearchWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox figureTypeComboBox;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\SearchWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox figuresWithParam;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\SearchWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox figureParam2TextBox;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\SearchWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label foundFigures;
        
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
            System.Uri resourceLocater = new System.Uri("/View;component/searchwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SearchWindow.xaml"
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
            this.searchDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 17 "..\..\SearchWindow.xaml"
            this.searchDataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SearchDataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.figureComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 18 "..\..\SearchWindow.xaml"
            this.figureComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.allFigure = ((System.Windows.Controls.CheckBox)(target));
            
            #line 23 "..\..\SearchWindow.xaml"
            this.allFigure.Checked += new System.Windows.RoutedEventHandler(this.AllFigure_Checked);
            
            #line default
            #line hidden
            
            #line 23 "..\..\SearchWindow.xaml"
            this.allFigure.Click += new System.Windows.RoutedEventHandler(this.AllFigure_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.searchListBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 24 "..\..\SearchWindow.xaml"
            this.searchListBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SearchListBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.allFigureWithParam = ((System.Windows.Controls.CheckBox)(target));
            
            #line 38 "..\..\SearchWindow.xaml"
            this.allFigureWithParam.Checked += new System.Windows.RoutedEventHandler(this.CheckBox_Checked_1);
            
            #line default
            #line hidden
            
            #line 38 "..\..\SearchWindow.xaml"
            this.allFigureWithParam.Click += new System.Windows.RoutedEventHandler(this.AllFigureWithParam_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.figureParamTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.figureTypeComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.figuresWithParam = ((System.Windows.Controls.CheckBox)(target));
            
            #line 46 "..\..\SearchWindow.xaml"
            this.figuresWithParam.Checked += new System.Windows.RoutedEventHandler(this.FiguresWithParam_Checked);
            
            #line default
            #line hidden
            
            #line 46 "..\..\SearchWindow.xaml"
            this.figuresWithParam.Click += new System.Windows.RoutedEventHandler(this.FiguresWithParam_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.figureParam2TextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            
            #line 49 "..\..\SearchWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 57 "..\..\SearchWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 12:
            this.foundFigures = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
