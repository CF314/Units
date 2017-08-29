using System;

namespace CF314.Units
{
    public class Temperature
    {
        #region Properties/Fields

        private double kelvin;
        /// <summary>
        /// The temperature given in Kelvin (K).
        /// </summary>
        public double Kelvin
        {
            get => kelvin;
            set
            {
                kelvin = value;
                celsius = KelvinToCelsius(value);
                fahrenheit = KelvinToFahrenheit(value);
                rankine = KelvinToRankine(value);
                delisle = KelvinToDelisle(value);
                newton = KelvinToNewton(value);
                reamur = KelvinToReamur(value);
                roemer = KelvinToRoemer(value);
                OnChanged();
            }
        }

        private double celsius;
        /// <summary>
        /// The temperature given in degrees Celsius (°C).
        /// </summary>
        public double Celsius
        {
            get => celsius;
            set
            {
                celsius = value;
                kelvin = CelsiusToKelvin(value);
                fahrenheit = CelsiusToFahrenheit(value);
                rankine = CelsiusToRankine(value);
                delisle = CelsiusToDelisle(value);
                newton = CelsiusToNewton(value);
                reamur = CelsiusToReamur(value);
                roemer = CelsiusToRoemer(value);
                OnChanged();
            }
        }

        private double fahrenheit;
        /// <summary>
        /// The temperature given in degrees Fahrenheit (°F).
        /// </summary>
        public double Fahrenheit
        {
            get => Fahrenheit;
            set
            {
                fahrenheit = value;
                kelvin = FahrenheitToKelvin(value);
                celsius = FahrenheitToCelsius(value);
                rankine = FahrenheitToRankine(value);
                delisle = FahrenheitToDelisle(value);
                newton = FahrenheitToNewton(value);
                reamur = FahrenheitToReamur(value);
                roemer = FahrenheitToRoemer(value);
                OnChanged();
            }
        }

        private double rankine;
        /// <summary>
        /// The temperature given in degrees Rankine (°R).
        /// </summary>
        public double Rankine
        {
            get => rankine;
            set
            {
                rankine = value;
                kelvin = RankineToKelvin(value);
                celsius = RankineToCelsius(value);
                fahrenheit = RankineToFahrenheit(value);
                delisle = RankineToDelisle(value);
                newton = RankineToNewton(value);
                reamur = RankineToReamur(value);
                roemer = RankineToRoemer(value);
                OnChanged();
            }
        }

        private double delisle;
        /// <summary>
        /// The temperature given in degrees Delisle (°De).
        /// </summary>
        public double Delisle
        {
            get => delisle;
            set
            {
                delisle = value;
                kelvin = DelisleToKelvin(value);
                celsius = DelisleToCelsius(value);
                fahrenheit = DelisleToFahrenheit(value);
                rankine = DelisleToRankine(value);
                newton = DelisleToNewton(value);
                reamur = DelisleToReamur(value);
                roemer = DelisleToRoemer(value);
                OnChanged();
            }
        }

        private double newton;
        /// <summary>
        /// The temperature given in degrees Newton (°N).
        /// </summary>
        public double Newton
        {
            get => newton;
            set
            {
                newton = value;
                kelvin = NewtonToKelvin(value);
                celsius = NewtonToCelsius(value);
                fahrenheit = NewtonToFahrenheit(value);
                rankine = NewtonToRankine(value);
                delisle = NewtonToDelisle(value);
                reamur = NewtonToReamur(value);
                roemer = NewtonToRoemer(value);
                OnChanged();
            }
        }

        private double reamur;
        /// <summary>
        /// The temperature given in degrees Réamur (°Ré).
        /// </summary>
        public double Reamur
        {
            get => reamur;
            set
            {
                reamur = value;
                kelvin = ReamurToKelvin(value);
                celsius = ReamurToCelsius(value);
                fahrenheit = ReamurToFahrenheit(value);
                rankine = ReamurToRankine(value);
                delisle = ReamurToDelisle(value);
                newton = ReamurToNewton(value);
                roemer = ReamurToRoemer(value);
                OnChanged();
            }
        }

        private double roemer;
        /// <summary>
        /// The temperature given in degrees Rømer (°Rø).
        /// </summary>
        public double Roemer
        {
            get => roemer;
            set
            {
                roemer = value;
                kelvin = RoemerToKelvin(value);
                celsius = RoemerToCelsius(value);
                fahrenheit = RoemerToFahrenheit(value);
                rankine = RoemerToRankine(value);
                delisle = RoemerToDelisle(value);
                newton = RoemerToNewton(value);
                reamur = RoemerToReamur(value);
                OnChanged();
            }
        }
        #endregion


        #region Constructor

        /// <summary>
        /// Creates a new Temperature-Object set to 0 Kelvin.
        /// </summary>
        public Temperature()
        {
            Kelvin = 0;
        }
        #endregion


        #region Functions

        public static double KelvinToCelsius(double k)      => k - 273.15;
        public static double KelvinToFahrenheit(double k)   => k * 1.8 - 459.67;
        public static double KelvinToRankine(double k)      => k * 1.8;
        public static double KelvinToDelisle(double k)      => (373.15 - k) * 1.5;
        public static double KelvinToNewton(double k)       => (k - 273.15) * 0.33;
        public static double KelvinToReamur(double k)       => (k - 273.15) * 0.8;
        public static double KelvinToRoemer(double k)       => (k - 273.15) * 0.525 + 7.5;

