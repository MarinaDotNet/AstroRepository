namespace AstroMath
{
    public class AstroMath
    {
        public double StarVelocity(double observedWavelength, double restWavelength)
        {
            return (double)Math.Round((((observedWavelength - restWavelength) / restWavelength) * 299792458));
        }
        public double StarDistance(double arcsecondsAngle)
        {
            return (double)Math.Round((1 / arcsecondsAngle), 1);
        }
        public double TempretureInKelvin(double celsius)
        {
            return double.IsNegative(((double)celsius + 273.0)) ? 0.0 : ((double)celsius + 273.0);
        }
        public double EventHorizon(double BlackholeMass)
        {
            return Math.Round((((2 * (6.674 * Math.Pow(10, -11)) * BlackholeMass) / Math.Pow(299792458.0, 2)) / Math.Pow(10, 10)), 1);
        }
    }
}