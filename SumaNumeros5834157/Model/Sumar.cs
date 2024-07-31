using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaNumeros5834157.Model
{
    partial class Sumar : ObservableObject
    {
        [ObservableProperty]
        public string numero1;
        [ObservableProperty]
        public string numero2;
        [ObservableProperty]
        public string resultado;

        [RelayCommand]
        private void ActualizarDatos()
        {
            if (double.TryParse(Numero1, out double num1) && double.TryParse(Numero2, out double num2))
            {
                Resultado = (num1 + num2).ToString();
            }
            else
            {
                Resultado = "Ingrese números válidos";
            }
        }
    }
}
