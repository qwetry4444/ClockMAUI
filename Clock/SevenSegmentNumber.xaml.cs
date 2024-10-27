namespace Clock;

public partial class SevenSegmentNumber : ContentView
{
    public bool HorTop
    {
        get { return horTop; }
        set { horTop = value; }
    }
    public bool HorMiddle
    {
        get { return horMiddle; }
        set { horMiddle = value; }
    }
    public bool HorBottom
    {
        get { return horBottom; }
        set { horBottom = value; }
    }
    public bool VerTopLeft
    {
        get { return verTopLeft; }
        set { verTopLeft = value; }
    }
    public bool VerTopRight
    {
        get { return verTopRight; }
        set { verTopRight = value; }
    }
    public bool VerBottomLeft
    {
        get { return verBottomLeft; }
        set { verBottomLeft = value; }
    }
    public bool VerBottomRight
    {
        get { return verBottomRight; }
        set { verBottomRight = value; }
    }

    public int Number
    {
        get { return number; }
        set { number = value; }
    }

    public bool horTop = false;
    bool horMiddle = false;
    bool horBottom = false;
    bool verTopLeft = false;
    bool verTopRight = false;
    bool verBottomLeft = false;
    bool verBottomRight = false;
    public int number = 1;

    public SevenSegmentNumber()
	{
        convertNumber(number);
        BindingContext = this;
        InitializeComponent();
        
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
                VerTopLeft = false;
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