using DataBinding.DataObject.Models;

namespace DataBinding.DataObject
{
    public partial class MainPage : ContentPage
    {
        //_conteo lleva el conteo de la apicación
        private Contador contador;

        public MainPage()
        {
            InitializeComponent();
            contador = new Contador();
            BindingContext = contador;
        }

        private void OnContarButtonClicked(object sender, EventArgs e)
        {
            contador.Contar();
        }

        private void OnReiniciarButtonClicked(object sender, EventArgs e)
        {
            contador.Reiniciar();
        }
    }
}
