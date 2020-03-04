using System;
using System.Collections.Generic;
using System.Text;

namespace MTWSound
{
    public interface IPlatformSoundPlayer
    {
        void PlaySound(int samplingRate, byte[] pcmData);
    }
}
