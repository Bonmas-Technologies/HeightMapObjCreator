using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeightMapObjCreator
{
    public partial class Form1 : Form
    {
        private string imagepath = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }


        private void LoadImage(object sender, EventArgs e)
        {
            var result = fileOpener.ShowDialog();

            if (result != DialogResult.OK)
                return;

            imagepath = fileOpener.FileName;

            viewer.Image = Image.FromFile(imagepath);
        }

        private void GetAndSaveObj(object sender, EventArgs e)
        {
            if (imagepath == string.Empty)
            {
                MessageBox.Show("load picture");
                return;
            }

            var result = MeshGenerator.GetObjectByImage(imagepath);

            using (StreamWriter writer = new StreamWriter(imagepath + ".obj"))
                writer.Write(result);
        }
    }
}