        public static double CelsiusToKelvin(double c)      => c + 273.15;
        public static double CelsiusToFahrenheit(double c)  => c * 1.8 + 32.0;
        public static double CelsiusToRankine(double c)     => (c + 273.15) * 1.8;
        public static double CelsiusToDelisle(double c)     => (100.0 - c) * 1.5;
        public static double CelsiusToNewton(double c)      => c * 0.33;
        public static double CelsiusToReamur(double c)      => c * 0.8;
        public static double CelsiusToRoemer(double c)      => c * 0.525 + 7.5;

        public static double FahrenheitToKelvin(double f)   => (f + 459.67) * (5.0 / 9.0);
        public static double FahrenheitToCelsius(double f)  => (f - 32.0) * (5.0 / 9.0);
        public static double FahrenheitToRankine(double f)  => f + 459.67;
        public static double FahrenheitToDelisle(double f)  => (212.0 - f) * (5.0 / 6.0);
        public static double FahrenheitToNewton(double f)   => (f - 32.0) * (11.0 / 60.0);
        public static double FahrenheitToReamur(double f)   => (f - 32.0) * (4.0 / 9.0);
        public static double FahrenheitToRoemer(double f)   => (f - 32.0) * (7.0 / 24.0) + 7.5;

        public static double RankineToKelvin(double r)      => r * (5.0 / 9.0);
        public static double RankineToCelsius(double r)     => (r - 491.67) * (5.0 / 9.0);
        public static double RankineToFahrenheit(double r)  => r - 491.67;
        public static double RankineToDelisle(double r)     => (671.67 - r) * (5.0 / 6.0);
        public static double RankineToNewton(double r)      => (r - 491.67) * (11.0 / 60.0);
        public static double RankineToReamur(double r)      => (r - 491.67) * (4.0 / 9.0);
        public static double RankineToRoemer(double r)      => (r - 491.67) * (7.0 / 24.0) + 7.5;

        public static double DelisleToKelvin(double de)     => (373.15 - de) * (2.0 / 3.0);
        public static double DelisleToCelsius(double de)    => (100.0 - de) * (2.0 / 3.0);
        public static double DelisleToFahrenheit(double de) => (212.0 - de) * 1.2;
        public static double DelisleToRankine(double de)    => (671.67 - de) * 1.2;
        public static double DelisleToNewton(double de)     => (33 - de) * (11.0 / 50.0);
        public static double DelisleToReamur(double de)     => (80 - de) * (8.0 / 15.0);
        public static double DelisleToRoemer(double de)     => (60 - de) * (7.0 / 20.0);

        public static double NewtonToKelvin(double n)       => n * (100.0 / 30.0) + 273.15;
        public static double NewtonToCelsius(double n)      => n * (100.0 / 30.0);
        public static double NewtonToFahrenheit(double n)   => n * (60.0 / 11.0) + 32;
        public static double NewtonToRankine(double n)      => n * (60.0 / 11.0) + 491.67;
        public static double NewtonToDelisle(double n)      => (33 - n) * (50.0 / 11.0);
        public static double NewtonToReamur(double n)       => n * (80.0 / 33.0);
        public static double NewtonToRoemer(double n)       => n * (35.0 / 22.0) + 7.5;

        public static double ReamurToKelvin(double re)      => re * 1.25 + 273.15;
        public static double ReamurToCelsius(double re)     => re * 1.25;
        public static double ReamurToFahrenheit(double re)  => re * 2.25 + 32;
        public static double ReamurToRankine(double re)     => re * 2.25 + 491.67;
        public static double ReamurToDelisle(double re)     => (80 - re) * 1.875;
        public static double ReamurToNewton(double re)      => re * (33.0 / 80.0);
        public static double ReamurToRoemer(double re)      => re * (21.0 / 32.0) + 7.5;

        public static double RoemerToKelvin(double ro)      => (ro - 7.5) * (40.0 / 21.0) + 273.15;
        public static double RoemerToCelsius(double ro)     => (ro - 7.5) * (40.0 / 21.0);
        public static double RoemerToFahrenheit(double ro)  => (ro - 7.5) * (24.0 / 7.0) + 32;
        public static double RoemerToRankine(double ro)     => (ro - 7.5) * (24.0 / 7.0) + 491.67;
        public static double RoemerToDelisle(double ro)     => (60 - ro) * (20.0 / 7.0);
        public static double RoemerToNewton(double ro)      => (ro - 7.5) * (22.0 / 35.0);
        public static double RoemerToReamur(double ro)      => (ro - 7.5) * (32.0 / 21.0);
        #endregion


        #region Events

        /// <summary>
        /// Gets invoked when the object's value changes.
        /// </summary>
        public event Action Changed;
        /// <summary>
        /// Invokes the <see cref="Changed"/>-Event.
        /// </summary>
        protected virtual void OnChanged()
        {
            Changed?.Invoke();
        }
        #endregion
    }
}
