namespace Clock;

public partial class SevenSegmentNumber : ContentView
{

    public static readonly BindableProperty NumberProperty =
            BindableProperty.Create(nameof(Number), typeof(int), typeof(SevenSegmentNumber), 0,
                propertyChanged: (bindable, oldValue, newValue) =>
                {
                    var display = (SevenSegmentNumber)bindable;
                    display.convertNumber();
                });

    public int Number
    {
        get => (int)GetValue(NumberProperty);
        set => SetValue(NumberProperty, value);
    }


    bool[][] numberConvert =
        [
            [true, false, true, true, true, true, true],
            [false, false, false, false, true, false, true],
            [true, true, true, false, true, true, false],
            [true, true, true, false, true, false, true],
            [false, true, false, true, true, false, true],
            [true, true, true, true, false, false, true],
            [true, true, true, true, false, true, true],
            [true, false, false, false, true, false, true],
            [true, true, true, true, true, true, true],
            [true, true, true, true, true, false, true],
        ];

    public void convertNumber()
    {
        if (Number < 0 || Number > 9) return;

        HorTop.IsVisible = numberConvert[Number][0];
        HorMiddle.IsVisible = numberConvert[Number][1];
        HorBottom.IsVisible = numberConvert[Number][2];
        VerTopLeft.IsVisible = numberConvert[Number][3];
        VerTopRight.IsVisible = numberConvert[Number][4];
        VerBottomLeft.IsVisible = numberConvert[Number][5];
        VerBottomRight.IsVisible = numberConvert[Number][6];
    }



    public SevenSegmentNumber()
	{
        InitializeComponent();
        convertNumber();
    }
}