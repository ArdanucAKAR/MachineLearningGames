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
using MachineLearningGames.LocateLarry.Tabs;
using System.IO;

namespace MachineLearningGames.LocateLarry.Tabs
{
    public partial class LocateLarryTrain : UserControl
    {
        public LocateLarryTrain()
        {
            InitializeComponent();
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

        private void btnLarryUpload_Click(object sender, EventArgs e)
        {
            Update(LarryList);
            db.larry = 1;
            for (int i = 0; i < LarryList.Items.Count; i++)
            {
                if (LarryList.Items[i].Text == "larry.jpg")
                {
                    db.tahmin = "EVET LARRY BURDA";

                }
               

                
            }
        }

        private void btnAnimalUpload_Click(object sender, EventArgs e)
        {
            Update(LilyList);
            
            db.lily = 1;
            
            for (int i = 0; i < LilyList.Items.Count; i++)
            {
                if (LilyList.Items[i].Text == "lily.jpg")
                {
                    db.tahmin = "HAYIR BU MALESEF LARRY DEĞİL TEKRAR DENE.";

                }



            }
        }

    

        private void btnLadyUpload_Click(object sender, EventArgs e)
        {
            Update(LadyList);

            db.lady = 1;

            for (int i = 0; i < LadyList.Items.Count; i++)
            {
                if (LadyList.Items[i].Text == "lady.jpg")
                {
                    db.tahmin = "HAYIR BU MALESEF LARRY DEĞİL TEKRAR DENE.";

                }



            }
        }

        private void btnGoldenUpload_Click(object sender, EventArgs e)
        {
            Update(GoldenList);

            db.golden = 1;
            

            for (int i = 0; i < GoldenList.Items.Count; i++)
            {
                if (GoldenList.Items[i].Text == "golden.jpg")
                {
                    db.tahmin = "HAYIR BU MALESEF LARRY DEĞİL TEKRAR DENE.";

                }



            }
        }

        private void btnKingsUpload_Click(object sender, EventArgs e)
        {
            Update(KingsList);

            db.kings = 1;

            for (int i = 0; i < KingsList.Items.Count; i++)
            {
                if (KingsList.Items[i].Text == "kings.jpg")
                {
                    db.tahmin = "HAYIR BU MALESEF LARRY DEĞİL TEKRAR DENE.";

                }



            }
        }
    }
}
