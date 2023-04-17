using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class ClientQueue
    {
        Queue<string> clientQueue = new();
        public Queue<string> LoadClientQueue(string client)
        {
            clientQueue.Enqueue(client.ToUpper());
            return clientQueue;
        }

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine($"CLIENTE AGREGADO: {clientQueue.Last()}");
            return sb.ToString();
        }
    }
}
