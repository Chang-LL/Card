﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card
{
    public partial class CardSolveForm : Form
    {
        public CardSolveForm()
        {
            InitializeComponent();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            FormNewCard formNewCard = new FormNewCard();
            formNewCard.ShowDialog();
        }
    }
}
