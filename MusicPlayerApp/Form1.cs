using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayerApp
{
    public partial class musicPlayer : Form
    {
        bool nextURL = false;
        public musicPlayer()
        {
            InitializeComponent();
        }

        //variaveis em array com título e caminho dos arquivos
        String[] paths, files;

        private void btnSelect_Click(object sender, EventArgs e)
        {
            //selecionar música
            OpenFileDialog fd = new OpenFileDialog();
            //selecionar mais de um arquivo
            fd.Multiselect = true;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                files = fd.SafeFileNames; //salva nome
                paths = fd.FileNames; //salva caminho
                //mostrar na listbox
                for (int i =0; i<files.Length; i++)
                {
                    listBoxMusic.Items.Add(files[i]);
                }
            }
        }

        private void listBoxMusic_SelectedIndexChanged(object sender, EventArgs e)
        {
            MediaPlayer.URL = paths[listBoxMusic.SelectedIndex];
        }

        private void MediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 1)
            {
                nextURL = true;
            }
        }

        private void musicPlayer_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //função de fechar
            this.Close();
        }

        
    }
}
