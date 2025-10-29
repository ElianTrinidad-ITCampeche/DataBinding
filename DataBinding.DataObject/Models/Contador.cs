using System.ComponentModel;

namespace DataBinding.DataObject.Models
{
    public class Contador : INotifyPropertyChanged
    {
        private int _conteo;

        public event PropertyChangedEventHandler? PropertyChanged;

        public int Conteo
        {
            get => _conteo;
            set
            {
                if (_conteo != value)
                {
                    _conteo = value;
                    OnPropertyChanged(nameof(Conteo));
                    // OnPropertyChanged("Conteo");
                }
            }
        }

        public Contador()
        {
            Conteo = 0;
        }

        public void Contar()
        {
            Conteo++;
        }

        public void Reiniciar()
        {
            Conteo = 0;
        }

        private void OnPropertyChanged(string propertyName) 
        {
            /*if (PropertyChanged != null)
            {
                PropertyChanged(
                    this, 
                    new PropertyChangedEventArgs(propertyName));
            } */
            // Esta es otra forma de hacer lo anterior
            PropertyChanged?.Invoke(
                this, 
                new PropertyChangedEventArgs(propertyName)
                );
        }
    }
}
