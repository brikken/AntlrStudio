﻿using System;
using System.Collections.Generic;
using System.IO;
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
using Parser;

namespace AntlrStudio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //const string Path = @"test.txt";
            var Path = @"test-saslibnames.txt";
            txtCode.Text = File.ReadAllText(Path);
        }

        private void btnGetRules_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text = ParserHelper.GetRules(txtCode.Text);
        }
    }
}
