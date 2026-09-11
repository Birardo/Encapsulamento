

namespace Encapsulamento
{
    internal class Termometro
    {
        private double _temperaturaCelcius;
        public double f;
        public double k;

        public double celcius
        {
            get { return  _temperaturaCelcius;}
            set
            {
                _temperaturaCelcius = value;
            }
        }
        public double fahrenheit
        {
            get { return (_temperaturaCelcius * 9 / 5) + 32;
            }
            set
            {
                _temperaturaCelcius= (value - 32) * 5 / 9;
            }
        }
        public double kelvin
        {
            get
            {
                return _temperaturaCelcius = celcius + 273.15;
            }
            set
            {
                _temperaturaCelcius = value - 273.15;
            }
        }
    }
}
