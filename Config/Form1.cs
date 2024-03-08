using System.Text;
namespace Config
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
            string path = Application.StartupPath + @"ref\config.ini";
            string datatext = System.IO.File.ReadAllText(path, Encoding.GetEncoding("GB2312"));
            data = datatext.Split(Environment.NewLine.ToCharArray());
            data = data.Where(s => !string.IsNullOrEmpty(s)).ToArray();
            comboBox1.SelectedIndex = (int)((float.Parse(data[1].Split("=")[1]) - 1) / 0.25);
            comboBox2.SelectedIndex = int.Parse(data[2].Split("=")[1]);
            trackBar1.Value = int.Parse(data[3].Split("=")[1]) / 10;
            trackBar2.Value = int.Parse(data[4].Split("=")[1]) / 10;
            checkBox1.Checked = int.Parse(data[5].Split("=")[1]) != 0;
            checkBox2.Checked = int.Parse(data[6].Split("=")[1]) != 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string savedata = "";
            savedata = savedata + "[config]\n";
            savedata = savedata + "resolutionRatio=" + (comboBox1.SelectedIndex * 0.25 + 1).ToString() + "\n";
            savedata = savedata + "frameRate=" + comboBox2.SelectedIndex.ToString() + "\n";
            savedata = savedata + "BGMVolume=" + (trackBar1.Value * 10).ToString() + "\n";
            savedata = savedata + "SEVolume=" + (trackBar2.Value * 10).ToString() + "\n";
            savedata = savedata + "verticalSync=" + (checkBox1.Checked ? "1" : "0") + "\n";
            savedata = savedata + "smooth=" + (checkBox2.Checked ? "1" : "0") + "\n";
            System.IO.File.WriteAllText(Application.StartupPath + @"ref\config.ini", savedata, Encoding.GetEncoding("GB2312"));
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