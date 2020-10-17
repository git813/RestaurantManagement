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

namespace TestSQL
{
    public partial class AddFood : Form
    {
        Menu_Fix Fix;
        public AddFood(Menu_Fix fix)
        {
            Fix = fix;
            InitializeComponent();
        }
        string path = "";
        private void bBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            path = openFileDialog.FileName;
            try
            {
                pictureBox1.Image = Image.FromFile(path);
            }
            catch(Exception ex)
            {
                path = "";
                MessageBox.Show("File không phải hình ảnh, vui lòng chọn lại");
            }
            //MessageBox.Show(path);
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên món ăn", "Thiếu thông tin");
            }
            else if (tbPrice.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giá", "Thiếu thông tin");
            }
            else if (pictureBox1.Image == null)
            {
                MessageBox.Show("Vui lòng chọn hình ảnh ", "Thiếu thông tin");
            }
            else
            {
                if (Fix.InsertData(tbName.Text, tbPrice.Text, path))
                {
                    MessageBox.Show("Thêm món "+tbName.Text+" thành công");
                    tbName.Text = "";
                    tbPrice.Text = "";
                    pictureBox1.Image = null;
                }
                
            }
        }
    }
}
