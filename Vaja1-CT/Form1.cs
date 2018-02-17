using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Vaja1_CT
{
    public partial class Form1 : Form
    {
        public const int size = 512;
        Dictionary<int, string> code = new Dictionary<int, string>();

        string pathtmp, pathLTmp;
        short[,] slika_img = new short[size, size];
        byte[,] lut = new byte[256, 3];
        double lengthOriginal;
        string fileName;
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            code = setCode();

        }
        
        public void ToBitMapMy(short[,] image, ref Bitmap bitImage)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    byte rgb = (byte)(image[i, j]);

                    Color tmp = Color.FromArgb(255, rgb, rgb, rgb);
                    bitImage.SetPixel(i, j, tmp);
                }
            }
        }
        public void ToBitMapMyColor(byte[,] lut, short[,] image, ref Bitmap bitImage)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    byte rgb = (byte)(image[i, j]);


                    Color tmp = Color.FromArgb(255, lut[rgb, 0], lut[rgb, 1], lut[rgb, 2]);
                    bitImage.SetPixel(i, j, tmp);
                }
            }
        }

        private void bttLUT_Click(object sender, EventArgs e)
        {
            openFileDialog2.Multiselect = false;
            openFileDialog2.InitialDirectory = @"C:\Users\Bostjan\Documents\FERI\3.Letnik\Racunalnsika vecpredstavnost\Naloga1\Vaja1-CT\LUTS";
            openFileDialog2.RestoreDirectory = false;
            openFileDialog2.Filter = "LUT file (*.lut)|*.lut";

            if (openFileDialog2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pathLTmp = Path.GetDirectoryName(openFileDialog2.FileName);
                string[] fileEntries = Directory.GetFiles(pathLTmp);
                foreach (string fileName in fileEntries)
                    listView2.Items.Add(fileName);
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BinaryReader br;
            label1.Text = "tekst";
            if (listView1.SelectedItems.Count == 1)
            {
                bttStiskanje.Enabled = true;
                string item = listView1.SelectedItems[0].Text;
                lengthOriginal = new System.IO.FileInfo(item).Length;
                label1.Text = item;
                fileName = item.Substring(item.Length - 8, 4);
                try
                {
                    br = new BinaryReader(File.Open(item, FileMode.Open));

                    for (int i = 0; i < size; i++)
                    {
                        for (int j = 0; j < size; j++)
                        {
                            slika_img[i, j] = br.ReadInt16();

                        }
                    }
                    Bitmap bitmap = new Bitmap(size, size);
                    ToBitMapMy(slika_img, ref bitmap);
                    bitmap.RotateFlip(RotateFlipType.Rotate90FlipX);
                    pictureBox1.Image = bitmap;
                }
                catch
                {

                }

            }
           

        }

        private void bttCT_Click(object sender, EventArgs e)
        {
            label5.Text = "0";
            //C:\Users\Bostjan\Documents\FERI\3.Letnik\Racunalnsika vecpredstavnost\Naloga1\Vaja1-CT\CT

            openFileDialog1.Multiselect = false;
            openFileDialog1.InitialDirectory = @"C:\Users\Bostjan\Documents\FERI\3.Letnik\Racunalnsika vecpredstavnost\Naloga1\Vaja1-CT\CT";
            openFileDialog1.RestoreDirectory = false;
            openFileDialog1.Filter = "IMG file (*.img)|*.img";


            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pathtmp = Path.GetDirectoryName(openFileDialog1.FileName);
                string[] fileEntries = Directory.GetFiles(pathtmp);
                foreach (string fileName in fileEntries)
                    listView1.Items.Add(fileName);
            }
            
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private Dictionary<int, string> setCode()
        {
            Dictionary<int, string> code = new Dictionary<int, string>();

            // 2 BITA [-2,-1] && [1,2]
            code[-2] = "0000";
            code[-1] = "0001";
            code[1] = "0010";
            code[2] = "0011";

            // 3 BITI [-6,-3] && [3,6]
            code[-6] = "01000";
            code[-5] = "01001";
            code[-4] = "01010";
            code[-3] = "01011";
            code[6] = "01100";
            code[5] = "01101";
            code[4] = "01110";
            code[3] = "01111";

            // 4 BITI [-14,-7] && [7,14]
            code[-14] = "100000";
            code[-13] = "100001";
            code[-12] = "100010";
            code[-11] = "100011";
            code[-10] = "100100";
            code[-9] = "100101";
            code[-8] = "100110";
            code[-7] = "100111";
            code[14] = "101111";
            code[13] = "101110";
            code[12] = "101101";
            code[11] = "101100";
            code[10] = "101011";
            code[9] = "101010";
            code[8] = "101001";
            code[7] = "101000";

            // 5 BITOV [-30,-15] && [15,30]
            code[-30] = "1100000";
            code[-29] = "1100001";
            code[-28] = "1100010";
            code[-27] = "1100011";
            code[-26] = "1100100";
            code[-25] = "1100101";
            code[-24] = "1100110";
            code[-23] = "1100111";
            code[-22] = "1101000";
            code[-21] = "1101001";
            code[-20] = "1101010";
            code[-19] = "1101011";
            code[-18] = "1101100";
            code[-17] = "1101101";
            code[-16] = "1101110";
            code[-15] = "1101111";
            code[30] = "1111111";
            code[29] = "1111110";
            code[28] = "1111101";
            code[27] = "1111100";
            code[26] = "1111011";
            code[25] = "1111010";
            code[24] = "1111001";
            code[23] = "1111000";
            code[22] = "1110111";
            code[21] = "1110110";
            code[20] = "1110101";
            code[19] = "1110100";
            code[18] = "1110011";
            code[17] = "1110010";
            code[16] = "1110001";
            code[15] = "1110000";
            
            return code;
        }
        private string Stiskanje(short pixel, ref int count, ref short prevPixel)
        {
            StringBuilder myString = new StringBuilder();

            if(pixel != prevPixel && count != 0)
            {
                myString.Append("01" + Convert.ToString(count,2).PadLeft(6,'0'));
                count = 0;
            }
            if(pixel == 0 && pixel != prevPixel)
            {
                prevPixel = pixel;
                return myString.Append("11").ToString();
            }
            if(pixel == prevPixel)
            {
                count++;
                if(count != 63)
                {
                    return null;
                }
                else
                {
                    myString.Append("01" + Convert.ToString(count,2).PadLeft(6,'0'));
                    count = 0;
                    return myString.ToString();
                }


            }
            int razlika = pixel - prevPixel;
            if(razlika <= 30 && razlika >= -30 && razlika != 0)
            {
                prevPixel = pixel;
                return myString.Append("00" + code[razlika]).ToString();
            }

            prevPixel = pixel;
            return myString.Append("10" + Convert.ToString(pixel, 2).PadLeft(12, '0')).ToString();
        }

        private void bttStiskanje_Click(object sender, EventArgs e)
        {
            //Stiskanje
            StringBuilder myString = new StringBuilder();
            short prevPixel = short.MinValue;
            int count = 0;


            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {

                    myString.Append(Stiskanje((short)(slika_img[i, j] + 2048), ref count, ref prevPixel));
                   
                }
            }
            if(count > 0)
            {
                myString.Append("01");
                myString.Append(Convert.ToString(count, 2).PadLeft(6, '0'));
                count = 0;
            }
            

            List<bool> boolList = new List<bool>();
            for (int i = 0; i < myString.Length; i++)
            {
                if (myString[i].Equals('1'))
                {
                    boolList.Add(true);
                }
                else
                {
                    boolList.Add(false);
                }
            }

            BitArray bit = new BitArray(boolList.ToArray());
            byte[] byteFile = new byte[(int)Math.Ceiling((double)myString.Length / 8)];
            bit.CopyTo(byteFile, 0);
            File.WriteAllBytes(fileName + ".cmp", byteFile);
            
            double length = new System.IO.FileInfo(fileName + ".cmp").Length;

            double razmerje = lengthOriginal / length;

            label5.Text = razmerje.ToString("#.######");

        }
        private void txtBttDekod_Click(object sender, EventArgs e)
        {
            byte[] kodirano;
            pictureBox1.Image = null;

            // Dekoiranje
            OpenFileDialog of = new OpenFileDialog();
            of.Multiselect = false;
            of.InitialDirectory = @"C:\Users\Bostjan\Documents\FERI\3.Letnik\Racunalnsika vecpredstavnost\Naloga1\Vaja1-CT\Vaja1-CT\bin\Debug\";
            of.RestoreDirectory = false;
            of.Filter = "CMP file (*.cmp)|*.cmp";

            if (of.ShowDialog() == DialogResult.OK)
            {
                kodirano = File.ReadAllBytes(of.FileName);
            }
            else
            {
                return;
            }

            BitArray newBitArray = new BitArray(kodirano);

            StringBuilder result = new StringBuilder(string.Empty);
            for (int i = 0; i < newBitArray.Length; i++)
            {
                if (newBitArray[i])
                {
                    result.Append("1");
                }
                else
                {
                    result.Append("0");
                }
            }
            
            List<short> listShort = new List<short>();
            short[,] newPicture2 = new short[size, size];

            //int x = 0;
            int intBit = 0; 
            for (; listShort.Count < 262144; )
            {

                string tmp = result.ToString(intBit, 2);
                intBit += 2;
                if (tmp == "11")
                {
                    listShort.Add(-2048);
                    continue;
                }
                if (tmp == "10")
                {
                    tmp = result.ToString(intBit, 12);
                    intBit += 12;
                    listShort.Add(Convert.ToInt16(tmp, 2));
                    
                    continue;
                }
                if (tmp == "00")
                {
                    StringBuilder codeBit = new StringBuilder();
                    tmp = result.ToString(intBit, 2);
                    intBit += 2;
                    switch (tmp)
                    {
                        case "00":
                            codeBit.Append("00");
                            tmp = result.ToString(intBit, 2);
                            codeBit.Append(tmp);
                            intBit += 2;
                            break;
                        case "01":
                            codeBit.Append("01");
                            tmp = result.ToString(intBit, 3);
                            codeBit.Append(tmp);
                            intBit += 3;
                            break;
                        case "10":
                            codeBit.Append("10");
                            tmp = result.ToString(intBit, 4);
                            codeBit.Append(tmp);
                            intBit += 4;
                            break;
                        case "11":
                            codeBit.Append("11");
                            tmp = result.ToString(intBit, 5);
                            codeBit.Append(tmp);
                            intBit += 5;
                            break;
                    }
                    int[] keysByValue = code.Where(xx => xx.Value == codeBit.ToString()).Select(pair => pair.Key).ToArray();
                    listShort.Add((short)(listShort.Last() + keysByValue[0]));
                    continue;
                }
                if (tmp == "01")
                {
                    tmp = result.ToString(intBit, 6);
                    for (int k = 0; k < Convert.ToInt32(tmp, 2); k++)
                    {
                        listShort.Add(listShort.Last());
                    }
                    intBit += 6;
                }


            }
            int m = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    newPicture2[i, j] = (short)(listShort[m]);
                    m++;

                }
            }


            MessageBox.Show("Dekodiranje uspešno!");

            Bitmap bitmap = new Bitmap(size, size);
            ToBitMapMy(newPicture2, ref bitmap);
            bitmap.RotateFlip(RotateFlipType.Rotate90FlipX);
            pictureBox1.Image = bitmap;

        }

        private void bttStiskanjeVec_Click(object sender, EventArgs e)
        {
            //Stiskanje več slik


        }

        private void listView2_Click(object sender, EventArgs e)
        {
            BinaryReader br;
            //label1.Text = "tekst";
            if (listView2.SelectedItems.Count > 0)
            {
                string item = listView2.SelectedItems[0].Text;
                label1.Text = item;
                try
                {
                    br = new BinaryReader(File.Open(item, FileMode.Open));
                    // lut = null;
                    for (int i = 0; i < 256; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            lut[i, j] = br.ReadByte();

                        }
                    }
                    Bitmap bitmap = new Bitmap(size, size);

                    ToBitMapMyColor(lut, slika_img, ref bitmap);
                    bitmap.RotateFlip(RotateFlipType.Rotate90FlipX);

                    pictureBox1.Image = bitmap;
                }
                catch
                {

                }
            }
        }

    }
}

