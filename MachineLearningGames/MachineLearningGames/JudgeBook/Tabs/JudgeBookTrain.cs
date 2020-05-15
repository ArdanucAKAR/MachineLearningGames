using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MachineLearningGames.JudgeBook.Class;
using System.IO;

namespace MachineLearningGames.JudgeBook.Tabs
{
    public partial class JudgeBookTrain : UserControl
    {
        public JudgeBookTrain()
        {
            InitializeComponent();
        }

        SingletonJB db = SingletonJB.GetInstance();
        ImageList myImageList = new ImageList();
        int count = 0;
        public string ImageNewName = "";
        OpenFileDialog ofd = new OpenFileDialog()
        {
            Multiselect = true,
            ValidateNames = true,
            Filter = "JPG|*jpg|JPEG|*.jpeg|PNG|*.png"
        };
        FileInfo fi;

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

        private void btnUploadChildren_Click(object sender, EventArgs e)
        {
            Update(childrensBookList);
            db.childrenBook = 1;
            for (int i = 0; i < childrensBookList.Items.Count; i++)
                if (childrensBookList.Items[i].Text == "kitap.jpg")
                    db.genre = "Bence bu bir çocuk kitabı";
        }

        private void btnUploadRomance_Click(object sender, EventArgs e)
        {
            Update(romanceBookList);
            db.romanceBook = 1;

            for (int i = 0; i < romanceBookList.Items.Count; i++)
                if (romanceBookList.Items[i].Text == "kitap.jpg")
                    db.genre = "Bence bu bir romantik kitap";
        }

        private void btnUploadThriller_Click(object sender, EventArgs e)
        {
            Update(thrillerBookList);
            db.thrillerBook = 1;

            for (int i = 0; i < thrillerBookList.Items.Count; i++)
                if (thrillerBookList.Items[i].Text == "kitap.jpg")
                    db.genre = "Bence bu bir korku kitabı";
        }

        private void btnUploadScifi_Click(object sender, EventArgs e)
        {
            Update(scifiBookList);
            db.scifiBook = 1;
            for (int i = 0; i < scifiBookList.Items.Count; i++)
                if (scifiBookList.Items[i].Text == "kitap.jpg")
                    db.genre = "Bence bu bir bilim kurgu kitabı";
        }
    }
}