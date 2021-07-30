using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Compositor
{
    class TVRemote:IRemote
    {
        public IDevice Device { get; set; }

        double percent = 100;
        double channel = 1;
        public TVRemote(IDevice _device)
        {
            Device = _device;
        }

        public void Power(bool IsEnable)
        {

            Device.IsEnabled(IsEnable);
        }

        public void VolumeDown()
        {
            percent--;
            Device.SetVolume(percent);
        }

        public void VolumeUP()
        {
            percent++;
            Device.SetVolume(percent);
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
            Console.WriteLine($"Mute Television is {IsMute}");

        }
    }
}
