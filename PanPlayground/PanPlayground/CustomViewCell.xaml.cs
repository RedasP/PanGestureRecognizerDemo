using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PanPlayground
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomViewCell : ViewCell
    {
        public CustomViewCell()
        {
            InitializeComponent();
        }

        private void PanGestureRecognizer_OnPanUpdated(object sender, PanUpdatedEventArgs e)
        {
            
            Debug.WriteLine($"{e.StatusType} {e.TotalX} {e.TotalY}");
        }
    }
}