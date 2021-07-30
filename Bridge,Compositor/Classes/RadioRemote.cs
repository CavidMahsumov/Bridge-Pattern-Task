using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Compositor
{
    class RadioRemote:IRemote
    {
        public IDevice Device { get; set; }

        double Volume = 100;
        double channel = 10;
        public RadioRemote(IDevice _device)
        {
            Device = _device;
        }

        public void Power(bool IsEnable)
        {
            Device.IsEnabled(IsEnable);
        }

        public void VolumeDown()
        {
            Device.SetVolume(Volume);
            Volume--;
        }

        public void VolumeUP()
        {
            Device.SetVolume(Volume);
            Volume++;
        }

        public void ChannelDown()
        {
            channel--;
            Device.SetVolume(channel);
        }

        public void ChannelUp()
        {
            channel++;
            Device.SetVolume(channel);
        }

        public void Mute(bool IsMute)
        {

            Console.WriteLine($"Mute of Radio is {IsMute}");

        }
    }
}
