﻿#pragma checksum "d:\cguedes\ISEL\Studdy\Silverlight\Code\Silverlight_Playground\TwitterSearch\Views\SearchWithExplicitDatabind.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "ABA8FDC5977574DE6BEB1F6B4919327E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace TwitterSearch.Views {
    
    
    public partial class SearchWithExplicitDatabind : System.Windows.Controls.Page {
        
        internal System.Windows.Controls.BusyIndicator busyIndicator;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBox SearchBox;
        
        internal System.Windows.Controls.Button SearchButton;
        
        internal System.Windows.Controls.DataGrid SearchResults;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/TwitterSearch;component/Views/SearchWithExplicitDatabind.xaml", System.UriKind.Relative));
            this.busyIndicator = ((System.Windows.Controls.BusyIndicator)(this.FindName("busyIndicator")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.SearchBox = ((System.Windows.Controls.TextBox)(this.FindName("SearchBox")));
            this.SearchButton = ((System.Windows.Controls.Button)(this.FindName("SearchButton")));
            this.SearchResults = ((System.Windows.Controls.DataGrid)(this.FindName("SearchResults")));
        }
    }
}

