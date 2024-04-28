using System.ComponentModel;
using DisneyWorldConstants = AboutDisneyWorldConstants.AboutDisneyWorldConstants;

namespace AboutDisneyWorld
{
    public class MainWindowViewModel: INotifyPropertyChanged
    {
        public MainWindowViewModel()
        {
            _title = DisneyWorldConstants.MainWindowHeader;
            _description = DisneyWorldConstants.MainWindowDescription;
        }

        private string _title;
        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(Title)));
            } 
        }

        private string _description;
        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(Description)));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}