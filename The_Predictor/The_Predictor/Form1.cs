using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace The_Predictor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.Volume = 100;  // 0...100
            synthesizer.Rate = 1;     // -10...10

            // Configure the audio output. 
            synthesizer.SetOutputToDefaultAudioDevice();


            // Synchronous
            synthesizer.SpeakAsync("Hello Chandy. My name is Jesus Christ. I am your new friend and I will help you to solve all your problems. Dont loose hope everything will be perfect.");

        }

    }
}

