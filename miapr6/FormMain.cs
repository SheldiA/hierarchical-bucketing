using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace miapr6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void bt_classificate_Click(object sender, EventArgs e)
        {
            int numberObjects = Int32.Parse(tb_numberObjects.Text);
            HierarchicalBucketing.Criterion criterion;

            criterion = (cb_minMax.SelectedIndex == 0) ? HierarchicalBucketing.Criterion.min : HierarchicalBucketing.Criterion.max;

            ch_main.Series.Clear();
            dgv_distances.Rows.Clear();
            HierarchicalBucketing algor = new HierarchicalBucketing(numberObjects,ch_main);
            algor.Classification(criterion);
            FillDistancesTable(numberObjects,algor.Distances);
        }

        void FillDistancesTable(int numberObjects, byte[,] distances)
        {
            string temp = "      ";
            for (int i = 0; i < numberObjects; ++i)
                temp += ("x" + (i + 1) + "   ");
            dgv_distances.Rows.Add(temp);
            for (int i = 0; i < numberObjects; ++i)
            {
                temp = "x" + (i + 1) + "   ";
                for (int j = 0; j < numberObjects; ++j)
                {
                    temp += (distances[i,j] + "    ");
                }
                dgv_distances.Rows.Add(temp);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            cb_minMax.SelectedIndex = 0;
        }
    }
}
