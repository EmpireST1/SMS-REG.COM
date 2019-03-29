using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS_REG.COM
{
    public static class DBGRID
    {
        public static void SetNumber(this DataGridView Main, int i, string number)
        {
            Main.Invoke(new Action(() =>
            {
                Main.Rows[i].Cells[0].Value = number;
            }));
        }
        public static void SetCountry(this DataGridView Main, int i, string country)
        {
            Main.Invoke(new Action(() =>
            {
                Main.Rows[i].Cells[1].Value = country;
            }));
        }
        public static void SetCode(this DataGridView Main, int i, string code)
        {
            Main.Invoke(new Action(() =>
            {
                Main.Rows[i].Cells[2].Value = code;
            }));
        }
        public static void SetComent(this DataGridView Main, int i, string coment)
        {
            Main.Invoke(new Action(() =>
            {
                Main.Rows[i].Cells[3].Value = coment;
            }));
        }
        public static void SetTzid(this DataGridView Main, int i, string tzid)
        {
            Main.Invoke(new Action(() =>
            {
                Main.Rows[i].Cells[4].Value = tzid;
            }));
        }
    }
}
