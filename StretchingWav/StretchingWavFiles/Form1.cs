using System;
using System.Windows.Forms;

namespace KursRvyanin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// For stretching
        /// </summary>
        private int SampFreq;
        private string _srcWavName;
        private string _dstWavName;
        private double[] _srcWav;
        private double[] _dstWav;

        /// <summary>
        /// Player for playing WAV
        /// </summary>
        System.Media.SoundPlayer player =
                new System.Media.SoundPlayer();

        bool flag = true;

        private void Btn_OpenWav_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Wav_Files | *.wav";
            openFileDialog.Title = "Select a WAV File";

            // Show the Dialog.
            // If the user clicked OK in the dialog and
            // a .CUR file was selected, open it.
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Assign the cursor in the Stream to the Form's Cursor property.
                _srcWavName = openFileDialog.FileName;
                _srcWav = ReadAndWriteWavFiles.ReadMono(_srcWavName, out SampFreq);
                button1.Enabled = true;
                Btn_Stretch.Enabled = true;
                RatioBar.Enabled = true;
            }
            
        }

        private void Btn_Stretch_Click(object sender, EventArgs e)
        {
            if (RatioBar != null)
            {
                double ratio = RatioBar.Value;
                ratio = ratio*0.1;
                _dstWav = StretchingWav.Stretch(_srcWav, ratio, 1024, 256, 4);
                
                MessageBox.Show("Операция завершена");
            }
            Btn_Stretch.Enabled = false;
            Btn_Save.Enabled = true;
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "wav files (*.wav)|*.wav|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _dstWavName = saveFileDialog1.FileName;
                ReadAndWriteWavFiles.Write(_dstWavName, _dstWav, SampFreq);
                button2.Enabled = true;
            }
        }

        private void RatioBar_Scroll(object sender, EventArgs e)
        {
            Btn_Stretch.Enabled = true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            playSound(_srcWavName);
        }
        private void playSound(string path)
        {
            if (flag == true)
            {
                player.SoundLocation = path;
                player.Load();
                player.Play();
                flag = false;
            }
            else
            {
                player.Stop();
                flag = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            playSound(_dstWavName);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            player.Stop();
            flag = true;
        }
    }
}
