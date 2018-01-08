using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace PDD
{
    public partial class AddSign : Form
    {
        public AddSign()
        {
            InitializeComponent();

            PE = new PDDEntities();

            InitComboBox();
        }

        PDDEntities PE;

        private void InitComboBox()
        {
            cbType.Items.Clear();
            cbProhibishin.Items.Clear();
            cbResolution.Items.Clear();

            foreach (string item in PE.type_road_sign.Select(x=>x.name))
            {
                cbType.Items.Add(item);
            }

            foreach (string item in PE.act.Select(x=>x.name))
            {
                cbProhibishin.Items.Add(item);
                cbResolution.Items.Add(item);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Application.StartupPath + @"img\\";
            openFileDialog.Filter = "PNG files (*.png)|*.png|JPG files (*.jpg)|*.jpg";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog.FileName;

                if (filename != "")
                {
                    tbPath.Text = filename;
                    ImageWorker IM = new ImageWorker();
                    pbImage.BackgroundImage = IM.GetImageByAbsolutePath(filename);
                }
            }
        }

        private bool Check()
        {
            if (tbName.Text == "") return false;
            if (tbPath.Text == "") return false;
            if (cbType.SelectedIndex < 0) return false;
            if (!CheckNumber(tbNumber.Text))
            {
                MessageBox.Show("Знак с таким номером уже существует", "Ошибка");
                return false;
            }

            return true;
        }

        private bool CheckNumber(string val)
        {
            val = val.Replace('_', '.');
            if (PE.road_sign.Where(x=>x.pdd_number == val).Count() > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Добавление разрешенного действия
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddResolution_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbResolution.SelectedItem != null)
                {
                    string actName = cbResolution.SelectedItem.ToString();

                    if (listResolution.Items.IndexOf(actName) < 0 && listProhibishin.Items.IndexOf(actName) < 0)
                    {
                        listResolution.Items.Add(actName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }
        /// <summary>
        /// Удаление разрешенного действия
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteResolution_Click(object sender, EventArgs e)
        {
            try
            {
                if (listResolution.SelectedItem != null)
                {
                    listResolution.Items.Remove(listResolution.SelectedItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }
        /// <summary>
        /// Добавление запрещенного действия
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddProhibishin_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbProhibishin.SelectedItem != null)
                {
                    string actName = cbProhibishin.SelectedItem.ToString();

                    if (listProhibishin.Items.IndexOf(actName) < 0 && listResolution.Items.IndexOf(actName) < 0)
                    {
                        listProhibishin.Items.Add(actName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }
        /// <summary>
        /// Удаление запрещенного действия
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteProhibishin_Click(object sender, EventArgs e)
        {
            try
            {
                if (listProhibishin.SelectedItem != null)
                {
                    listProhibishin.Items.Remove(listProhibishin.SelectedItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                AddNewSign();
            }
        }

        private void AddNewSign()
        {
            road_sign newSign = new road_sign();

            newSign.name = tbName.Text;
            newSign.pdd_number = tbNumber.Text;
            newSign.code_type_sign = PE.type_road_sign.ToArray<type_road_sign>()[cbType.SelectedIndex].code_type_road_sign;
            newSign.description = tbDescription.Text;

            ImageWorker IM = new ImageWorker();
            IM.CopyImageByName(tbPath.Text, newSign.pdd_number.Replace('.', '_'));
            newSign.img = newSign.pdd_number.Replace('.', '_') + ".png";

            PE.road_sign.Add(newSign);
            PE.SaveChanges();                      

            foreach (string item in listResolution.Items)
            {
                act _act = PE.act.Where(x => x.name == item).First();

                item_list_resolution iR = new item_list_resolution();
                iR.code_road_sign = newSign.code_road_sign;
                iR.code_act = _act.code_act;

                PE.item_list_resolution.Add(iR);
                PE.SaveChanges();
            }

            foreach (string item in listProhibishin.Items)
            {
                act _act = PE.act.Where(x => x.name == item).First();

                item_list_prohibition iP = new item_list_prohibition();
                iP.code_road_sign = newSign.code_road_sign;
                iP.code_act = _act.code_act;

                PE.item_list_prohibition.Add(iP);
                PE.SaveChanges();
            }

            this.Close();
        }

    }
}
