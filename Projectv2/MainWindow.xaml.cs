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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Projectv2
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
	

		public MainWindow()
		{
			InitializeComponent();
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{

		}

		private void btn3_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}

		private void btn1_Click(object sender, RoutedEventArgs e)
		{


			if (tbxpwd.Text == "" || tbxUName.Text == "")
			{
				MessageBox.Show("Entre UserName and Password");
			}
			else if (tbxUName.Text == "Admin" && tbxpwd.Text == "Password")
			{
			Items Obj = new Items();
				Obj.Show();
				this.Hide();
			}

		}

		private void btn2_Click(object sender, RoutedEventArgs e)
		{
			Billing Obj = new Billing();
			Obj.Show();
			this.Hide();
		}
	}


}
