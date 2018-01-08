using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PDD
{
    public partial class SignPanel : UserControl
    {
        public SignPanel(road_sign sign, Bitmap image, MainWindow parent)
        {
            InitializeComponent();

            this.Sign = sign;
            this.ParentWindow = parent;

            this.lbNumber.Text = sign.pdd_number;
            this.tnName.Text = sign.name;       
            this.cbSelected.Checked = false;

            ImageWorker IW = new ImageWorker();

            pbImage.BackgroundImage = IW.GetImageByRelativePath(sign.img);            
        }

        road_sign Sign;
        MainWindow ParentWindow;

        public void Unchecked()
        {
            this.cbSelected.Checked = false;
            ParentWindow.SelectedItem(Sign, false);
        }

        private void panelConteiner_Click(object sender, EventArgs e)
        {
            this.cbSelected.Checked = !this.cbSelected.Checked;
            ParentWindow.SelectedItem(Sign, this.cbSelected.Checked);
        }

        private void cbSelected_Click(object sender, EventArgs e)
        {
            ParentWindow.SelectedItem(Sign, this.cbSelected.Checked);
        }


    }
}
