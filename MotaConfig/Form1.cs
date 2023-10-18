using System.Text;
namespace MotaConfig
{
    public partial class Form1 : Form
    {
        string[] data;
        public Form1()
        {
            data = new string[22];
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            string path = Application.StartupPath + @"Config.ini";
            string datatext = System.IO.File.ReadAllText(path, Encoding.GetEncoding("GB2312"));
            data = datatext.Split(Environment.NewLine.ToCharArray());
            data = data.Where(s => !string.IsNullOrEmpty(s)).ToArray();
            comboBox1.SelectedIndex = (int)((float.Parse(data[1].Split("=")[1]) - 1) / 0.25);
            comboBox2.SelectedIndex = (int.Parse(data[2].Split("=")[1]) - 16) / 8;
            trackBar1.Value = int.Parse(data[3].Split("=")[1]) / 10;
            trackBar2.Value = int.Parse(data[4].Split("=")[1]) / 10;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Config.ini", false, Encoding.GetEncoding("GB2312"));
            sw.WriteLine("[config]");
            sw.WriteLine("resolutionRatio=" + (comboBox1.SelectedIndex * 0.25 + 1).ToString());
            sw.WriteLine("frameRate=" + (comboBox2.SelectedIndex * 8 + 16).ToString());
            sw.WriteLine("BGMVolume=" + (trackBar1.Value * 10).ToString());
            sw.WriteLine("SEVolume=" + (trackBar2.Value * 10).ToString());
            sw.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

    }
}