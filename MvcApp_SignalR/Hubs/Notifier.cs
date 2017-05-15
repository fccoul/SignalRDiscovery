using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcApp_SignalR.Hubs
{
    public class Notifier : Hub
    {
        //En définissant cette méthode, nous indiquons à « SignalR » que cette méthode pourra être invoquée par le client
        public void NotifyAllUsers(Notification message)
        {
            //---Notifications à tous les clients connectés
            //---La méthode Broadcast va invoquer à partir du serveur la fonction du même nom côté client avec le paramètre message.
            //Clients.All.Broadcast(message);
            Clients.Others.Broadcast(message);//---le detail de lamethode'broadcast' sera definicote JS-->page Client
            
        }
    }
}
