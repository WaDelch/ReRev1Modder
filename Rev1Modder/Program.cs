using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/* ####################################################
 * ### Modding tool for Resident Evil Revelations 1 ###
 * ### Author: WaDelch                              ###
 * ####################################################
 */

namespace Rev1Modder
{
    internal static class Program
    {

        /// <summary>
        /// Main entry point.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_StartFrame());
        }

        public static IEnumerable<TControl> GetChildControls<TControl>(this Control control) where TControl : Control
        {
            var children = (control.Controls != null) ? control.Controls.OfType<TControl>() : Enumerable.Empty<TControl>();
            return children.SelectMany(c => GetChildControls<TControl>(c)).Concat(children);
        }
    }
}
