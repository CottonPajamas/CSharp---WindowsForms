using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_UI_1._3a
{
    static class MainFunction
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DragonCatching3());
        }

        /*Some notes:
         * In Form1, it generates itself everytime you click 'reset'.
         * In My_Second_Form, it generates a message when the program launches and say a goodbye message when it closes.
         * In DragonCatching1, we just program a pic to move randomly with each click.
         *         ~Useful cos the code will be reused for subsequent exercises.
         *         ~Please note, that we directly input the code to change the any variable/aspects of the button.
         * In DragonHunter, if you click the dragon then it will change and move randomly. 
         * In DragonCatching2, if you move your mouse over then the pic will auto move randomly.
         * In DragonCatching3, we make the pic dissapear (mouse over) and appear (click) and 
         *          grow in size if double click. Need to set as "StretchImage" for it to be strectable.
        */
    }
}
