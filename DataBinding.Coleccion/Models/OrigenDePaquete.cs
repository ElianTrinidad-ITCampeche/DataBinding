using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBinding.Coleccion.Models
{
    public class OrigenDePaquete : INotifyPropertyChanged
    {
        //public string Nombre { get; set; } = string.Empty;
        //public string Origen { get; set; } = string.Empty;
        //public bool EstaHabilitado { get; set; } = false;

        private string? _nombre = string.Empty;
        private string? _origen = string.Empty;
        private bool _estaHabilitado = false;

        public string? Nombre
        {
            get => _nombre;
            set
            {
                if (value != _nombre)
                {
                    _nombre = value;
                    OnPropertyChanged(nameof(Nombre));
                }
            }
        }

        public string? Origen
        {
            get => _origen;
            set
            {
                if (_origen != value)
                {
                    _origen = value;
                    OnPropertyChanged(nameof(Origen));
                }
                
            }
        }

        public bool EstaHabilitado
        {
            get => _estaHabilitado;
            set
            {
                if (_estaHabilitado  != value)
                {
                    _estaHabilitado= value;
                    OnPropertyChanged(nameof(EstaHabilitado));
                }
                
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public override string ToString()
        {
            return $"{Nombre} - ({Origen})";
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(
                this, new PropertyChangedEventArgs(propertyName)
                );
        }
    }
}
