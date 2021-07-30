using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Compositor
{
    public interface IDevice
    {
        void IsEnabled(bool isenable);
        void Enable();
        void Disable();
        void GetVolume();
        void SetVolume(double percent);
        void GetChannel();
        void SetChannel(double channel);

    }
}
