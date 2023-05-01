using System.ServiceModel;
using AstroMath;
/*
 * 
 * author: Marina Sichova
 * student Id: P272494
 * created: 03/04/2023
 * last updated: 24/04/2023
 * 
 * Server Application
 * server file implements IAstrocontracts Interface
 */
namespace ServiceContract
{
    [ServiceBehavior (ConcurrencyMode=ConcurrencyMode.Single,
    InstanceContextMode=InstanceContextMode.PerSession)]
    
    internal class AstroServer : IAstrocontracts
    {
        AstroData astroData = new AstroData();
        
        public double EventHorizon(double BlackholeMass, int pow)
        {
            return astroData.EventHorizon(BlackholeMass, pow);
        }

        public double StarDistance(double starDistance)
        {
            return astroData.StarDistance(starDistance);
        }

        public double StarVelocity(double observedWavelength, double restWavelength)
        {
            return astroData.StarVelocity(observedWavelength, restWavelength);
        }

        public double TempretureInKelvin(double celsius)
        {
            return astroData.TempretureInKelvin(celsius);
        }
    }
}
