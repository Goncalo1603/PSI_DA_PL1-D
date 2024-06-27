<<<<<<< Updated upstream
﻿using Projeto.modelos;
using Projeto.view;
using System;
=======
﻿using System;
>>>>>>> Stashed changes
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< Updated upstream
            Application.Run(new pratos());
=======
            Application.Run(new Form1());
>>>>>>> Stashed changes
        }
    }
}
