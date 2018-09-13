using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sistemaFCNM.Clases
{
    class MouseMovimiento
    {
        private Form1 forma1;

        public MouseMovimiento (Form1 forma1)
        {
            this.forma1 = forma1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            forma1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);

        }

        const int WM_SYSCOMMAND = 0x112;
        const int MOUSE_MOVE = 0xF012;

        // Declaraciones del API
        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        //
        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //
        // función privada usada para mover el formulario actual

        private void moverForm()
        {
            ReleaseCapture();
            SendMessage(forma1.Handle, WM_SYSCOMMAND, MOUSE_MOVE, 0);
        }


        public void Form1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            moverForm();
        }
    }
}
