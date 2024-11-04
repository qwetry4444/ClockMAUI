using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Clock
{
    public partial class MainPage : ContentPage
    {
        public ClockViewModel ViewModel { get; set; }

        public MainPage()
        {
            InitializeComponent();
            ViewModel = new ClockViewModel();
            BindingContext = ViewModel;

            
            HourTensDisplay.SetBinding(SevenSegmentNumber.NumberProperty, nameof(ViewModel.HourTens));
            HourUnitsDisplay.SetBinding(SevenSegmentNumber.NumberProperty, nameof(ViewModel.HourUnits));
            MinuteTensDisplay.SetBinding(SevenSegmentNumber.NumberProperty, nameof(ViewModel.MinuteTens));
            MinuteUnitsDisplay.SetBinding(SevenSegmentNumber.NumberProperty, nameof(ViewModel.MinuteUnits));
            SecondTensDisplay.SetBinding(SevenSegmentNumber.NumberProperty, nameof(ViewModel.SecondTens));
            SecondUnitsDisplay.SetBinding(SevenSegmentNumber.NumberProperty, nameof(ViewModel.SecondUnits));
        }
    }

}
