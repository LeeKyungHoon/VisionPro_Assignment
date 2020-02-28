using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Cognex.VisionPro;
using Cognex.VisionPro.ImageFile;
using Cognex.VisionPro.Display;

namespace VisionPro_Assignment
{
    public partial class Mainform : Form
    {

        private static string directory = "C:\\Users\\Public\\Documents\\Cognex\\In-Sight\\In-Sight Explorer 5.8.0\\Sample Jobs\\EasyBuilder\\5x\\Bracket Inspection";
        private static List<string> imageList = new List<string>();



        public Mainform()
        {
            InitializeComponent();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(directory);

            foreach(FileInfo f in dirInfo.GetFiles())
            {
                imageList.Add(f.FullName);
            }

            CogImageFile image = new CogImageFile();
            image.Open(imageList.ElementAt(0), CogImageFileModeConstants.Read);

            cogDisplay1.Image = image[0];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms.OfType<SettingForm>().Count() == 0)
            {
                SettingForm form = new SettingForm(this);

                form.Show();
            }
        }

        public CogDisplay Display
        {
            get => cogDisplay1; 
        }

    }
}
