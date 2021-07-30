using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Compositor
{
    public class Radio : IDevice
    {
        public void IsEnabled(bool IsEnable)
        {
            if (IsEnable == true)
            {
                Enable();
            }

            else
            {
                Disable();
            }


        }
        public void Disable()
        {
            Console.WriteLine($" Radio is Disabled");
        }

        public void Enable()
        {
            Console.WriteLine($" Radio is Enabled");
        }

        public void GetChannel()
        {
            double channel = 10;

            Console.WriteLine($" Channel :{channel}");
        }

        public void SetChannel(double channel)
        {
            Console.WriteLine($" Channel :{channel}");
        }

        public void GetVolume()
        {
            double percent = 10;

            Console.WriteLine($" Volume :{percent}");
        }


        public void SetVolume(double percent)
        {
            Console.WriteLine($" Volume  :{percent}");
        }
    }
}
