using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media.Animation;
using WeatherApp.Commands;
using WeatherApp.Models;
using WeatherApp.Services;

namespace WeatherApp.ViewModels
{
    public class TemperatureViewModel : BaseViewModel
    {
        /// TODO : Ajoutez le code nécessaire pour réussir les tests et répondre aux requis du projet 
        public ITemperatureService TemperatureService;
        public DelegateCommand<String> GetTempCommand { get; set; }
        public TemperatureModel CurrentTemp { get; set; }

        public TemperatureViewModel()
        {
            GetTempCommand = new DelegateCommand<string>(GetTemperature);
        }

        private void GetTemperature(string obj)
        {
            if (TemperatureService == null)
                throw new NullReferenceException();
        }
        public static double CelsiusInFahrenheit(double c)
        {
            return Math.Round(c * 9 / 5 + 32, 1);
        }

        public static double FahrenheitInCelsius(double f)
        {
            return Math.Round((f - 32) * 5 / 9, 1);
        }

        public bool CanGetTemp()
        {
            if (TemperatureService == null) return false;
            else return true;
        }
    }
}
