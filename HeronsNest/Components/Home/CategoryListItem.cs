﻿using HeronsNest.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeronsNest.Components.Home
{
    public partial class CategoryListItem : UserControl
    {
        public CategoryListItem()
        {
            InitializeComponent();
        }

        public void RenderInformation(Book book)
        {
            authorInformationlabel.Text = book.Author;
            bookTitleLabel.Text = book.Title;
        }
    }
}
