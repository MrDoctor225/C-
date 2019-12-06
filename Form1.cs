using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int[,] field = new int[5, 5];
        int[,] arr = new int[5, 5];
        public Form1()
        {
            InitializeComponent();
            View1.Rows.Add();
            View1.Rows.Add();
            View1.Rows.Add();
            View1.Rows.Add();
            View1.Rows[0].HeaderCell.Value = "0";
            View1.Rows[1].HeaderCell.Value = "1";
            View1.Rows[2].HeaderCell.Value = "2";
            View1.Rows[3].HeaderCell.Value = "3";
            View1.Rows[4].HeaderCell.Value = "4";
            bool z;
            for (int i = 0; i <5; i++)
            {
                for (int j =0; j<5; j++) 
                {
                    arr[i,j]= 0;
                }
            }
            
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    field[i, j] = rnd.Next(0, 2);
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    View1.Rows[i].Cells[j].Value = field[i, j];

                }
            }
        }

        private void View1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
        
        }

        private void View1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (arr[e.RowIndex, e.ColumnIndex] != 1)
            {
                if (field[e.RowIndex, e.ColumnIndex] == 0)
                {
                arr[e.RowIndex, e.ColumnIndex] = 1;///field[e.RowIndex, e.ColumnIndex];
                }

            }
            
            if(field[e.RowIndex,e.ColumnIndex] == 1)           
            {
                label2.Visible = true; 
            }
        }
    }
}
