using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MachineLearningGames.Mehmetcik.Class;
using System.IO;

namespace MachineLearningGames.Mehmetcik.Tabs
{
    public partial class PicturesTrain3 : UserControl
    {
        public PicturesTrain3()
        {
            InitializeComponent();
        }

        Pictures db = Pictures.SingleInstance();
        System.Windows.Forms.ImageList myImageList = new ImageList();
        int count = 0;
        public string ImageNewName = "";
        OpenFileDialog ofd = new OpenFileDialog()
        {
            Multiselect = true,
            ValidateNames = true,
            Filter =
         "JPG|*jpg|JPEG|*.jpeg|PNG|*.png"
        };
        FileInfo fi;

        public ListView LarryList { get; private set; }
        public ListView notLarryList { get; private set; }

        public void Update(ListView listView)
        {
            myImageList.ImageSize = new Size(60, 90);
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                listView.Items.Clear();
                foreach (string fileName in ofd.FileNames)
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
            private void btnUploadLarry_Click(object sender, EventArgs e)
        {
            Update(LarryList);
            db.larry = 1;
            for (int i = 0; i < LarryList.Items.Count; i++)
            {
                if (LarryList.Items[i].Text == "larry.jpg")
                {
                    db.genre = "EVET BU LARRY";

                }
            }

        }

        private void btnTest_Click(object sender, EventArgs e)
        {

        }

        private void btnUploadNormal_Click(object sender, EventArgs e)
        {
            Update(notLarryList);
            db.notLarry = 1;
            for (int i = 0; i < notLarryList.Items.Count; i++)
            {
                if (notLarryList.Items[i].Text == "larry.jpg")
                {
                    db.genre = "BU LARRY DEĞİL";

                }
            }
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
                    }
    }
}
