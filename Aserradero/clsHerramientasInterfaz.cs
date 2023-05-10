using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aserradero.Logica;

namespace Aserradero
{
    public class clsHerramientasInterfaz
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public void moverForms(MouseEventArgs e, IntPtr handle)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public void minimizarVentana(Form form)
        {
            form.WindowState = FormWindowState.Minimized;
        }

        public void cerrarVentanas(Form formCaller)
        {
            FormCollection formCollectionAbiertos = Application.OpenForms; // No se pueden listar los forms cuando se cierran en un FormCollection
            List<Form> formsAbiertos = new List<Form>();
            foreach (Form form in formCollectionAbiertos)
            {
                formsAbiertos.Add(form);
            }

            foreach (Form form in formsAbiertos)
            {
                if (form != formCaller)
                {
                    form.Close();
                }
            }

            formCaller.Close();
        }
    }
}
