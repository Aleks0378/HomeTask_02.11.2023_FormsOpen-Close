﻿using ComputerShop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerShop
{
    public partial class DetailsForm : Form
    {
        public DetailsForm(Product[] products)
        {
            InitializeComponent();
            detailsDataGridView.DataSource = products;
        }
    }
}
