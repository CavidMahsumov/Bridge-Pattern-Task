using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Compositor
{

    class Program
    {

        static void Main(string[] args)
        {
            IRemote RadioRemote = new RadioRemote(new Radio());

            bool RadioisEnabled = false;

            bool RadioIsMute = true;

            RadioRemote.Mute(RadioIsMute);
            RadioRemote.VolumeUP();
            RadioRemote.VolumeDown();
            RadioRemote.Power(RadioisEnabled);
            RadioRemote.ChannelDown();
            RadioRemote.ChannelUp();


            IRemote TvRemote = new TVRemote(new TV());

            bool TvIsEnabled = true;
            bool TvIsMute = false;

            TvRemote.Power(TvIsEnabled);
            TvRemote.Mute(TvIsMute);
            TvRemote.VolumeDown();
            TvRemote.VolumeUP();
            TvRemote.ChannelDown();
            TvRemote.ChannelUp();
        }
    }
}
