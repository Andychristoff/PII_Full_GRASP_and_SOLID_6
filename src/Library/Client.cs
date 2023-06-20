using System;
using System.Threading;

namespace Full_GRASP_And_SOLID
{
    public class Client : TimerClient
    {
        Recipe client;

        public Client (Recipe client)
        {
            this.client=client;
        }
        public void TimeOut()
        {
          this.client.Cooked=true;
        }
    }  
}