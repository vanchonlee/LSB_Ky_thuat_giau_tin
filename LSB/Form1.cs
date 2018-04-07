using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string pSelectImage;
        private void btnImageInput_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            pSelectImage = this.openFileDialog1.FileName;
            this.imageImput.Image = Image.FromFile(pSelectImage);
            imageImput.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private byte insertBit(byte input, byte x)
        {
            byte temp = input;
            int r = (int)input;
            if (x == 0x00 && ((byte)temp & 0x01) == 0x01)
            {
                r = (int)temp - 1;
            }
            else if (x == 0x01 && ((byte)temp & 0x01) == 0x00)
            {
                r = (int)temp + 1;
            }
            return (byte)r;
        }

        private void btnLSB_Click(object sender, EventArgs e)
        {
            Bitmap bitmapImage = new Bitmap(pSelectImage);
            List<byte> listByteBitmap = new List<byte>();
            string txt = this.txtInput.Text;
            List<char> arrchar = txt.ToCharArray().ToList();
            listByteBitmap = getArrByteBitMap(bitmapImage);
            arrchar.Add('|');

            //chen
            int dem = 0;
            for(int i = 0; i < listByteBitmap.Count; i=i+8)
            {
                if (dem < arrchar.Count)
                {
                    char cTemp = arrchar[dem++];
                    listByteBitmap[i+0] = insertBit(listByteBitmap[i+0], (byte)((cTemp >> 7) & 0x01));//0
                    listByteBitmap[i+1] = insertBit(listByteBitmap[i+1], (byte)((cTemp >> 6) & 0x01));//1
                    listByteBitmap[i+2] = insertBit(listByteBitmap[i+2], (byte)((cTemp >> 5) & 0x01));//2
                    listByteBitmap[i+3] = insertBit(listByteBitmap[i+3], (byte)((cTemp >> 4) & 0x01));//3
                    listByteBitmap[i+4] = insertBit(listByteBitmap[i+4], (byte)((cTemp >> 3) & 0x01));//4
                    listByteBitmap[i+5] = insertBit(listByteBitmap[i+5], (byte)((cTemp >> 2) & 0x01));//5
                    listByteBitmap[i+6] = insertBit(listByteBitmap[i+6], (byte)((cTemp >> 1) & 0x01));//6
                    listByteBitmap[i+7] = insertBit(listByteBitmap[i+7], (byte)((cTemp >> 0) & 0x01));//7
                }
                else
                {
                    break;
                }
                
            }
            

            Bitmap bitNew = new Bitmap(bitmapImage.Width, bitmapImage.Height);
            int dem1 = 0;
            for(int i = 0; i < bitNew.Height; i++)
            {
                for(int j = 0; j < bitNew.Width; j++)
                {
                    Color colorTem = new Color();
                    byte r = listByteBitmap[dem1++];
                    byte g = listByteBitmap[dem1++];
                    byte b = listByteBitmap[dem1++];
                    colorTem = Color.FromArgb(r, g, b);
                    bitNew.SetPixel(j, i, colorTem);
                }
            }
            this.imageOutput.Image = (Image)bitNew;
            imageOutput.SizeMode = PictureBoxSizeMode.StretchImage;

            //save file
            
        }

        private List<byte> getArrByteBitMap(Bitmap bitmapImage)
        {
            List<byte> listByteBitmap = new List<byte>();
            for (int height = 0; height < bitmapImage.Height; height++)
            {
                for (int width = 0; width < bitmapImage.Width; width++)
                {
                    Color color_xy = new Color();
                    color_xy = bitmapImage.GetPixel(width, height);
                    byte g = color_xy.G;
                    byte r = color_xy.R;
                    byte b = color_xy.B;
                    listByteBitmap.Add(r);
                    listByteBitmap.Add(g);
                    listByteBitmap.Add(b);
                }
            }
            return listByteBitmap;
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            List<byte> listByteBitmap = new List<byte>();
            Bitmap bitmapImage = new Bitmap(this.imageOutput.Image);
            listByteBitmap = getArrByteBitMap(bitmapImage);
            List<char> arrchar = new List<char>();
            int i = 0;
            byte cTemp = 0x00;
            while (cTemp!='|')
            {
                cTemp = 0x00;
                for(int j = 0; j < 8; j++)
                {
                    cTemp = (byte)(cTemp + (byte)(listByteBitmap[i + j] & 0x01));//lay bit thu 0
                    if (j < 7)
                    {
                        cTemp = (byte)(cTemp << 1);
                    }
                }
                
                arrchar.Add((char)cTemp);
                
                i = i+8;
            }
            arrchar.Remove('|');
            this.lblKq.Text = string.Join("", arrchar);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = this.saveFileDialog1;
            sfd.Filter = "Images|*.png;*.bmp;*.jpg";
            ImageFormat format = ImageFormat.Png;
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(sfd.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }
                this.imageOutput.Image.Save(sfd.FileName, format);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            pSelectImage = this.openFileDialog1.FileName;
            this.imageOutput.Image = Image.FromFile(pSelectImage);
            imageOutput.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
