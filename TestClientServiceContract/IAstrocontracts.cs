using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * author: Marina Sichova
 * student Id: P272494
 * created: 30/04/2023
 * 
 * Test Client Side Application to check connection with Server Application
 * 
 */
namespace TestClientServiceContract
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
