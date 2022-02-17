using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using MessagingToolkit.QRCode.Codec.Data;

namespace QRCoder
{
    public partial class Form1 : Form
    {
<<<<<<< HEAD


=======
     
         
>>>>>>> 4fcd0781e07fb647e947bebd50a52415dba457b4
        public Form1()
        {
            InitializeComponent();
        }


        private void GenerateQR(object sender, EventArgs e)
        {
<<<<<<< HEAD
            string time = DateTime.Now.ToString("hh-mm-ss-tt");
            string date = DateTime.Now.ToString("yyyy-MM-d ");
            string filename = txtQRCodeName.Text + " " + "Date " + date + "Time " + time + ".png";
            string message = "Qr Code will be saved to database as image.";
            string msgtitle = "QR saved date" + date + "saved at " + time;




            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode("Name: " + txtQRCodeName.Text + "\n" + "Date of Birth: " + txtQRCodeBirthdate.Text + "\n" + "Address: " + txtQRCodeAddress.Text + "\n" + "Phone Number: " + txtQRCodePhoneNumber.Text + "\n" + "Email Address: " + txtQRCodeEmailAddress.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            Bitmap bitMap = code.GetGraphic(5);
=======
            string time = DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss-tt");
            string backup = String.Format(@"C:\Users\Adrian\Downloads\");
            string filename = time + ".png";
            string message = "Qr Code will be saved to database.";
            string msgtitle = "QR Code Generated at " + time;
              QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode("Name: " + txtQRCodeName.Text + "\n" + "Date of Birth: " + txtQRCodeBirthdate.Text + "\n" + "Address: " + txtQRCodeAddress.Text + "\n" + "Phone Number: " + txtQRCodePhoneNumber.Text + "\n" + "Email Address: " + txtQRCodeEmailAddress.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            Bitmap bitMap = code.GetGraphic(5);

         

>>>>>>> 4fcd0781e07fb647e947bebd50a52415dba457b4
            using (MemoryStream ms = new MemoryStream())
            {
                bitMap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                pic.Image = bitMap;
                pic.Height = bitMap.Height;
                pic.Width = bitMap.Width;
            }
<<<<<<< HEAD
            bitMap.Save(@"C:\Users\Adrian\Documents\GitHub\QRCoder\Database\QrCodes\ " + filename, ImageFormat.Png);
            MessageBox.Show(message, msgtitle);

        }


        ///====================================QR Generator End============================================================================///
        ///
        ///====================================QR scanner ============================================================================///
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        QRCodeGenerator qr = new QRCodeGenerator();


        private void Form1_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in filterInfoCollection)
                choosedevice.Items.Add(Device.Name);
            choosedevice.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[choosedevice.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += FinalFrame_NewFrame;
            videoCaptureDevice.Start();
            timer1.Start();
        }
        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox.Image = (Bitmap)eventArgs.Frame.Clone();
=======

              
                bitMap.Save(filename, ImageFormat.Png);
                bitMap.Save(backup + filename, ImageFormat.Png);
                MessageBox.Show(message, msgtitle);
>>>>>>> 4fcd0781e07fb647e947bebd50a52415dba457b4
        }
        private void timer1_Tick(object sender, EventArgs e)
        {


            string time = DateTime.Now.ToString("hh-mm-ss-tt");
            string date = DateTime.Now.ToString("yyyy-MM-d ");
            string filename = txtQRCodeName.Text + " " + "Date " + date + "Time " + time + ".txt";
            string message = "Qr Code will be saved to database as text.";
            string msgtitle = "QR saved date" + date + "saved at " + time;

            BarcodeReader Reader = new BarcodeReader();
            Result result = Reader.Decode((Bitmap)pictureBox.Image);
            if (result != null)
            {

                QRtext.Text = result.ToString();
                System.IO.File.WriteAllText(@"C:\Users\Adrian\Documents\GitHub\QRCoder\Database\QrCodeTextFiles\ " + filename, QRtext.Text);
                MessageBox.Show(message, msgtitle);
            }

        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (videoCaptureDevice != null)
                videoCaptureDevice.Stop();
        }
  

        ///====================================QR Scanner End============================================================================///
        ///==================================Upload QR if no Webcam Present==================================///
        private void uploadQR(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("hh-mm-ss-tt");
            string date = DateTime.Now.ToString("yyyy-MM-d ");
            string filename = txtQRCodeName.Text + " " +"Date "+ date + "Time "+ time + ".txt";
            string message = "Qr Code will be saved to database as text.";
            string msgtitle = "QR saved date" +date+ "saved at " + time;
         

            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "PNG|*.png", ValidateNames = true, Multiselect = false })
            {
             


                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    //Decode qrcode from image
                    pic.Image = Image.FromFile(ofd.FileName);
                    MessagingToolkit.QRCode.Codec.QRCodeDecoder decoder = new MessagingToolkit.QRCode.Codec.QRCodeDecoder();
                    QRtext.Text = decoder.Decode(new QRCodeBitmapImage(pic.Image as Bitmap));
                    System.IO.File.WriteAllText(@"C:\Users\Adrian\Documents\GitHub\QRCoder\Database\QrCodeTextFiles\ " + filename, QRtext.Text);
                    MessageBox.Show(message, msgtitle);
                }

              
            }

        }

      
    }
}