//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RebateReminder.Views {
    using System;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    
    
    public partial class StoresView : ContentPage {
        
        private ListView storeList;
        
        private Button btnAdd;
        
        private void InitializeComponent() {
            this.LoadFromXaml(typeof(StoresView));
            storeList = this.FindByName<ListView>("storeList");
            btnAdd = this.FindByName<Button>("btnAdd");
        }
    }
}
