using System.ServiceModel;
/*
 * 
 * author: Marina Sichova
 * student Id: P272494
 * created: 03/04/2023
 * last updated: 24/04/2023
 * 
 * Test Application to check connection with Server Application
 * 
 */
namespace ServiceContract
{
    [ServiceContract]
    internal interface IAstrocontracts
    {
        [OperationContract]
        double StarVelocity(double observedWavelength, double restWavelength);
        
        [OperationContract]
        double StarDistance(double arcsecondsAngle);
        
        [OperationContract]
        double TempretureInKelvin(double celsius);

        [OperationContract]
        double EventHorizon(double BlackholeMass, int pow);


    }
}
