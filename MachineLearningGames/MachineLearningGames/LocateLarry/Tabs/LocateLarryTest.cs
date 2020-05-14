using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MachineLearningGames.LocateLarry.Class;
using System.IO;

namespace MachineLearningGames.LocateLarry.Tabs
{
    public partial class LocateLarryTest : UserControl
    {
        public LocateLarryTest()
        {
            InitializeComponent();
            lblTahmin.Visible = false;
            lblTahminBox.Visible = false;
            listView1.Visible = false;
            btnForecastLarry.Visible = false;
            
            LtPicBox1.Visible = false;
            LtPicBox3.Visible = false;
            LtPicBox5.Visible = false;
            LtPicBox2.Visible = false;
            LtPicBox4.Visible = false;
            btnAnimalUpload3.Visible = false;
            btnAnimalUpload5.Visible = false;
            btnAnimalUpload2.Visible = false;
            btnAnimalUpload4.Visible = false;
        }

        LtSingleton db = LtSingleton.SingleInstance();

        ImageList myImageList = new ImageList();
        int count = 0;
        public string ImageNewName = "";
        OpenFileDialog Lto = new OpenFileDialog()
        {
            Multiselect = true,
            ValidateNames = true,
            Filter =
         "JPG|*jpg|JPEG|*.jpeg|PNG|*.png"
        };
        
        FileInfo fi;

        public void Update(ListView listView)
        {
            myImageList.ImageSize = new Size(60, 90);
            if (Lto.ShowDialog() == DialogResult.OK)
            {
                listView.Items.Clear();
                foreach (string fileName in Lto.FileNames)
                {
                    fi = new FileInfo(fileName);
                    FileInfo fileinfo = new FileInfo(fileName);
                    using (FileStream stream = new FileStream(fi.FullName, FileMode.Open, FileAccess.Read))
                    {
                        myImageList.Images.Add(Image.FromStream(stream));
                    }
                    listView.LargeImageList = myImageList;

                    listView.Items.Add(new ListViewItem
                    {
                        ImageIndex = count,
                        Text = fi.Name,
                        Tag = fi.FullName
                    });
                    count++;
                }
            }
        }

        private void btnAnimalUpload1_Click(object sender, EventArgs e)
        {
            Lto.ShowDialog();
            LtPicBox1.ImageLocation = Lto.FileName;
            btnAnimalUpload1.Visible = false;
            LtPicBox1.Visible = true;
            btnAnimalUpload2.Visible = true;
        }

        private void btnAnimalUpload2_Click(object sender, EventArgs e)
        {
            Lto.ShowDialog();
            LtPicBox2.ImageLocation = Lto.FileName;
            btnAnimalUpload2.Visible = false;
            LtPicBox2.Visible = true;
            btnAnimalUpload3.Visible = true;
        }     

        private void btnAnimalUpload3_Click(object sender, EventArgs e)
        {
            Lto.ShowDialog();
            LtPicBox3.ImageLocation = Lto.FileName;
            btnAnimalUpload3.Visible = false;
            LtPicBox3.Visible = true;
            btnAnimalUpload4.Visible = true;
        }

        private void btnAnimalUpload4_Click(object sender, EventArgs e)
        {
            Lto.ShowDialog();
            LtPicBox4.ImageLocation = Lto.FileName;
            btnAnimalUpload4.Visible = false;
            LtPicBox4.Visible = true;
            btnAnimalUpload5.Visible = true;
        }
        
        private void btnAnimalUpload5_Click(object sender, EventArgs e)
        {
            Lto.ShowDialog();
            LtPicBox5.ImageLocation = Lto.FileName;
            btnAnimalUpload5.Visible = false;
            btnForecastLarry.Visible = true;
            LtPicBox5.Visible = true;
        }
        
        private void btnForecastLarry_Click(object sender, EventArgs e)
        {
            Update(listView1);
            
            if (listView1.Items[0].Text == "larry.jpg")
            {
                db.tahmin = "EVET LARRY BURDA";
                lblTahmin.Text = db.tahmin;
                lblTahminBox.Visible = true;
                lblTahmin.Visible = true;
                listView1.Visible = false;
            }
            else
            { db.tahmin = "HAYIR BU MALESEF LARRY DEĞİL TEKRAR DENE.";
                lblTahmin.Text = db.tahmin;
                lblTahminBox.Visible = true;
                lblTahmin.Visible = true;
                listView1.Visible = false;
            }
        }

        
    }
}
