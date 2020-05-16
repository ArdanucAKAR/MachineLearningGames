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

namespace MachineLearningGames.JudgeBook.Tabs
{
    public partial class Train : UserControl
    {
        Singleton db = Singleton.GetInstance();

        int count = 0;
        public string ImageNewName = "";
        ImageList myImageList = new ImageList();
        FileInfo fi;
        OpenFileDialog ofd = new OpenFileDialog()
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
            db.JudgeBook.ChildrenBook = 1;

            for (int i = 0; i < childrensBookList.Items.Count; i++)
                if (childrensBookList.Items[i].Text == "kitap.jpg")
                    db.JudgeBook.Genre = "Bence bu bir çocuk kitabı";
        }

        private void btnUploadRomance_Click(object sender, EventArgs e)
        {
            Update(romanceBookList);
            db.JudgeBook.RomanceBook = 1;

            for (int i = 0; i < romanceBookList.Items.Count; i++)
                if (romanceBookList.Items[i].Text == "kitap.jpg")
                    db.JudgeBook.Genre = "Bence bu bir romantik kitap";
        }

        private void btnUploadThriller_Click(object sender, EventArgs e)
        {
            Update(thrillerBookList);
            db.JudgeBook.ThrillerBook = 1;

            for (int i = 0; i < thrillerBookList.Items.Count; i++)
                if (thrillerBookList.Items[i].Text == "kitap.jpg")
                    db.JudgeBook.Genre = "Bence bu bir korku kitabı";
        }

        private void btnUploadScifi_Click(object sender, EventArgs e)
        {
            Update(scifiBookList);
            db.JudgeBook.ScifiBook = 1;

            for (int i = 0; i < scifiBookList.Items.Count; i++)
                if (scifiBookList.Items[i].Text == "kitap.jpg")
                    db.JudgeBook.Genre = "Bence bu bir bilim kurgu kitabı";
        }
    }
}