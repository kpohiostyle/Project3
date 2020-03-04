using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MTWSound
{
    class MonkeyTapWithSoundPage : MonkeyTap.MonkeyTapPage
    {
        const int errorDuration = 500;

        // Diminished 7th in 1st inversion: C, Eb, F#, A
        double[] frequencies = { 523.25, 622.25, 739.99, 880 };
        double endFrequency = 65.4;

        List<byte[]> buffers;
        byte[] endBuffer;

        protected override void FlashBoxView(int index)
        {
            SoundPlayer.PlaySound(frequencies[index], flashDuration);
            base.FlashBoxView(index);
        }

        protected override void EndGame()
        {
            SoundPlayer.PlaySound(65.4, errorDuration);
            base.EndGame();
        }
    }

}