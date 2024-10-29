namespace Clock;

public partial class SevenSegmentNumber : ContentView
{
    public static readonly BindableProperty NumberProperty =
        BindableProperty.Create(nameof(Number), typeof(int), typeof(SevenSegmentNumber), 0,
            propertyChanged: OnNumberChanged);

    public int Number
    {
        get => (int)GetValue(NumberProperty);
        set => SetValue(NumberProperty, value);
    }

    private static void OnNumberChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var control = (SevenSegmentNumber)bindable;
        control.OnNumberChanged((int)newValue);
    }

    private void OnNumberChanged(int newNumber)
    {
        convertNumber(newNumber);
    }

    public static readonly BindableProperty HorTopProperty = BindableProperty.Create(nameof(HorTop), typeof(bool), typeof(SevenSegmentNumber), false);
    public bool HorTop
    {
        get => (bool)GetValue(HorTopProperty);
        set
        {
            SetValue(HorTopProperty, value);
        }
    }

    public static readonly BindableProperty HorMiddleProperty = BindableProperty.Create(nameof(HorMiddle), typeof(bool), typeof(SevenSegmentNumber), false);
    public bool HorMiddle
    {
        get => (bool)GetValue(HorMiddleProperty);
        set
        {
            SetValue(HorMiddleProperty, value);
        }
    }

    public static readonly BindableProperty HorBottomProperty = BindableProperty.Create(nameof(HorBottom), typeof(bool), typeof(SevenSegmentNumber), false);
    public bool HorBottom
    {
        get => (bool)GetValue(HorBottomProperty);
        set
        {
            SetValue(HorBottomProperty, value);
        }
    }


    public static readonly BindableProperty VerTopLeftProperty = BindableProperty.Create(nameof(VerTopLeft), typeof(bool), typeof(SevenSegmentNumber), false);
    public bool VerTopLeft
    {
        get => (bool)GetValue(VerTopLeftProperty);
        set
        {
            SetValue(VerTopLeftProperty, value);
        }
    }

    public static readonly BindableProperty VerTopRightProperty = BindableProperty.Create(nameof(VerTopRight), typeof(bool), typeof(SevenSegmentNumber), false);
    public bool VerTopRight
    {
        get => (bool)GetValue(VerTopRightProperty);
        set
        {
            SetValue(VerTopRightProperty, value);
        }
    }

    public static readonly BindableProperty VerBottomLeftProperty = BindableProperty.Create(nameof(VerBottomLeft), typeof(bool), typeof(SevenSegmentNumber), false);
    public bool VerBottomLeft
    {
        get => (bool)GetValue(VerBottomLeftProperty);
        set
        {
            SetValue(VerBottomLeftProperty, value);
        }
    }

    public static readonly BindableProperty VerBottomRightProperty = BindableProperty.Create(nameof(VerBottomRight), typeof(bool), typeof(SevenSegmentNumber), false);
    public bool VerBottomRight
    {
        get => (bool)GetValue(VerBottomRightProperty);
        set
        {
            SetValue(VerBottomRightProperty, value);
        }
    }


    public SevenSegmentNumber()
	{
        InitializeComponent();
        BindingContext = this;
    }

    public void convertNumber(int number)
    {
        switch (number)
        {
            case 0:
                HorTop = true;
                HorBottom = true;
                HorMiddle = false;
                VerTopLeft = true;
                VerTopRight = true;
                VerBottomLeft = true;
                VerBottomRight = true;
                break;

            case 1:
                HorTop = false;
                HorMiddle = false;
                HorBottom = false;
                VerTopLeft=false;
                VerTopRight = true;
                VerBottomLeft=false;
                VerBottomRight = true;
                break;

            case 2:
                HorTop = true;
                HorMiddle = true;
                HorBottom = true;
                VerTopLeft = false;
                VerTopRight = true;
                VerBottomLeft = true;
                VerBottomRight = false;
                break;
                
            case 3:
                HorTop = true;
                HorMiddle = true;
                HorBottom = true;
                VerTopLeft = false;
                VerTopRight = true;
                VerBottomLeft = false;
                VerBottomRight = true;
                break;

            case 4:
                HorTop = false;
                HorMiddle = true;
                HorBottom = false;
                VerTopLeft = true;
                VerTopRight = true;
                VerBottomLeft = false;
                VerBottomRight = true;
                break;

            case 5:
                HorTop = true;
                HorMiddle = true;
                HorBottom = true;
                VerTopLeft = true;
                VerTopRight = false;
                VerBottomLeft = false;
                VerBottomRight = true;
                break;

            case 6:
                HorTop = true;
                HorMiddle = true;
                HorBottom = true;
                VerTopLeft = true;
                VerTopRight = false;
                VerBottomLeft = true;
                VerBottomRight = true;
                break;

            case 7:
                HorTop = true;
                HorMiddle = false;
                HorBottom = false;
                VerTopLeft = false;
                VerTopRight = true;
                VerBottomLeft = false;
                VerBottomRight = true;
                break;

            case 8:
                HorTop = true;
                HorMiddle = true;
                HorBottom = true;
                VerTopLeft = true;
                VerTopRight = true;
                VerBottomLeft = true;
                VerBottomRight = true;
                break;

            case 9:
                HorTop = true;
                HorMiddle = true;
                HorBottom = true;
                VerTopLeft = true;
                VerTopRight = true;
                VerBottomLeft = false;
                VerBottomRight = true;
                break;
        }
    }
}