﻿using MahApps.Metro.Controls;
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
using X1621LineUI.ViewModels;
using X1621LineUI.Views;

namespace X1621LineUI
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {           
            InitializeComponent();
            this.SetBinding(ShowYieldAdminControlWindowProperty, "ShowYieldAdminControlWindow");
            this.SetBinding(ShowAlarmWindowProperty, "ShowAlarmWindow");
            this.DataContext = new MainWindowViewModel();
        }
        public static YieldAdminControlWindow YieldAdminControlWindow = null;

        public static readonly DependencyProperty ShowYieldAdminControlWindowProperty =
            DependencyProperty.Register("ShowYieldAdminControlWindow", typeof(bool), typeof(MainWindow), new PropertyMetadata(
                new PropertyChangedCallback((d, e) =>
                {
                    if (YieldAdminControlWindow != null)
                    {
                        if (YieldAdminControlWindow.HasShow)
                            return;
                    }
                    var mMainWindow = d as MainWindow;
                    YieldAdminControlWindow = new YieldAdminControlWindow();// { Owner = this }.Show();
                    YieldAdminControlWindow.Owner = Application.Current.MainWindow;
                    YieldAdminControlWindow.DataContext = mMainWindow.DataContext;
                    YieldAdminControlWindow.SetBinding(YieldAdminControlWindow.QuitYieldAdminControlProperty, "QuitYieldAdminControl");
                    YieldAdminControlWindow.HasShow = true;
                    YieldAdminControlWindow.Show();
                })));
        public bool ShowYieldAdminControlWindow
        {
            get { return (bool)GetValue(ShowYieldAdminControlWindowProperty); }
            set { SetValue(ShowYieldAdminControlWindowProperty, value); }
        }

        public bool ShowAlarmWindow
        {
            get { return (bool)GetValue(ShowAlarmWindowProperty); }
            set { SetValue(ShowAlarmWindowProperty, value); }
        }
        public static AlarmWindow AlarmWindow = null;
        // Using a DependencyProperty as the backing store for ShowAlarmWindow.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ShowAlarmWindowProperty =
            DependencyProperty.Register("ShowAlarmWindow", typeof(bool), typeof(MainWindow), new PropertyMetadata(
                new PropertyChangedCallback((d, e) =>
                {
                    if (AlarmWindow != null)
                    {
                        if (AlarmWindow.HasShow)
                            return;
                    }
                    var mMainWindow = d as MainWindow;
                    AlarmWindow = new AlarmWindow();// { Owner = this }.Show();
                    AlarmWindow.Owner = Application.Current.MainWindow;
                    AlarmWindow.DataContext = mMainWindow.DataContext;
                    AlarmWindow.SetBinding(AlarmWindow.QuitAlarmWindowProperty, "QuitAlarmWindow");
                    AlarmWindow.HasShow = true;
                    AlarmWindow.Show();
                })
                ));

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
