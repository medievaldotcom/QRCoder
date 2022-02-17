using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRCoder
{
    public partial class Form1 : Form
    {
     
         
        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateQR(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss-tt");
            string backup = String.Format(@"C:\Users\Adrian\Downloads\");
            string filename = time + ".png";
            string message = "Qr Code will be saved to database.";
            string msgtitle = "QR Code Generated at " + time;
              QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode("Name: " + txtQRCodeName.Text + "\n" + "Date of Birth: " + txtQRCodeBirthdate.Text + "\n" + "Address: " + txtQRCodeAddress.Text + "\n" + "Phone Number: " + txtQRCodePhoneNumber.Text + "\n" + "Email Address: " + txtQRCodeEmailAddress.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            Bitmap bitMap = code.GetGraphic(5);

         

            using (MemoryStream ms = new MemoryStream())
            {
                bitMap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                pic.Image = bitMap;
                pic.Height = bitMap.Height;
                pic.Width = bitMap.Width;
            }

              
                bitMap.Save(filename, ImageFormat.Png);
                bitMap.Save(backup + filename, ImageFormat.Png);
                MessageBox.Show(message, msgtitle);
        }
    }
}
