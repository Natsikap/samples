using System;
using System.Windows;
using testingresourcefilesusage;

namespace testingresourcefileusage.desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            var finalFileContents = ResourceFileUsagehelper.GetFileContents("iamasampleembeddedresourcetextfile.TXT");
            Console.Write(finalFileContents);
            
        }
    }
}
