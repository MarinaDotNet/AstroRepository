using System;
/*
 * 
 * author: Marina Sichova
 * student Id: P272494
 * created: 27/03/2023
 * last updated: 24/04/2023
 * 
 * Third party library AstroMath.dll with four mathematical formilas
 */
namespace AstroMath
{
    public class AstroData
    {
        public double StarVelocity(double observedWavelength, double restWavelength)
        {
            return (double)Math.Round((((observedWavelength - restWavelength) / restWavelength) * 299792458));
        }
        public double StarDistance(double arcsecondsAngle)
        {
            return (double)Math.Round((1 / arcsecondsAngle), 2);
        }
        public double TempretureInKelvin(double celsius)
        {
            return (((double)celsius + 273.0) <= 0.0) ? 0.0 : ((double)celsius + 273.0);
        }
        public double EventHorizon(double blackholeMass, int pow)
        {
            if (pow > 10)
            {
                pow -= 10;
            }
            double value = ((2 * 6.674 * (blackholeMass * Math.Pow(10, pow))) / Math.Pow(299792458, 2)) / 10;
            value /= Math.Pow(10, 10);
            return Math.Round(value, 1);
        }
    }
}
