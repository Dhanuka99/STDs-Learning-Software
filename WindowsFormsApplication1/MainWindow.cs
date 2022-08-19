using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainWindow : Form
    {
        private int childFormNumber = 0;

        WMPLib.WindowsMediaPlayer myplayer = new WMPLib.WindowsMediaPlayer();
        public MainWindow()
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

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            String curdir = Directory.GetCurrentDirectory();
            this.webBrowser1.Url = new Uri(String.Format("file:///{0}/vedio/ලිංගික ඉන්නන්.htm", curdir));
            
            
            
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            String curdir = Directory.GetCurrentDirectory();
            this.webBrowser1.Url = new Uri(String.Format("file:///{0}/vedio/CANDIDAISIS.htm", curdir));
           
        }

        private void button13_Click(object sender, EventArgs e)
        {
            String curdir = Directory.GetCurrentDirectory();
            this.webBrowser1.Url = new Uri(String.Format("file:///{0}/vedio/anthar.htm", curdir));
            //add the recording
            myplayer.URL = "sound/Shukra thanpathu.m4a";
            myplayer.controls.play();
        }

        private void button12_Click(object sender, EventArgs e)
        {
         string curdir = Directory.GetCurrentDirectory();
         this.webBrowser1.Url = new Uri(String.Format("file:///{0}/vedio/danuka.htm", curdir));
         
        }

        private void button11_Click(object sender, EventArgs e)
        {
            String curdir = Directory.GetCurrentDirectory();
            this.webBrowser1.Url = new Uri(String.Format("file:///{0}/vedio/අනාරක්ෂිත ලිංගික සබදතාවක් යනු.htm", curdir));
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            String curdir = Directory.GetCurrentDirectory();
            this.webBrowser1.Url = new Uri(String.Format("file:///{0}/vedio/GRANULEMA INGUINALE.htm", curdir));
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            String curdir = Directory.GetCurrentDirectory();
            this.webBrowser1.Url = new Uri(String.Format("file:///{0}/vedio/wadabawy.htm", curdir));
            //add the recording
            myplayer.URL = "sound/Wanda bawaya.m4a";
            myplayer.controls.play();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            String curdir = Directory.GetCurrentDirectory();
            this.webBrowser1.Url = new Uri(String.Format("file:///{0}/vedio/TRICOMONAS VAGINALIS.htm", curdir));
       
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String curdir = Directory.GetCurrentDirectory();
            this.webBrowser1.Url = new Uri(String.Format("file:///{0}/vedio/fi.htm", curdir));
            //add the recording
            myplayer.URL = "sound/Fibroids.m4a";
            myplayer.controls.play();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            String curdir = Directory.GetCurrentDirectory();
            this.webBrowser1.Url = new Uri(String.Format("file:///{0}/vedio/AIDS.htm", curdir));
            //add the recording
            myplayer.URL = "sound/Hiv.m4a";
            myplayer.controls.play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //String curdir = Directory.GetCurrentDirectory();
            //this.webBrowser1.Url = new Uri(String.Format("", curdir));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String curdir = Directory.GetCurrentDirectory();
            this.webBrowser1.Url = new Uri(String.Format("file:///{0}/vedio/Untitled-1.html", curdir));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String curdir = Directory.GetCurrentDirectory();
            this.webBrowser1.Url = new Uri(String.Format("file:///{0}/vedio/sypls.htm", curdir));
            //add the recording
            myplayer.URL = "sound/Syphilis.m4a";
            myplayer.controls.play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String curdir = Directory.GetCurrentDirectory();
            this.webBrowser1.Url = new Uri(String.Format("file:///{0}/vedio/goneria.htm", curdir));
            myplayer.URL = "sound/Gonoriya.m4a";
            myplayer.controls.play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String curdir = Directory.GetCurrentDirectory();
            this.webBrowser1.Url = new Uri(String.Format("file:///{0}/vedio/aramuna.htm", curdir));
          //add the recording
            myplayer.URL =  "sound/Voice 001.m4a";
           myplayer.controls.play();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            new MDIParent1().Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button17_Click(object sender, EventArgs e)
        {
            myplayer.controls.stop();
            this.Hide();
            new Form1().Show();
        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
        }

     
        

        
    }

