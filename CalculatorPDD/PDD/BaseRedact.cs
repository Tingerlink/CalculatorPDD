using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDD
{
    public partial class BaseRedact : Form
    {
        public BaseRedact()
        {
            InitializeComponent();

            PE = new PDDEntities();
         
            InitSigns();
            InitComboBox();

            listSigns.SelectedIndex = 0;
        }
        
        /// <summary>
        /// Объект для работы с БД
        /// </summary>
        PDDEntities PE;
    
        /// <summary>
        /// Вывод списка знаков
        /// </summary>
        private void InitSigns()
        {
            try
            {
                listSigns.Items.Clear();
                listProhibishin.Items.Clear();
                listResolution.Items.Clear();

                foreach (road_sign sign in PE.road_sign)
                {
                    listSigns.Items.Add(string.Format("[{1}] {0}", sign.name, sign.pdd_number));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }
        /// <summary>
        /// Заполнение выпадающих списков вариантами
        /// </summary>
        private void InitComboBox()
        {
            try
            {
                cbProhibishin.Items.Clear();
                cbResolution.Items.Clear();

                foreach (act item in PE.act)
                {
                    cbProhibishin.Items.Add(item.name);
                    cbResolution.Items.Add(item.name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }
               
        /* События */

        /// <summary>
        /// Событие выбора элемента списка знаков
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listSigns_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int index = ((ListBox)sender).SelectedIndex;

                if (index != -1)
                {
                    ImageWorker IM = new ImageWorker();
                    road_sign sign = PE.road_sign.ToArray<road_sign>()[index];

                    pbImage.BackgroundImage = IM.GetImageByRelativePath(sign.img);

                    tbType.Text = PE.type_road_sign.Where(x => x.code_type_road_sign == sign.code_type_sign).First().name;
                    tbDescription.Text = sign.description;

                    listResolution.Items.Clear();
                    listProhibishin.Items.Clear();

                    foreach (act item in PE.item_list_resolution.Where(x => x.code_road_sign == sign.code_road_sign).Select(x => x.act))
                    {
                        listResolution.Items.Add(item.name);
                    }

                    foreach (act item in PE.item_list_prohibition.Where(x => x.code_road_sign == sign.code_road_sign).Select(x => x.act))
                    {
                        listProhibishin.Items.Add(item.name);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
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
        /// <summary>
        /// Применение изменений
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                int index = listSigns.SelectedIndex;

                if (index != -1)
                {
                    road_sign sign = PE.road_sign.ToArray<road_sign>()[index];

                    PE.road_sign.Where(x => x.code_road_sign == sign.code_road_sign).First().description = tbDescription.Text;

                    var lP = PE.item_list_prohibition.Where(x => x.code_road_sign == sign.code_road_sign);
                    foreach (var item in lP)
                    {
                        PE.item_list_prohibition.Remove(item);
                    }

                    var lR = PE.item_list_resolution.Where(x => x.code_road_sign == sign.code_road_sign);
                    foreach (var item in lR)
                    {
                        PE.item_list_resolution.Remove(item);
                    }

                    PE.SaveChanges();

                    foreach (string item in listResolution.Items)
                    {
                        act _act = PE.act.Where(x => x.name == item).First();

                        item_list_resolution iR = new item_list_resolution();
                        iR.code_road_sign = sign.code_road_sign;
                        iR.code_act = _act.code_act;

                        PE.item_list_resolution.Add(iR);
                        PE.SaveChanges();
                    }

                    foreach (string item in listProhibishin.Items)
                    {
                        act _act = PE.act.Where(x => x.name == item).First();

                        item_list_prohibition iP = new item_list_prohibition();
                        iP.code_road_sign = sign.code_road_sign;
                        iP.code_act = _act.code_act;

                        PE.item_list_prohibition.Add(iP);
                        PE.SaveChanges();
                    }


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }
        /// <summary>
        /// Выход из редактора БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Вызов окна редактирования списка действий
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsActSettings_Click(object sender, EventArgs e)
        {
            try
            {
                (new ActRedact()).ShowDialog();
                InitComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void tsAddSign_Click(object sender, EventArgs e)
        {
            (new AddSign()).ShowDialog();
            InitSigns();
        }

        private void tsDeleteSing_Click(object sender, EventArgs e)
        {
            if (listSigns.SelectedIndex > -1)
            {
                road_sign deleteSing = PE.road_sign.ToArray<road_sign>()[listSigns.SelectedIndex];

                PE.road_sign.Remove(deleteSing);

                PE.SaveChanges();

                InitSigns();
                MessageBox.Show("Знак удалён");

                if (listSigns.Items.Count > 0) listSigns.SelectedIndex = 0;
            }
        }
    }
}
