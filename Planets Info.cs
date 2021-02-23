using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planet
{
    public class Planet
    {
        private string PlanetName;
        private double Mass;
        private int Diameter;
        private int Density;
        private double Gravity;
        private double RotationPeriod;
        private double LengthOfDay;
        private double DistanceToSun;
        private double OrbitalPeriod;
        private double OrbitalVelocity;
        private double MeanTemperature;
        private int NumberOfMoons;
        private string RingSystem;


        public Planet(string _PlanetName, double _Mass, int _Diameter, int _Density, double _Gravity, double _RotationPeriod, double _LengthOfDay, double _DistanceToSun, double _OrbitalPeriod, double _OrbitalVelocity, double _MeanTemperature, int _NumberOfMoons, string _Ringsystem)
        {
            this.PlanetName = _PlanetName;
            this.Mass = _Mass ;
            this.Diameter = _Diameter;
            this.Density = _Density;
            this.Gravity = _Gravity;
            this.RotationPeriod = _RotationPeriod;
            this.LengthOfDay = _LengthOfDay;
            this.DistanceToSun = _DistanceToSun;
            this.OrbitalPeriod = _OrbitalPeriod;
            this.OrbitalVelocity = _OrbitalVelocity;
            this.MeanTemperature = _MeanTemperature;
            this.NumberOfMoons = _NumberOfMoons;
            this.RingSystem = _Ringsystem;
        }
        public string planetName
        { 
            get { return PlanetName; }
            set { PlanetName = value; }
        }
        public double planetMass
        {
            get { return Mass; }
            set { Mass = value; }
        }
        public int planetDiameter
        {
            get { return Diameter; }
            set { Diameter = value; }
        }
        public int planetDensity
        {
            get { return Density; }
            set { Density = value; }
        }
        public double planetGravity
        {
            get { return Gravity; }
            set { Gravity = value; }
        }
        public double planetRotationPeriod
        {
            get { return RotationPeriod; }
            set { RotationPeriod = value; }
        }
        public double planetLengthOfDay
        {
            get { return LengthOfDay; }
            set { LengthOfDay = value; }
        }
        public double planetDistanceToSun
        {
            get { return DistanceToSun; }
            set { DistanceToSun = value; }
        }
        public double planetOrbitalPeriod
        {
            get { return OrbitalPeriod; }
            set { OrbitalPeriod = value; }
        }
        public double planetOrbitalVelocity
        {
            get { return OrbitalVelocity; }
            set { OrbitalVelocity = value; }
        }
        public double planetMeanTemperature
        {
            get { return MeanTemperature; }
            set { MeanTemperature = value; }
        }
        public int planetNumberOfMoons
        {
            get { return NumberOfMoons; }
            set { NumberOfMoons = value; }
        }
        public string planetRingSystem
        {
            get { return RingSystem; }
            set { RingSystem = value; }
        }

    }
}
