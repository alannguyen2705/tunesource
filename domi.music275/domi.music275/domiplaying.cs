using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace domi.music275
{
    public partial class domiplaying : Form
    {
        public domiplaying()
        {
            InitializeComponent();
        }
        OpenFileDialog openFileDialog;
        string[] filePaths;
        string[] fileNames;

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Mp3 files, mp4 files (*.mp3, *.mp4)|*.mp*";
            openFileDialog.Multiselect = true;
            openFileDialog.Title = "Open";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePaths = openFileDialog.FileNames; //lay duong dan
                fileNames = openFileDialog.SafeFileNames; //lay ten file
                foreach (var item in fileNames)
                {
                    this.listBox_domi.Items.Add(item);
                }
            }
        }

        private void axWindowsMediaPlayer1_Enter_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox_domi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listBox_domi_DoubleClick(object sender, EventArgs e)
        {
            int choose = listBox_domi.SelectedIndex;
            axWindowsMediaPlayer1.URL = filePaths[choose];
            this.textBox_domi.Text = fileNames[choose];
        }

        private void button_domi(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
                this.Close();
        }
    }
}
