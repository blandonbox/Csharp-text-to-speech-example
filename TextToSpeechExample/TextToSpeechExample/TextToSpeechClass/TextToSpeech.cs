using System;
using System.Speech.Synthesis;

namespace TextToSpeechExample.TextToSpeechClass
{
    public class TextToSpeech
    {
        SpeechSynthesizer tts;

        public TextToSpeech(int volume, int speechRate)
        {
            tts = new SpeechSynthesizer
            {
                Volume = volume,
                Rate = speechRate
            };
        }
        public TextToSpeech()
        {
            tts = new SpeechSynthesizer
            {
                Volume = 100,
                Rate = 1
            };
        }
        public void Speak(string text)
        {
            try
            {
                tts.SpeakAsync(text);
            }
            catch(Exception ex)
            {
                throw new Exception("Error: "+ex.Message);
            }
        }
    }
}
