﻿

#pragma checksum "C:\Users\Ivailo\Desktop\PaintRTWithSaveOpenFiles\PaintRT\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2F264C332E17AA45D3FD0D119DD14284"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PaintRT
{
    partial class MainPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 11 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.StackPanel_Tapped;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 15 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.LoadProjectButtonClick;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 16 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.SaveProjectButtonClick;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 25 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).ManipulationDelta += this.RotatingEllipseManipulationDelta;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 18 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).ManipulationDelta += this.MovingCanvasManipulationDelta;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}

