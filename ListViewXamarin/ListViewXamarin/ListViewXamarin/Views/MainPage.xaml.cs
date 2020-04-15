using Syncfusion.DataSource;
using Syncfusion.ListView.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewXamarin
{
    public partial class MainPage : ContentPage
    {
        #region Constructor
        public MainPage()
        {
            InitializeComponent();
            this.SizeChanged += MainPage_SizeChanged;
        }

        #endregion

        #region Private methods

        private void MainPage_SizeChanged(object sender, EventArgs e)
        {
            DefineFontSize("FontSizeLarge", 38, 30);
            DefineFontSize("FontSizeBody", 48, 42);
            DefineFontSize("FontSizeSmall", 52, 48);
        }

        private void DefineFontSize(string resourceKey, int charsInLine, int linesInPage)
        {
            var size1 = Math.Round(Width / charsInLine) * 2;
            var size2 = Math.Round(Height / linesInPage);
            App.Current.Resources[resourceKey] = Math.Min(size1, size2);
        }
        #endregion
    }

}
