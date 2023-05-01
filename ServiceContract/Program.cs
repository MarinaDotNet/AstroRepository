using System;
using System.Reflection;
using System.ServiceModel;
/*
 * 
 * author: Marina Sichova
 * student Id: P272494
 * created: 03/04/2023
 * last updated: 24/04/2023
 * 
 * Server Application
 * Connection file, provides the connection
 */
namespace ServiceContract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string address = "net.pipe://localhost/astroMath/";
            try
            {
                ServiceHost host = new ServiceHost(typeof(AstroServer));
                host.AddServiceEndpoint(typeof(IAstrocontracts), new NetNamedPipeBinding(NetNamedPipeSecurityMode.None), address);
                host.Open();
                bool runServer = true;
                Console.WriteLine("Service is Available. Press <Ctrl + Shift + X> for exit");

                //The server application could be closed on special combination key:
                //<Ctrl + Shift + X>
                while (runServer)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    if(keyInfo.Modifiers.HasFlag(ConsoleModifiers.Control) && 
                        keyInfo.Modifiers.HasFlag(ConsoleModifiers.Shift) && 
                        keyInfo.Key == ConsoleKey.X)
                    {
                        runServer = false;
                        host.Close();
                    }
                }

            }catch(TimeoutException error)
            {
                Console.WriteLine(error.Message);
                Console.ReadLine();
            }
            catch(CommunicationException error)
            {
                Console.WriteLine(error.Message);
                Console.ReadLine();
            }
            catch (TargetInvocationException error)
            {
                Console.WriteLine(error.Message);
                Console.ReadLine();
            }

        }
    }
}
