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
    public partial class ActRedact : Form
    {
        public ActRedact()
        {
            InitializeComponent();

            PE = new PDDEntities();

            UpdateList();
        }

        /// <summary>
        /// Объект для работы с БД
        /// </summary>
        PDDEntities PE;

        /// <summary>
        /// Обновление списка действий
        /// </summary>
        private void UpdateList()
        {
            try
            {
                listAct.Items.Clear();
                listAct.Items.AddRange(PE.act.Select(x => x.name).ToArray<string>());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        /* События */

        /// <summary>
        /// Закрытае окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Удаление действия из списка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (listAct.SelectedIndex > -1)
                {
                    int index = listAct.SelectedIndex;
                    act _act = PE.act.ToArray<act>()[index];

                    PE.act.Remove(_act);
                    PE.SaveChanges();

                    UpdateList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }

        }
        /// <summary>
        /// Добавление действия
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (listAct.Items.IndexOf(tbName.Text) < 0)
                {
                    listAct.Items.Add(tbName.Text);

                    act newAct = new act();
                    newAct.name = tbName.Text;

                    PE.act.Add(newAct);
                    PE.SaveChanges();

                    UpdateList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }
    }
}
