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
    public partial class Menu_Fix : Form
    {
        bool ableDelete = false;
        DataFood_Fix data;
        public Menu_Fix()
        {
            InitializeComponent();
            lbDelete.Hide();
            data = new DataFood_Fix(this);
            data.ReadDATA();
            CheckDelete();
        }
        public void Add(string name, string price, string path)
        {
            Food_Delete f = new Food_Delete();
            f.Set(path, name, price);
            f.SetParent(this);
            f.SetTransform(150, 210, 0, 0);
            this.flowLayoutPanel1.Controls.Add(f);
        }
        public bool InsertData(string name,string price,string path)
        {
            if (data.InSertData(name, price, path))
            {
                Add(name, price, path);
                return true;
            }
            return false;
        }
        
        private void bAddFood_Click(object sender, EventArgs e)
        {
            AddFood addFood = new AddFood(this);
            addFood.ShowDialog();
        }
        public bool DeleteFood(string name)
        {
            if (ableDelete)
            {
                if (data.DeleteData(name))
                    MessageBox.Show("Món " + name + " đã được xóa");
                return true;
            }
            return false;
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            ableDelete = !ableDelete;
            CheckDelete();
        }
        void CheckDelete()
        {
            if (ableDelete)
            {
                lbDelete.Show();
                bDelete.BackColor = Color.Yellow;
            }
            else
            {
                lbDelete.Hide();
                bDelete.BackColor = Color.White;
            }
        }
    }
}
