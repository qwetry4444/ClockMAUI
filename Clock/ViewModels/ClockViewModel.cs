using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    public class ClockViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        int _hourTens = 0;
        public int HourTens
        {
            get => _hourTens;
            set
            {
                if (value != _hourTens)
                {
                    _hourTens = value;
                    OnPropertyChanged();
                }
            }
        }

        int _hourUnits = 0;
        public int HourUnits
        {
            get => _hourUnits;
            set
            {
                if (value != _hourUnits)
                {
                    _hourUnits = value;
                    OnPropertyChanged();
                }
            }
        }

        int _minuteTens = 0;
        public int MinuteTens
        {
            get => _minuteTens;
            set
            {
                if (value != _minuteTens)
                {
                    _minuteTens = value;
                    OnPropertyChanged();
                }
            }
        }

        int _minuteUnits = 0;
        public int MinuteUnits
        {
            get => _minuteUnits;
            set
            {
                if (value != _minuteUnits)
                {
                    _minuteUnits = value;
                    OnPropertyChanged();
                }
            }
        }

        int _secondTens = 0;
        public int SecondTens
        {
            get => _secondTens;
            set
            {
                if (value != _secondTens)
                {
                    _secondTens = value;
                    OnPropertyChanged();
                }
            }
        }

        int _secondUnits = 0;
        public int SecondUnits
        {
            get => _secondUnits;
            set
            {
                if (value != _secondUnits)
                {
                    _secondUnits = value;
                    OnPropertyChanged();
                }
            }
        }

        public DateTime time;
        public void updateTime()
        {
            time = DateTime.Now;

            HourTens = time.Hour / 10;
            HourUnits = time.Hour % 10;
            MinuteTens = time.Minute / 10;
            MinuteUnits = time.Minute % 10;
            SecondTens = time.Second / 10;
            SecondUnits = time.Second % 10;
        }

        async Task updateTimeEverySecond()
        {
            var periodicTimer = new PeriodicTimer(TimeSpan.FromSeconds(1));
            while (await periodicTimer.WaitForNextTickAsync())
            {
                updateTime();
            }
        }

        
        public ClockViewModel() 
        {
            updateTimeEverySecond();
        }
    }
}
