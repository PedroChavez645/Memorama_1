using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memorama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ryu1_cover_Click(object sender, EventArgs e)
        {
            ryu1_cover.Visible = false;
            ryu1.Visible = true;

            if (ryu1.Visible == true && ryu2.Visible == true)
            {
                label2.Text = "Exito";
            }
            else
            if (ryu1.Visible == true && chunli1.Visible == true || chunli2.Visible == true || sagat1.Visible == true || sagat2.Visible == true
                || guile1.Visible == true || guile2.Visible == true || vega1.Visible == true || vega2.Visible == true || ken1.Visible == true
                || ken2.Visible == true)
            {
                label2.Text = "No coincide";
                ryu1_cover.Visible = true;
                ryu1.Visible = false;
                chunli1_cover.Visible = true;
                chunli1.Visible = false;
                chunli2_cover.Visible = true;
                chunli2.Visible = false;
                sagat1_cover.Visible = true;
                sagat1.Visible = false;
                sagat2_cover.Visible = true;
                sagat2.Visible = false;
                guile1_cover.Visible = true;
                guile1.Visible = false;
                guile2_cover.Visible = true;
                guile2.Visible = false;
                vega1_cover.Visible = true;
                vega1.Visible = false;
                vega2_cover.Visible = true;
                vega2.Visible = false;
                ken1_cover.Visible = true;
                ken1.Visible = false;
                ken2_cover.Visible = true;
                ken2.Visible = false;
            }

        }

        private void ryu2_cover_Click(object sender, EventArgs e)
        {
            ryu2_cover.Visible = false;
            ryu2.Visible = true;

            if (ryu2.Visible == true && ryu1.Visible == true)
            {
                label2.Text = "Exito";
            }
            else
            if (ryu2.Visible == true && chunli1.Visible == true || chunli2.Visible == true || sagat1.Visible == true || sagat2.Visible == true
                 || guile1.Visible == true || guile2.Visible == true || vega1.Visible == true || vega2.Visible == true || ken1.Visible == true
                 || ken2.Visible == true)
            {
                label2.Text = "No coincide";
                ryu2_cover.Visible = true;
                ryu2.Visible = false;
                chunli1_cover.Visible = true;
                chunli1.Visible = false;
                chunli2_cover.Visible = true;
                chunli2.Visible = false;
                sagat1_cover.Visible = true;
                sagat1.Visible = false;
                sagat2_cover.Visible = true;
                sagat2.Visible = false;
                guile1_cover.Visible = true;
                guile1.Visible = false;
                guile2_cover.Visible = true;
                guile2.Visible = false;
                vega1_cover.Visible = true;
                vega1.Visible = false;
                vega2_cover.Visible = true;
                vega2.Visible = false;
                ken1_cover.Visible = true;
                ken1.Visible = false;
                ken2_cover.Visible = true;
                ken2.Visible = false;
            }
        }



        private void chunli1_cover_Click(object sender, EventArgs e)
        {
            chunli1_cover.Visible = false;
            chunli1.Visible = true;

            if (chunli1.Visible == true && chunli2.Visible == true)
            {
                label2.Text = "Exito";
            }
            else
            if (chunli1.Visible == true && ryu1.Visible == true || ryu2.Visible == true || sagat1.Visible == true || sagat2.Visible == true
                || guile1.Visible == true || guile2.Visible == true || vega1.Visible == true || vega2.Visible == true || ken1.Visible == true
                || ken2.Visible == true)
            {
                label2.Text = "No coincide";
                ryu1_cover.Visible = true;
                ryu1.Visible = false;
                ryu2_cover.Visible = true;
                ryu2.Visible = false;
                chunli1_cover.Visible = true;
                chunli1.Visible = false;
                sagat1_cover.Visible = true;
                sagat1.Visible = false;
                sagat2_cover.Visible = true;
                sagat2.Visible = false;
                guile1_cover.Visible = true;
                guile1.Visible = false;
                guile2_cover.Visible = true;
                guile2.Visible = false;
                vega1_cover.Visible = true;
                vega1.Visible = false;
                vega2_cover.Visible = true;
                vega2.Visible = false;
                ken1_cover.Visible = true;
                ken1.Visible = false;
                ken2_cover.Visible = true;
                ken2.Visible = false;
            }
        }

        private void chunli2_cover_Click(object sender, EventArgs e)
        {
            chunli2_cover.Visible = false;
            chunli2.Visible = true;

            if (chunli2.Visible == true && chunli1.Visible == true)
            {
                label2.Text = "Exito";
            }
            else
            if (chunli2.Visible == true && ryu1.Visible == true || ryu2.Visible == true || sagat1.Visible == true || sagat2.Visible == true
                || guile1.Visible == true || guile2.Visible == true || vega1.Visible == true || vega2.Visible == true || ken1.Visible == true
                || ken2.Visible == true)
            {
                label2.Text = "No coincide";
                ryu1_cover.Visible = true;
                ryu1.Visible = false;
                ryu2_cover.Visible = true;
                ryu2.Visible = false;
                chunli2_cover.Visible = true;
                chunli2.Visible = false;
                sagat1_cover.Visible = true;
                sagat1.Visible = false;
                sagat2_cover.Visible = true;
                sagat2.Visible = false;
                guile1_cover.Visible = true;
                guile1.Visible = false;
                guile2_cover.Visible = true;
                guile2.Visible = false;
                vega1_cover.Visible = true;
                vega1.Visible = false;
                vega2_cover.Visible = true;
                vega2.Visible = false;
                ken1_cover.Visible = true;
                ken1.Visible = false;
                ken2_cover.Visible = true;
                ken2.Visible = false;
            }

        }


        private void sagat1_cover_Click(object sender, EventArgs e)
        {
            sagat1_cover.Visible = false;
            sagat1.Visible = true;

            if (sagat1.Visible == true && sagat2.Visible == true)
            {
                label2.Text = "Exito";
            }
            else
            if (sagat1.Visible == true && ryu1.Visible == true || ryu2.Visible == true || chunli1.Visible == true || chunli2.Visible == true
                || guile1.Visible == true || guile2.Visible == true || vega1.Visible == true || vega2.Visible == true || ken1.Visible == true
                || ken2.Visible == true)
            {
                label2.Text = "No coincide";
                ryu1_cover.Visible = true;
                ryu1.Visible = false;
                ryu2_cover.Visible = true;
                ryu2.Visible = false;
                chunli1_cover.Visible = true;
                chunli1.Visible = false;
                chunli2_cover.Visible = true;
                chunli2.Visible = false;
                sagat1_cover.Visible = true;
                sagat1.Visible = false;
                guile1_cover.Visible = true;
                guile1.Visible = false;
                guile2_cover.Visible = true;
                guile2.Visible = false;
                vega1_cover.Visible = true;
                vega1.Visible = false;
                vega2_cover.Visible = true;
                vega2.Visible = false;
                ken1_cover.Visible = true;
                ken1.Visible = false;
                ken2_cover.Visible = true;
                ken2.Visible = false;
            }

        }

        private void sagat2_cover_Click(object sender, EventArgs e)
        {
            sagat2_cover.Visible = false;
            sagat2.Visible = true;

            if (sagat2.Visible == true && sagat1.Visible == true)
            {
                label2.Text = "Exito";
            }
            else
            if (sagat2.Visible == true && ryu1.Visible == true || ryu2.Visible == true || chunli1.Visible == true || chunli2.Visible == true
               || guile1.Visible == true || guile2.Visible == true || vega1.Visible == true || vega2.Visible == true || ken1.Visible == true
               || ken2.Visible == true)
            {
                label2.Text = "No coincide";
                ryu1_cover.Visible = true;
                ryu1.Visible = false;
                ryu2_cover.Visible = true;
                ryu2.Visible = false;
                chunli1_cover.Visible = true;
                chunli1.Visible = false;
                chunli2_cover.Visible = true;
                chunli2.Visible = false;
                sagat2_cover.Visible = true;
                sagat2.Visible = false;
                guile1_cover.Visible = true;
                guile1.Visible = false;
                guile2_cover.Visible = true;
                guile2.Visible = false;
                vega1_cover.Visible = true;
                vega1.Visible = false;
                vega2_cover.Visible = true;
                vega2.Visible = false;
                ken1_cover.Visible = true;
                ken1.Visible = false;
                ken2_cover.Visible = true;
                ken2.Visible = false;
            }
        }

        private void guile1_cover_Click(object sender, EventArgs e)
        {
            guile1_cover.Visible = false;
            guile1.Visible = true;

            if (guile1.Visible == true && guile2.Visible == true)
            {
                label2.Text = "Exito";
            }
            else
            if (guile1.Visible == true && ryu1.Visible == true || ryu2.Visible == true || chunli1.Visible == true || chunli2.Visible == true
               || sagat1.Visible == true || sagat2.Visible == true || vega1.Visible == true || vega2.Visible == true || ken1.Visible == true
               || ken2.Visible == true)
            {
                label2.Text = "No coincide";
                ryu1_cover.Visible = true;
                ryu1.Visible = false;
                ryu2_cover.Visible = true;
                ryu2.Visible = false;
                chunli1_cover.Visible = true;
                chunli1.Visible = false;
                chunli2_cover.Visible = true;
                chunli2.Visible = false;
                sagat1_cover.Visible = true;
                sagat1.Visible = false;
                sagat2_cover.Visible = true;
                sagat2.Visible = false;
                guile1_cover.Visible = true;
                guile1.Visible = false;
                vega1_cover.Visible = true;
                vega1.Visible = false;
                vega2_cover.Visible = true;
                vega2.Visible = false;
                ken1_cover.Visible = true;
                ken1.Visible = false;
                ken2_cover.Visible = true;
                ken2.Visible = false;
            }

        }

        private void guile2_cover_Click(object sender, EventArgs e)
        {
            guile2_cover.Visible = false;
            guile2.Visible = true;

            if (guile2.Visible == true && guile1.Visible == true)
            {
                label2.Text = "Exito";
            }
            else
            if (guile2.Visible == true && ryu1.Visible == true || ryu2.Visible == true || chunli1.Visible == true || chunli2.Visible == true
               || sagat1.Visible == true || sagat2.Visible == true || vega1.Visible == true || vega2.Visible == true || ken1.Visible == true
               || ken2.Visible == true)
            {
                label2.Text = "No coincide";
                ryu1_cover.Visible = true;
                ryu1.Visible = false;
                ryu2_cover.Visible = true;
                ryu2.Visible = false;
                chunli1_cover.Visible = true;
                chunli1.Visible = false;
                chunli2_cover.Visible = true;
                chunli2.Visible = false;
                sagat1_cover.Visible = true;
                sagat1.Visible = false;
                sagat2_cover.Visible = true;
                sagat2.Visible = false;
                guile2_cover.Visible = true;
                guile2.Visible = false;
                vega1_cover.Visible = true;
                vega1.Visible = false;
                vega2_cover.Visible = true;
                vega2.Visible = false;
                ken1_cover.Visible = true;
                ken1.Visible = false;
                ken2_cover.Visible = true;
                ken2.Visible = false;
            }
        }

        private void vega1_cover_Click(object sender, EventArgs e)
        {
            vega1_cover.Visible = false;
            vega1.Visible = true;

            if (vega1.Visible == true && vega2.Visible == true)
            {
                label2.Text = "Exito";
            }
            else
            if (vega1.Visible == true && ryu1.Visible == true || ryu2.Visible == true || chunli1.Visible == true || chunli2.Visible == true
               || sagat1.Visible == true || sagat2.Visible == true || guile1.Visible == true || guile2.Visible == true || ken1.Visible == true
               || ken2.Visible == true)
            {
                label2.Text = "No coincide";
                ryu1_cover.Visible = true;
                ryu1.Visible = false;
                ryu2_cover.Visible = true;
                ryu2.Visible = false;
                chunli1_cover.Visible = true;
                chunli1.Visible = false;
                chunli2_cover.Visible = true;
                chunli2.Visible = false;
                sagat1_cover.Visible = true;
                sagat1.Visible = false;
                sagat2_cover.Visible = true;
                sagat2.Visible = false;
                guile1_cover.Visible = true;
                guile1.Visible = false;
                guile2_cover.Visible = true;
                guile2.Visible = false;
                vega1_cover.Visible = true;
                vega1.Visible = false;
                ken1_cover.Visible = true;
                ken1.Visible = false;
                ken2_cover.Visible = true;
                ken2.Visible = false;
            }
        }

        private void vega2_cover_Click(object sender, EventArgs e)
        {
            vega2_cover.Visible = false;
            vega2.Visible = true;

            if (vega2.Visible == true && vega1.Visible == true)
            {
                label2.Text = "Exito";
            }
            else
            if(vega2.Visible == true && ryu1.Visible == true || ryu2.Visible == true || chunli1.Visible == true || chunli2.Visible == true
              || sagat1.Visible == true || sagat2.Visible == true || guile1.Visible == true || guile2.Visible == true || ken1.Visible == true
              || ken2.Visible == true)
            {
                label2.Text = "No coincide";
                ryu1_cover.Visible = true;
                ryu1.Visible = false;
                ryu2_cover.Visible = true;
                ryu2.Visible = false;
                chunli1_cover.Visible = true;
                chunli1.Visible = false;
                chunli2_cover.Visible = true;
                chunli2.Visible = false;
                sagat1_cover.Visible = true;
                sagat1.Visible = false;
                sagat2_cover.Visible = true;
                sagat2.Visible = false;
                guile1_cover.Visible = true;
                guile1.Visible = false;
                guile2_cover.Visible = true;
                guile2.Visible = false;
                vega2_cover.Visible = true;
                vega2.Visible = false;
                ken1_cover.Visible = true;
                ken1.Visible = false;
                ken2_cover.Visible = true;
                ken2.Visible = false;
            }
        }

        private void ken1_cover_Click(object sender, EventArgs e)
        {
            ken1_cover.Visible = false;
            ken1.Visible = true;

            if (ken1.Visible == true && ken2.Visible == true)
            {
                label2.Text = "Exito";
            }
            else
            if (ken1.Visible == true && ryu1.Visible == true || ryu2.Visible == true || chunli1.Visible == true || chunli2.Visible == true
             || sagat1.Visible == true || sagat2.Visible == true || guile1.Visible == true || guile2.Visible == true || vega1.Visible == true
             || vega2.Visible == true)
            {
                label2.Text = "No coincide";
                ryu1_cover.Visible = true;
                ryu1.Visible = false;
                ryu2_cover.Visible = true;
                ryu2.Visible = false;
                chunli1_cover.Visible = true;
                chunli1.Visible = false;
                chunli2_cover.Visible = true;
                chunli2.Visible = false;
                sagat1_cover.Visible = true;
                sagat1.Visible = false;
                sagat2_cover.Visible = true;
                sagat2.Visible = false;
                guile1_cover.Visible = true;
                guile1.Visible = false;
                guile2_cover.Visible = true;
                guile2.Visible = false;
                vega1_cover.Visible = true;
                vega1.Visible = false;
                vega2_cover.Visible = true;
                vega2.Visible = false;
                ken1_cover.Visible = true;
                ken1.Visible = false;
            }
        }

        private void ken2_cover_Click(object sender, EventArgs e)
        {
            ken2_cover.Visible = false;
            ken2.Visible = true;

            if (ken2.Visible == true && ken1.Visible == true)
            {
                label2.Text = "Exito";
            }
            else
            if(ken2.Visible == true && ryu1.Visible == true || ryu2.Visible == true || chunli1.Visible == true || chunli2.Visible == true
            || sagat1.Visible == true || sagat2.Visible == true || guile1.Visible == true || guile2.Visible == true || vega1.Visible == true
            || vega2.Visible == true)
            {
                label2.Text = "No coincide";
                ryu1_cover.Visible = true;
                ryu1.Visible = false;
                ryu2_cover.Visible = true;
                ryu2.Visible = false;
                chunli1_cover.Visible = true;
                chunli1.Visible = false;
                chunli2_cover.Visible = true;
                chunli2.Visible = false;
                sagat1_cover.Visible = true;
                sagat1.Visible = false;
                sagat2_cover.Visible = true;
                sagat2.Visible = false;
                guile1_cover.Visible = true;
                guile1.Visible = false;
                guile2_cover.Visible = true;
                guile2.Visible = false;
                vega1_cover.Visible = true;
                vega1.Visible = false;
                vega2_cover.Visible = true;
                vega2.Visible = false;
                ken2_cover.Visible = true;
                ken2.Visible = false;
            }


        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ryu1_cover.Visible = true;
            ryu1.Visible = false;
            ryu2_cover.Visible = true;
            ryu2.Visible = false;
            chunli1_cover.Visible = true;
            chunli1.Visible = false;
            chunli2_cover.Visible = true;
            chunli2.Visible = false;
            sagat1_cover.Visible = true;
            sagat1.Visible = false;
            sagat2_cover.Visible = true;
            sagat2.Visible = false;
            guile1_cover.Visible = true;
            guile1.Visible = false;
            guile2_cover.Visible = true;
            guile2.Visible = false;
            vega1_cover.Visible = true;
            vega1.Visible = false;
            vega2_cover.Visible = true;
            vega2.Visible = false;
            ken1_cover.Visible = true;
            ken1.Visible = false;
            ken2_cover.Visible = true;
            ken2.Visible = false;
            label2.Text = "";
        }
    }
}
