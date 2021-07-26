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
using Excel = Microsoft.Office.Interop.Excel;

namespace Cu_excel
{
    public partial class Form1 : Form
    {
        Excel.Application ex;
        Excel.Workbook doc;
        Excel.Worksheet pag;
        string nume;
        int ok;

        public Form1()
        {
            InitializeComponent();
            ok = 0;
        }

        private void cauta_Click(object sender, EventArgs e)
        {
            od.InitialDirectory = Directory.GetCurrentDirectory();
            if(od.ShowDialog() == DialogResult.OK)
            {
                ex = new Excel.Application();
                doc = ex.Workbooks.Open(od.FileName);
                pag = doc.Sheets[1];
                ok = 1;
                li.Items.Clear();
                nume = od.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            if(ok==1)
            {
                i = 2;
                while(pag.Cells[i,1].Value2 != null)
                {
                    li.Items.Add((string)pag.Cells[i, 1].Value2.ToString());
                    i++;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i;
            if (ok == 1)
            {
                i = 2;
                li.Items.Clear();
                while (pag.Cells[i, 1].Value2 != null)
                {
                    double x = Convert.ToDouble(pag.Cells[i, 2].Value2.ToString());
                    double y = Convert.ToDouble(pag.Cells[i, 3].Value2.ToString());

                    li.Items.Add(((x+y)/2).ToString());
                    pag.Cells[i, 4].Value2 = ((x + y) / 2).ToString();
                    i++;
                }
                doc.SaveAs(nume + "2");
                doc.Close();
            }

        }
    }
}
