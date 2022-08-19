using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MDIParent1 : Form
    {
        WMPLib.WindowsMediaPlayer myplayer = new WMPLib.WindowsMediaPlayer();
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            // add the vedio 
            // WMPLib.WindowsMediaPlayer myplayer = new WMPLib.WindowsMediaPlayer();
            axWindowsMediaPlayer1.URL = "C:/Users/User/Desktop/SCHOOL PROJECT/WindowsFormsApplication1/WindowsFormsApplication1/bin/Debug/vedio/04.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // add the vedio 
            // WMPLib.WindowsMediaPlayer myplayer = new WMPLib.WindowsMediaPlayer();
            axWindowsMediaPlayer1.URL = "C:/Users/User/Desktop/SCHOOL PROJECT/WindowsFormsApplication1/WindowsFormsApplication1/bin/Debug/vedio/05.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // add the vedio 
            // WMPLib.WindowsMediaPlayer myplayer = new WMPLib.WindowsMediaPlayer();
            axWindowsMediaPlayer1.URL = "C:/Users/User/Desktop/SCHOOL PROJECT/WindowsFormsApplication1/WindowsFormsApplication1/bin/Debug/vedio/07.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // add the vedio 
            // WMPLib.WindowsMediaPlayer myplayer = new WMPLib.WindowsMediaPlayer();
            axWindowsMediaPlayer1.URL = "C:/Users/User/Desktop/SCHOOL PROJECT/WindowsFormsApplication1/WindowsFormsApplication1/bin/Debug/vedio/09.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // add the vedio 
            // WMPLib.WindowsMediaPlayer myplayer = new WMPLib.WindowsMediaPlayer();
            axWindowsMediaPlayer1.URL = "C:/Users/User/Desktop/SCHOOL PROJECT/WindowsFormsApplication1/WindowsFormsApplication1/bin/Debug/vedio/10.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // add the vedio 
             WMPLib.WindowsMediaPlayer myplayer = new WMPLib.WindowsMediaPlayer();
             axWindowsMediaPlayer1.URL = "C:/Users/User/Desktop/SCHOOL PROJECT/WindowsFormsApplication1/WindowsFormsApplication1/bin/Debug/vedio/01.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // add the vedio 
            // WMPLib.WindowsMediaPlayer myplayer = new WMPLib.WindowsMediaPlayer();
            axWindowsMediaPlayer1.URL = "C:/Users/User/Desktop/SCHOOL PROJECT/WindowsFormsApplication1/WindowsFormsApplication1/bin/Debug/vedio/02.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // add the vedio 
            // WMPLib.WindowsMediaPlayer myplayer = new WMPLib.WindowsMediaPlayer();
            axWindowsMediaPlayer1.URL = "C:/Users/User/Desktop/SCHOOL PROJECT/WindowsFormsApplication1/WindowsFormsApplication1/bin/Debug/vedio/03.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // add the vedio 
            // WMPLib.WindowsMediaPlayer myplayer = new WMPLib.WindowsMediaPlayer();
            axWindowsMediaPlayer1.URL = "C:/Users/User/Desktop/SCHOOL PROJECT/WindowsFormsApplication1/WindowsFormsApplication1/bin/Debug/vedio/06.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // add the vedio 
            // WMPLib.WindowsMediaPlayer myplayer = new WMPLib.WindowsMediaPlayer();
            axWindowsMediaPlayer1.URL = "C:/Users/User/Desktop/SCHOOL PROJECT/WindowsFormsApplication1/WindowsFormsApplication1/bin/Debug/vedio/08.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
    }
}
