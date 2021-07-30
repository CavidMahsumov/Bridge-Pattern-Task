using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Compositor
{
  public  class TV:IDevice
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
            Console.WriteLine($"The television is Disabled");
        }

        public void Enable()
        {
            Console.WriteLine($"The television is Enabled");
        }

        public void GetChannel()
        {
            double channel = 10;

            Console.WriteLine($"The Channel {channel}");
        }

        public void SetChannel(double channel)
        {
            Console.WriteLine($" The Channel  {channel}");
        }

        public void GetVolume()
        {
            double percent = 10;

            Console.WriteLine($"The Volume {percent}");
        }


        public void SetVolume(double percent)
        {
            Console.WriteLine($"The Volume {percent}");
        }
    }
}
