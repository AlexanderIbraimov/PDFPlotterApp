﻿using CropPDF.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CropPDF.View
{
    /// <summary>
    /// Interaction logic for ExpectationsControl.xaml
    /// </summary>
    public partial class ExpectationsControl : UserControl
    {
        public ExpectationsViewModel ViewModel;
        public ExpectationsControl()
        {
            InitializeComponent();
            ViewModel = new ExpectationsViewModel();
            DataContext = ViewModel;
        }
    }
}
