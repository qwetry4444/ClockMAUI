using System.Security.Cryptography.X509Certificates;

namespace Clock
{
    public partial class MainPage : ContentPage
    {
        public static readonly BindableProperty HourTensProperty =
            BindableProperty.Create(nameof(HourTens), typeof(int), typeof(MainPage), 0);

        public int HourTens
        {
            get => (int)GetValue(HourTensProperty);
            set
            {
                SetValue(HourTensProperty, value);
            }
        }

        public static readonly BindableProperty HourUnitsProperty =
            BindableProperty.Create(nameof(HourUnits), typeof(int), typeof(MainPage), 0);

        public int HourUnits
        {
            get => (int)GetValue(HourUnitsProperty);
            set
            {
                SetValue(HourUnitsProperty, value);
            }
        }

        public static readonly BindableProperty MinuteTensProperty =
            BindableProperty.Create(nameof(MinuteTens), typeof(int), typeof(MainPage), 0);

        public int MinuteTens
        {
            get => (int)GetValue(MinuteTensProperty);
            set
            {
                SetValue(MinuteTensProperty, value);
            }
        }

        public static readonly BindableProperty MinuteUnitsProperty =
            BindableProperty.Create(nameof(MinuteUnits), typeof(int), typeof(MainPage), 0);

        public int MinuteUnits
        {
            get => (int)GetValue(MinuteUnitsProperty);
            set
            {
                SetValue(MinuteUnitsProperty, value);
            }
        }

        DateTime time;

        public void updateTime()
        {
            time = DateTime.Now;

            HourTens = time.Hour / 10;
            HourUnits = time.Hour % 10;
            MinuteTens = time.Minute / 10;
            MinuteUnits = time.Minute % 10;
        }

        public MainPage()
        {
            updateTime();

            InitializeComponent();
            BindingContext = this;
            updateTime();
        }
    }

}
