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

namespace HelpTextControl.HelpText
{
    /// <summary>
    /// Interaction logic for HelpTextUC.xaml
    /// </summary>
    public partial class HelpTextUC : UserControl
    {
        public HelpTextUC()
        {
            InitializeComponent();
            Loaded += HelpTextControl_Loaded;
        }

        private void HelpTextControl_Loaded(object sender, RoutedEventArgs e)
        {
            TooltipTxt.Text = ToolTipText;
            Tooltippop.HorizontalOffset = ToolTipHorizontalOffset;
            Tooltippop.VerticalOffset = ToolTipVerticalOffset;
            TooltipStackPanel.Width = ToolTipWidth;
        }

        public string ToolTipText
        {
            get { return (string)GetValue(ToolTipTextProperty); }
            set { SetValue(ToolTipTextProperty, value); }
        }

        public double ToolTipHorizontalOffset
        {
            get { return (double)GetValue(ToolTipHorizontalOffsetProperty); }
            set { SetValue(ToolTipHorizontalOffsetProperty, value); }
        }

        public double ToolTipVerticalOffset
        {
            get { return (double)GetValue(ToolTipVerticalOffsetProperty); }
            set { SetValue(ToolTipVerticalOffsetProperty, value); }
        }

        public double ToolTipWidth
        {
            get { return (double)GetValue(ToolTipWidthProperty); }
            set { SetValue(ToolTipWidthProperty, value); }
        }

        static FrameworkPropertyMetadata toolTipTextMetaData = new FrameworkPropertyMetadata("", FrameworkPropertyMetadataOptions.None, null);
        public static readonly DependencyProperty ToolTipTextProperty = DependencyProperty.Register("ToolTipText", typeof(string), typeof(HelpTextUC), toolTipTextMetaData, null);

        static FrameworkPropertyMetadata toolTipHorizontalOffsetMetaData = new FrameworkPropertyMetadata(Double.Parse("200"), FrameworkPropertyMetadataOptions.AffectsMeasure, null);
        public static readonly DependencyProperty ToolTipHorizontalOffsetProperty = DependencyProperty.Register("ToolTipHorizontalOffset", typeof(double), typeof(HelpTextUC), toolTipHorizontalOffsetMetaData, null);

        static FrameworkPropertyMetadata toolTipVerticalOffsetMetaData = new FrameworkPropertyMetadata(Double.Parse("100"), FrameworkPropertyMetadataOptions.AffectsMeasure, null);
        public static readonly DependencyProperty ToolTipVerticalOffsetProperty = DependencyProperty.Register("ToolTipVerticalOffset", typeof(double), typeof(HelpTextUC), toolTipVerticalOffsetMetaData, null);

        static FrameworkPropertyMetadata toolTipWidthMetaData = new FrameworkPropertyMetadata(Double.Parse("300"), FrameworkPropertyMetadataOptions.AffectsMeasure, null);
        public static readonly DependencyProperty ToolTipWidthProperty = DependencyProperty.Register("ToolTipWidth", typeof(double), typeof(HelpTextUC), toolTipWidthMetaData, null);

        private void HelpIcon_MouseEnter(object sender, MouseEventArgs e)
        {
            Tooltippop.Visibility = Visibility.Visible;
            Tooltippop.IsOpen = true;
        }

        private void HelpIcon_MouseLeave(object sender, MouseEventArgs e)
        {
            Tooltippop.Visibility = Visibility.Hidden;
            Tooltippop.IsOpen = false;
        }
    }
}
