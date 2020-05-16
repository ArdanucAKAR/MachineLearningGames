using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MachineLearningGames.Main.Classes;

namespace MachineLearningGames.LocateLarry.Tabs
{
    public partial class Train : UserControl
    {
        Singleton db = Singleton.GetInstance();

        int count = 0;
        public string ImageNewName = "";
        FileInfo fi;
        ImageList myImageList = new ImageList();
        OpenFileDialog Lto = new OpenFileDialog()
        {
            Multiselect = true,
            ValidateNames = true,
            Filter = "JPG|*jpg|JPEG|*.jpeg|PNG|*.png"
        };

        public Train()
        {
            InitializeComponent();
        }

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
            db.LocateLarry.Larry = 1;

            for (int i = 0; i < LarryList.Items.Count; i++)
                if (LarryList.Items[i].Text == "larry.jpg")
                    db.LocateLarry.Estimated = "EVET LARRY BURDA";
        }

        private void btnLilyUpload_Click(object sender, EventArgs e)
        {
            Update(LilyList);
            db.LocateLarry.Lily = 1;

            for (int i = 0; i < LilyList.Items.Count; i++)
                if (LilyList.Items[i].Text == "lily.jpg")
                    db.LocateLarry.Estimated = "HAYIR BU MALESEF LARRY DEĞİL TEKRAR DENE.";
        }

        private void btnLadyUpload_Click(object sender, EventArgs e)
        {
            Update(LadyList);
            db.LocateLarry.Lady = 1;

            for (int i = 0; i < LadyList.Items.Count; i++)
                if (LadyList.Items[i].Text == "lady.jpg")
                    db.LocateLarry.Estimated = "HAYIR BU MALESEF LARRY DEĞİL TEKRAR DENE.";
        }

        private void btnGoldenUpload_Click(object sender, EventArgs e)
        {
            Update(GoldenList);

            db.LocateLarry.Golden = 1;

            for (int i = 0; i < GoldenList.Items.Count; i++)
                if (GoldenList.Items[i].Text == "golden.jpg")
                    db.LocateLarry.Estimated = "HAYIR BU MALESEF LARRY DEĞİL TEKRAR DENE.";
        }

        private void btnKingsUpload_Click(object sender, EventArgs e)
        {
            Update(KingsList);

            db.LocateLarry.Kings = 1;

            for (int i = 0; i < KingsList.Items.Count; i++)
                if (KingsList.Items[i].Text == "kings.jpg")
                    db.LocateLarry.Estimated = "HAYIR BU MALESEF LARRY DEĞİL TEKRAR DENE.";
        }
    }
}
