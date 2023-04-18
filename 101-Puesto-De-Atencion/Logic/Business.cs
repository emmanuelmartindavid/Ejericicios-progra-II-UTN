using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Business
    {
        private ServiceDesk _box;
        private Queue<Client> _clients;
        private string _name;

        private Business()
        {
            _box = new ServiceDesk(ServiceDesk.Service.Box1);
            _clients = new Queue<Client>();
        }

        public Business(string name) : this()
        {
            _name = name;
        }

        public Client Client
        {
            get
            {
                return _clients.Dequeue();
            }
            set { _ = this + value; }
        }

   
        public static bool operator ==(Business business, Client client)
        {
            foreach (Client item in business._clients)
            {
                if (item == client)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Business business, Client client)
        {
            return !(business == client);
        }

        public static bool operator +(Business business, Client newClient)
        {
            if (business != newClient)
            {
                business._clients.Enqueue(newClient);
                return true;
            }
            return false;
        }


        public static bool operator ~(Business business)
        {
            if (business._clients.Count > 0)
            {
                return business._box.ServeClient(business.Client);

            }

            return false;
        }

        public int PendientClients
        {
            get => _clients.Count;
        }
    }
}
