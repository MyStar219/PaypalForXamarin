// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace PaypalForXamarin {
    using System;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    
    
    public partial class SettingsPage : ContentPage {
        
        private Label lblProduction;
        
        private Switch swtProduction;
        
        private Label lblSandbox;
        
        private Switch swtSandbox;
        
        private Label lblMock;
        
        private Switch swtMock;
        
        private void InitializeComponent() {
            this.LoadFromXaml(typeof(SettingsPage));
            lblProduction = this.FindByName <Label>("lblProduction");
            swtProduction = this.FindByName <Switch>("swtProduction");
            lblSandbox = this.FindByName <Label>("lblSandbox");
            swtSandbox = this.FindByName <Switch>("swtSandbox");
            lblMock = this.FindByName <Label>("lblMock");
            swtMock = this.FindByName <Switch>("swtMock");
        }
    }
}
