using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;

namespace Store_Online.Shared.Controls
{
    public class GarageTimelineItem : INotifyPropertyChanged
    {
        private string _title;
        private string _description;
        private string _user;
        private string _time;
        private Brush _indicatorBrush;

        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }

        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged();
            }
        }

        public string User
        {
            get => _user;
            set
            {
                _user = value;
                OnPropertyChanged();
            }
        }

        public string Time
        {
            get => _time;
            set
            {
                _time = value;
                OnPropertyChanged();
            }
        }

        public Brush IndicatorBrush
        {
            get => _indicatorBrush;
            set
            {
                _indicatorBrush = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}