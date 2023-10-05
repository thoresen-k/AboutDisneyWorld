using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace wpf_example
{
    public class ViewModel : INotifyPropertyChanged
    {
        public ViewModel()
        {
            Assembly assembly =  GetType().Assembly;

            foreach (CustomAttributeData attr in assembly.GetCustomAttributesData())
            {
                try
                {
                    if (attr.AttributeType.Name == "AssemblyFileVersionAttribute")
                    {
                        _version = attr.ConstructorArguments?.FirstOrDefault().Value.ToString();
                        break;
                    }
                }
                catch (Exception ex)
                {
                    // We are missing the required dependency assembly.
                    //Console.WriteLine($"Error while getting attribute type: {ex.Message}");
                }
            }
        }

        private string _version;
        public string Version
        {
            get => _version;
            set
            {
                _version = value;
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(Version)));
            }
        }

        private string _extraText;
        public string ExtraText
        {
            get => _extraText;
            set
            {
                _extraText = value;
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(ExtraText)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
