﻿#pragma checksum "..\..\DevilUnion.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06E7B67EA546A8EDA5EDFE650E79230274F64D68"
//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

using DevilAnalyzer;
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


namespace DevilAnalyzer {
    
    
    /// <summary>
    /// DevilUnion
    /// </summary>
    public partial class DevilUnion : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\DevilUnion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevilAnalyzer.DevilUnion UnionAnswer;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\DevilUnion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblDevilName;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\DevilUnion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblGrade;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\DevilUnion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblReality;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\DevilUnion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgUnionAnswer;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\DevilUnion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblUnionCount;
        
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
            System.Uri resourceLocater = new System.Uri("/DevilAnalyzer;component/devilunion.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DevilUnion.xaml"
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
            this.UnionAnswer = ((DevilAnalyzer.DevilUnion)(target));
            
            #line 8 "..\..\DevilUnion.xaml"
            this.UnionAnswer.KeyUp += new System.Windows.Input.KeyEventHandler(this.UnionAnswer_KeyUp);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lblDevilName = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.lblGrade = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.lblReality = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.dgUnionAnswer = ((System.Windows.Controls.DataGrid)(target));
            
            #line 23 "..\..\DevilUnion.xaml"
            this.dgUnionAnswer.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.dgUnionAnswer_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lblUnionCount = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

