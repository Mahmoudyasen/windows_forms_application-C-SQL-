﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymProject99
{
    public partial class CRUD : Form
    {
        public CRUD()
        {
            InitializeComponent();
        }

        private void CRUD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gYMDataSet.GMembers' table. You can move, or remove it, as needed.
            this.gMembersTableAdapter.Fill(this.gYMDataSet.GMembers);

        }
    }
}
