using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_safe_of_the_Pilot_brothers.Controllers;

namespace The_safe_of_the_Pilot_brothers
{
    public partial class Form1 : Form
    {




        public Form1()
        {
            InitializeComponent();
           
        }

        private void CreateMap_Click(object sender, EventArgs e)
        {
            int mapSize;
            try { mapSize = Convert.ToInt32(NBox.Text);}
            catch  { mapSize = 0; }
            MapController.Refresh(this);
            MapController.Init(this, mapSize);
        }
    }
}
