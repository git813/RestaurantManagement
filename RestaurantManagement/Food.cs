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
    // Tạo nhóm để hiển thị món ăn
    abstract public class Food :Panel
    {
        protected PictureBox pFood = new PictureBox();
        protected Label lName = new Label();
        protected Label lPrice = new Label();
        public void Set(string pathPicture,string name,string price)
        {
            pFood.Image = Image.FromFile(pathPicture);
            lName.Text = name;
            lPrice.Text = price;
            init();
            this.pFood.DoubleClick += new System.EventHandler(OnPicter_DClick);
        }
        public void init()
        {
            //cài chế độ 
            this.AutoSize = false;
            lName.AutoSize = false;
            lName.ForeColor = Color.Black;
            lPrice.ForeColor = Color.Black;
            lPrice.AutoSize = false;
            pFood.SizeMode = PictureBoxSizeMode.Zoom;
            this.BackColor = Color.White;
        }
        abstract public void OnPicter_DClick(Object sender, EventArgs e);
        // cài đặt thông số
        public void SetTransform(int sizeX,int sizeY, int posX,int posY)
        {
            this.Size = new Size(sizeX, sizeY);
            this.Location = new Point(posX, posY);

            // tỉ lệ 5:7
            //////////////////
            //vị trí
            pFood.Location = new Point(posX , posY );
            lName.Location = new Point(posX , posY + (int) (5f * (sizeY / 7)) );
            lPrice.Location = new Point(posX , posY + (int ) (6f * (sizeY / 7) ));

            //kích thước
            pFood.Size = new Size(sizeX, sizeX);
            lName.Size = new Size(sizeX, sizeY / 7);
            lPrice.Size = new Size(sizeX, sizeY / 7);
            /////////////////////

            //thêm vào nhóm
            this.Controls.Add(pFood);
            this.Controls.Add(lName);
            this.Controls.Add(lPrice);
        }
    }
}
