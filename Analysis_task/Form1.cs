using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Analysis_task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateFile();
        }
        String path = "visualize/commands.txt";
        public void CreateFile()
        {
            FileStream Fs = new FileStream("commands.txt", FileMode.OpenOrCreate, FileAccess.Write);
            Fs.Close();
            Fs = new FileStream(path, FileMode.Truncate, FileAccess.Write);
            Fs.Close();
        }

        private void AddActivityButton_Click(object sender, EventArgs e)
        {
            FileStream Fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            StreamWriter Sr = new StreamWriter(Fs);
            String Name = ActivityName.Text;
            String Duration = ActivityDuration.Text;
            int d = 0;
            if(Name != "" && int.TryParse(Duration, out d))
            {
                Sr.WriteLine("1 " + Name + " " + Duration);
                ActivityName.Text = "";
                ActivityDuration.Text = "";
                System.Windows.Forms.MessageBox.Show("Added");
            }
            Sr.Close();
            Fs.Close();
        }

        private void AddDependencyButton_Click(object sender, EventArgs e)
        {
            FileStream Fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            StreamWriter Sr = new StreamWriter(Fs);
            String Act1 = Activity1.Text;
            String Act2 = Activity2.Text;
            if (Act1 != "" && Act2 != "")
            {
                Sr.WriteLine("2 " + Act1 + " " + Act2);
                Activity1.Text = "";
                Activity2.Text = "";
                System.Windows.Forms.MessageBox.Show("Added");
            }
            Sr.Close();
            Fs.Close();
        }
    }
}
