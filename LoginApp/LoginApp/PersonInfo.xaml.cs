﻿using LoginApp.Data;
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

namespace LoginApp
{
    /// <summary>
    /// Interaction logic for PersonInfo.xaml
    /// </summary>
    public partial class PersonInfo : UserControl
    {
        public PersonInfo()
        {
            InitializeComponent();
            this.DataContext = person; //necessary step
        }

        //details of the person
        Person person = new Person
        {
            Name = "ktk",
            Age = 20

        };

    }
}
