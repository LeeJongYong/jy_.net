﻿using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevSignalR.Hubs
{
    [HubName("chat")]
    public class ChatHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }
        public void ClientToServer(string msg)
        {
            Clients.All.serverToClient(msg);
        }
    }
}