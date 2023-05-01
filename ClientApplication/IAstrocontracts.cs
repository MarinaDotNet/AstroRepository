using System.ServiceModel;
/*
 * 
 * author: Marina Sichova
 * student Id: P272494
 * created: 03/04/2023
 * last updated: 24/04/2023
 * 
 * Client Side Application
 * Interface IAstrocontracts 
 */
namespace ClientApplication
{
    [ServiceContract]
    internal interface IAstrocontracts
    {
        [OperationContract]
        double EventHorizon(double BlackholeMass, int pow);
        [OperationContract]
        double StarDistance(double arcsecondsAngle);
        [OperationContract]
        double StarVelocity(double observedWavelength, double restWavelength);
        [OperationContract]
        double TempretureInKelvin(double celsius);
    }
}