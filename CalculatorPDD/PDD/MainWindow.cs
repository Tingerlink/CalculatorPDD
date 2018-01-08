using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Collections;

namespace PDD
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            PE = new PDDEntities();

            UpdateAll();
        }

        /// <summary>
        /// Объект для работы с БД
        /// </summary>
        PDDEntities PE;

        /// <summary>
        /// Список выбранных знаков
        /// </summary>
        List<road_sign> SelectedSign;


        /// <summary>
        /// Заполнение всех панелей знаками
        /// </summary>
        private void SetAllSign()
        {
            try
            {
                List<type_road_sign> listType = PE.type_road_sign.ToList<type_road_sign>();

                tabSingByType.TabPages.Clear();
                foreach (type_road_sign item in listType)
                {
                    TabPage newPage = new TabPage();
                    newPage.Text = item.name;

                    FlowLayoutPanel newFlow = new FlowLayoutPanel();
                    newFlow.Name = "SignPanel_" + item.code_type_road_sign.ToString();
                    newFlow.Dock = System.Windows.Forms.DockStyle.Fill;
                    newFlow.Location = new System.Drawing.Point(3, 3);
                    newFlow.AutoScroll = true;

                    newPage.Controls.Add(newFlow);
                    tabSingByType.TabPages.Add(newPage);

                    SetSignInFlow(newFlow, item.code_type_road_sign);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }
        /// <summary>
        /// Получение списка знаков заданного типа
        /// </summary>
        /// <param name="typeSign">Код типа знаков</param>
        /// <returns></returns>
        private List<road_sign> CreateGroupPanel(long typeSign)
        {
            List<road_sign> listRoadSign = null;
            try
            {
                listRoadSign = PE.road_sign.Where(x => x.code_type_sign == typeSign).ToList<road_sign>();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            return listRoadSign;
        }        
        /// <summary>
        /// Заполнение панели знаками одного типа
        /// </summary>
        /// <param name="newFlow"></param>
        /// <param name="type"></param>
        private void SetSignInFlow(FlowLayoutPanel newFlow, long type)
        {
            try
            {
                List<road_sign> list = CreateGroupPanel(type);
                ImageWorker IM = new ImageWorker();

                foreach (road_sign item in list)
                {                    
                    newFlow.Controls.Add(new SignPanel(item, IM.GetImageByRelativePath(item.img), this));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }
        /// <summary>
        /// Добавление знака в контейнер выбранных знаков
        /// </summary>
        /// <param name="sign"></param>
        private void AddToFlowSelectedSigns(road_sign sign)
        {
            try
            {
                foreach (PictureBox item in flowListSelectedSign.Controls)
                {
                    if (item.Tag != null && item.Tag.ToString() == sign.pdd_number) return;
                }

                ImageWorker IM = new ImageWorker();

                PictureBox pb = new PictureBox();
                pb.BackgroundImage = IM.GetImageByRelativePath(sign.img);
                pb.Width = 64;
                pb.Height = 64;
                pb.Tag = sign.pdd_number;
                pb.BackgroundImageLayout = ImageLayout.Stretch;

                flowListSelectedSign.Controls.Add(pb);
                SelectedSign.Add(sign);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }
        /// <summary>
        /// Удаление знака из контейнера выбранных знаков
        /// </summary>
        /// <param name="sign"></param>
        private void RemoveFromFlowSelectedSigns(road_sign sign)
        {
            try
            {
                PictureBox removed = null;
                foreach (PictureBox item in flowListSelectedSign.Controls)
                {
                    if (item.Tag != null && item.Tag.ToString() == sign.pdd_number)
                    {
                        removed = item;
                        break;
                    }
                }

                if (removed != null)
                {
                    flowListSelectedSign.Controls.Remove(removed);
                }

                SelectedSign.Remove(sign);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }
        /// <summary>
        /// Выбор состояния знака выбран/не выбран
        /// </summary>
        /// <param name="sign"></param>
        /// <param name="flag"></param>
        public void SelectedItem(road_sign sign, bool flag)
        {
            try
            {
                if (flag)
                {
                    AddToFlowSelectedSigns(sign);
                }
                else
                {
                    RemoveFromFlowSelectedSigns(sign);
                }

                UpdateResult();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }
        /// <summary>
        /// Обновление полей вывода результатов
        /// </summary>
        private void UpdateResult()
        {
            try
            {
                List<string> prohibition = new List<string>();
                List<string> resolution = new List<string>();

                List<string> info = new List<string>();

                foreach (road_sign item in SelectedSign)
                {
                    resolution.AddRange(PE.item_list_resolution.Where(x => x.code_road_sign == item.code_road_sign).Select(x => x.act.name));
                    prohibition.AddRange(PE.item_list_prohibition.Where(x => x.code_road_sign == item.code_road_sign).Select(x => x.act.name));
                    info.Add(item.description);
                }

                prohibition = RemoveDublicate(prohibition);
                resolution = RemoveSame(RemoveDublicate(resolution), prohibition);

                SetAct(lbResolution, resolution);
                SetAct(lbProhibition, prohibition);
                SetAct(lbInfo, info);

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.StackTrace);
            }
        }
        /// <summary>
        ///  Удаление совпадений из списка
        /// </summary>
        /// <param name="list"></param>
        /// <param name="sourse"></param>
        /// <returns></returns>
        private List<string> RemoveSame(List<string> list, List<string> sourse)
        {
            try
            {
                foreach (string item in sourse)
                {
                    if (list.Where(x => x == item).Count() > 0)
                    {
                        list.Remove(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }

            return list;
        }
        private Tuple<string, string> FindSame(List<string> list, List<string> sourse)
        {
            try
            {
                foreach (string item in sourse)
                {
                    if (list.Where(x => x == item).Count() > 0)
                    {
                        return new Tuple<string, string>(item, list.Where(x => x == item).First());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }

            return null;
        }


        /// <summary>
        /// Удаление дубликатов из списка
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        private List<string> RemoveDublicate(List<string> list)
        {
            List<string> newList = new List<string>();
            try
            {
                foreach (string item in list)
                {
                    if (newList.Where(x => x == item).Count() == 0)
                    {
                        newList.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }

            return newList;
        }
        /// <summary>
        /// Заполнение списка элемнтов
        /// </summary>
        /// <param name="source"></param>
        /// <param name="names"></param>
        private void SetAct(ListBox source, List<string> names)
        {
            try
            {
                source.Items.Clear();
                foreach (string item in names)
                {
                    if (item != null && item != "")
                    {
                        source.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }
        /// <summary>
        /// Обновление ресурсов окружения
        /// </summary>
        private void UpdateAll()
        {
            try
            {               
                SetAllSign();

                SelectedSign = new List<road_sign>();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }
        
        
        /* События */

        /// <summary>
        /// Очистка выделений
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClean_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (TabPage page in tabSingByType.TabPages)
                {
                    foreach (SignPanel item in ((FlowLayoutPanel)page.Controls[0]).Controls)
                    {
                        item.Unchecked();
                    }
                }

                SelectedSign.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }
        /// <summary>
        /// Открытие окна редактирования БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSettings_Click(object sender, EventArgs e)
        {
            (new BaseRedact()).ShowDialog();
        }
        /// <summary>
        /// Выход из программы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsUpdate_Click(object sender, EventArgs e)
        {
            UpdateAll();
        }
    }
}
