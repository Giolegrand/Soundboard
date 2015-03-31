using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Soundboard.Media;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Reflection;

namespace Soundboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            XmlSerializer xser = new XmlSerializer(typeof(Buttons));
            string[] test = this.GetType().Assembly.GetManifestResourceNames();
            Stream xmlstream = this.GetType().Assembly.GetManifestResourceStream("Soundboard.Resources.Buttons.xml");
            var buttons = (Buttons) xser.Deserialize(xmlstream);
            Console.WriteLine(buttons.knoppen.Count());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundManager sm = new SoundManager(Properties.Resources.TestSound);
            sm.playSound();
        }

    }
}
