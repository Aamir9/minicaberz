using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace thechauffeurteam.singnalr.hubs
{

   
    public class jobBookingHub : Hub
    {
        [HubMethodName("NotifyClients")]
        public static void NotifyCurrentJobInformationToAllClients()
        {
            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<jobBookingHub>();

            // the update client method will update the connected client about any recent changes in the server data
            context.Clients.All.updatedClients();  // updatedClients  a javascript method 
        }

    }
}