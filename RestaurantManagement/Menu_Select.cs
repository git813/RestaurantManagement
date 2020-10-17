using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestSQL
{
    public partial class Menu_Select : Form
    {
        DataFood_ReadOnly data;
        public Menu_Select()
        {
            InitializeComponent();
            data = new DataFood_ReadOnly(this);
            data.ReadDATA();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add("wibu", "$69", "wibu.jpg");
        }
        public void Add(string name,string price,string path)
        {
            Food_Select f = new Food_Select();
            f.Set(path, name, price);
            f.SetParent(this);
            f.SetTransform(150, 210, 0, 0);
            this.flowLayoutPanel1.Controls.Add(f);
        }
    }
}
