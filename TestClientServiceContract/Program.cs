using System;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.ServiceModel;

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
    internal class Program
    {
        static void Main(string[] args)
        {
            bool runServer = true;
            while (runServer)
            {
                Console.WriteLine("Press <Ctrl + Shift + X> for exit");
                try
                {
                    NetNamedPipeBinding binding = new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
                    EndpointAddress endpoint = new EndpointAddress("net.pipe://localhost/astroMath");
                    IAstrocontracts popeProxy = ChannelFactory<IAstrocontracts>.CreateChannel(binding, endpoint);
                    if (popeProxy.StarDistance(0.547) != null)
                    {
                        Console.WriteLine("Client started");
                        Console.WriteLine();
                        Console.WriteLine("Star velocity: " + popeProxy.StarVelocity(501.0, 500.0) + " m/s");
                        Console.WriteLine("Star distance: " + popeProxy.StarDistance(0.547) + " parsec");
                        Console.WriteLine("Tempreture in Kelvin: " + popeProxy.TempretureInKelvin(27) + " K");
                        Console.WriteLine("Event Horizon: " + popeProxy.EventHorizon(8.2, 36) + " * 10^10 metres");
                        Console.WriteLine();

                        
                        runServer = RunServer();
                    }
                }
                catch (EndpointNotFoundException error)
                {
                    Console.WriteLine(error.Message);
                    runServer = RunServer();
                }
                catch (FaultException error)
                {
                    Console.WriteLine(error.Message);
                    runServer = RunServer();
                }
            }
            Environment.Exit(0);
        }
        static bool RunServer()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            return !(keyInfo.Modifiers.HasFlag(ConsoleModifiers.Control) &&
                            keyInfo.Modifiers.HasFlag(ConsoleModifiers.Shift) &&
                            keyInfo.Key == ConsoleKey.X);
        }
    }
}
