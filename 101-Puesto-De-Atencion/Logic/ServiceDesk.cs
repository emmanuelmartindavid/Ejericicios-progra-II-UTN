using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
 
    public class ServiceDesk
    {
        public enum Service
        {
            Box1,
            Box2,
        }

        private int _actualNumber;
        private Service _service;

        public int ActualNumber
        {
            get => ++_actualNumber;
        }

        private ServiceDesk()
        {
            _actualNumber = 0;
        }

        public ServiceDesk(Service service) : this()
        {
            _service = service;
        }

        public bool ServeClient(Client client)
        {
            Random random = new Random();
            int time = random.Next(1000, 5000);

            if(client is not null)
            {
                Thread.Sleep(time);
                return true;

            }
            return false;
        }



    }
}
