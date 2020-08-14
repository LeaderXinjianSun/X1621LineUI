using MahApps.Metro.Controls;
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
using System.Windows.Shapes;

namespace X1621LineUI.Views
{
    /// <summary>
    /// AlarmWindow.xaml 的交互逻辑
    /// </summary>
    public partial class AlarmWindow : MetroWindow
    {
        public AlarmWindow()
        {
            InitializeComponent();
        }
        public bool QuitAlarmWindow
        {
            get { return (bool)GetValue(QuitAlarmWindowProperty); }
            set { SetValue(QuitAlarmWindowProperty, value); }
        }

        // Using a DependencyProperty as the backing store for QuitAlarmWindow.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty QuitAlarmWindowProperty =
            DependencyProperty.Register("QuitAlarmWindow", typeof(bool), typeof(AlarmWindow), new PropertyMetadata(

                new PropertyChangedCallback((d, e) =>
                {
                    var mAlarmWindow = d as AlarmWindow;
                    if (mAlarmWindow.HasShow)
                    {
                        mAlarmWindow.HasShow = false;
                        mAlarmWindow.Close();
                        mAlarmWindow = null;
                    }
                })
                ));




        public bool HasShow { get; set; }
        protected override void OnClosed(EventArgs e)
        {
            HasShow = false;
            base.OnClosed(e);
        }
    }
}
