﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Email_Service
{
    public partial class FORM_Main : Form
    {
        #region VARIABLES



        #endregion VARIABLES

        // ! ===== ===== ===== ===== =====

        #region FUNCTIONS



        #endregion FUNCTIONS

        // ! ===== ===== ===== ===== =====

        #region FORM

        public FORM_Main()
        {
            InitializeComponent();
        }

        private void PIC_avatar_MouseEnter(object sender, EventArgs e)
        {
            PIC_avatar.BackColor = Color.Khaki;
        }
        private void PIC_avatar_MouseLeave(object sender, EventArgs e)
        {
            PIC_avatar.BackColor = Color.LightCyan;
        }

        #endregion FORM
    }
}
