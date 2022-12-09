using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassIndexGUIApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Hämta data från textfält
            string strName = txtName.Text;
            int intAge = Convert.ToInt32(txtAge.Text);
            string strTitle = txtTitle.Text;

            //Skapa ett Worker obejkt från den hämtade datan
            new Worker(strName, intAge, strTitle);

            //Uppdatera vår TrackerBar
            trackWorker.Maximum = Worker.AllWorkers.Count - 1;
        }
    }
}
