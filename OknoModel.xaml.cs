﻿using System;
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
using System.Windows.Shapes;

namespace NET_ININ4_PR2._2_z5
{
    /// <summary>
    /// Interaction logic for OknoModel.xaml
    /// </summary>
    public partial class OknoModel : Window
    {
        public OknoModel(System.Xml.XmlElement model)
        {
            DataContext = model;
            Console.WriteLine(model);
            InitializeComponent();
        }
    }
}