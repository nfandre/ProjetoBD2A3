using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;



namespace Apresentacao
{
    public class FormularioMover 
    {

        public int mov { get; set; }
        public int movX { get; set; }
        public int movY { get; set; }
        public FormularioMover()
        {

        }
        public void MouseDown(MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        public bool MouseMover(MouseEventArgs e, Form x)
        {
            bool retorno = false;
            if (mov == 1)
            {
                retorno = true;
                
            }
            return retorno;
        }

        public void MoveUp()
        {
            mov = 0;
        }
    }
}
