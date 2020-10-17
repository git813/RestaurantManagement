using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestSQL
{
    class Food_Delete : Food
    {
        Menu_Fix parent;
        public override void OnPicter_DClick(object sender, EventArgs e)
        {
            // Khi ẩn món ,form tự động dồn những món bên phải (dưới) lên
            if (parent.DeleteFood(lName.Text))
                this.Hide();
        }
        public void SetParent(Menu_Fix parent)
        {
            this.parent = parent;
        }
    }
}
