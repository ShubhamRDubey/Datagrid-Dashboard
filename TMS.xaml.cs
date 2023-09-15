using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Datagrid_Dashboard
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var converter = new BrushConverter();
            ObservableCollection<Report> reports =  new ObservableCollection<Report>();

            //Create DataGrid Report Info
            reports.Add(new Report
            {
                ID = 1,
                Letter = "F",
                Name = "First Quarter",
                Type = "BRSR",
                StartDate = "17 September",
                EndDate = "17 September",
                Status = "Upcoming",
                BgColor = (Brush)converter.ConvertFromString("#FF5733")
            });

            reports.Add(new Report
            {
                ID = 2,
                Letter = "S",
                Name = "Second Quarter",
                Type = "BRSR",
                StartDate = "19 September",
                EndDate = "19 September",
                Status = "Upcoming",
                BgColor = (Brush)converter.ConvertFromString("#45AAB8")
            });

            reports.Add(new Report
            {
                ID = 3,
                Letter = "A",
                Name = "Annual Sales",
                Type = "ASR",
                StartDate = "10 January",
                EndDate = "15 February",
                Status = "Completed",
                BgColor = (Brush)converter.ConvertFromString("#FFB833")
            });

            reports.Add(new Report
            {
                ID = 4,
                Letter = "M",
                Name = "Monthly Expenses",
                Type = "MRE",
                StartDate = "1 September",
                EndDate = "30 September",
                Status = "Upcoming",
                BgColor = (Brush)converter.ConvertFromString("#3D9970")
            });

            reports.Add(new Report
            {
                ID = 5,
                Letter = "Y",
                Name = "Year-End Review",
                Type = "YER",
                StartDate = "1 December",
                EndDate = "31 December",
                Status = "Planned",
                BgColor = (Brush)converter.ConvertFromString("#FF5733")
            });

            reports.Add(new Report
            {
                ID = 6,
                Letter = "Q",
                Name = "Quarterly Analysis",
                Type = "QAR",
                StartDate = "1 July",
                EndDate = "30 September",
                Status = "In Progress",
                BgColor = (Brush)converter.ConvertFromString("#45AAB8")
            });

            reports.Add(new Report
            {
                ID = 7,
                Letter = "B",
                Name = "Budget Proposal",
                Type = "BPR",
                StartDate = "1 February",
                EndDate = "28 February",
                Status = "Upcoming",
                BgColor = (Brush)converter.ConvertFromString("#FFB833")
            });

            reports.Add(new Report
            {
                ID = 8,
                Letter = "S",
                Name = "Sales Forecast",
                Type = "SFR",
                StartDate = "1 November",
                EndDate = "30 November",
                Status = "Planned",
                BgColor = (Brush)converter.ConvertFromString("#3D9970")
            });

            reports.Add(new Report
            {
                ID = 9,
                Letter = "Q",
                Name = "Quarterly Review",
                Type = "QUR",
                StartDate = "1 October",
                EndDate = "31 December",
                Status = "In Progress",
                BgColor = (Brush)converter.ConvertFromString("#FF5733")
            });

            reports.Add(new Report
            {
                ID = 10,
                Letter = "M",
                Name = "Marketing Campaign",
                Type = "MCA",
                StartDate = "1 March",
                EndDate = "30 June",
                Status = "Completed",
                BgColor = (Brush)converter.ConvertFromString("#45AAB8")
            });

            reports.Add(new Report
            {
                ID = 11,
                Letter = "P",
                Name = "Product Launch",
                Type = "PLN",
                StartDate = "1 July",
                EndDate = "31 July",
                Status = "Upcoming",
                BgColor = (Brush)converter.ConvertFromString("#FFB833")
            });

            reports.Add(new Report
            {
                ID = 12,
                Letter = "F",
                Name = "Financial Statement",
                Type = "FST",
                StartDate = "1 January",
                EndDate = "31 December",
                Status = "Planned",
                BgColor = (Brush)converter.ConvertFromString("#3D9970")
            });

            reports.Add(new Report
            {
                ID = 13,
                Letter = "Q",
                Name = "Quarterly Sales",
                Type = "QSR",
                StartDate = "1 April",
                EndDate = "30 June",
                Status = "In Progress",
                BgColor = (Brush)converter.ConvertFromString("#FF5733")
            });

            reports.Add(new Report
            {
                ID = 14,
                Letter = "P",
                Name = "Project Status",
                Type = "PSR",
                StartDate = "1 February",
                EndDate = "28 February",
                Status = "Completed",
                BgColor = (Brush)converter.ConvertFromString("#45AAB8")
            });

            reports.Add(new Report
            {
                ID = 15,
                Letter = "I",
                Name = "Inventory Report",
                Type = "IVR",
                StartDate = "1 November",
                EndDate = "30 November",
                Status = "Upcoming",
                BgColor = (Brush)converter.ConvertFromString("#FFB833")
            });

            reportsDataGrid.ItemsSource = reports;

        }
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
        
        private bool IsMaximised = false;
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
              if (IsMaximised)
                {
                    this.WindowState = WindowState.Normal;
                    this.Width = 1080;
                    this.Height = 100;

                    IsMaximised = false;
                }
              else
                {
                    this.WindowState = WindowState.Maximized;

                    IsMaximised = true;
                }
            }
        }
    }
}

    public class Report
    {
        public int ID { set; get; }
        public string Letter { set; get; }
        public string Name { set; get; }
        public string Type { set; get; }
        public string StartDate { set; get; }
        public string EndDate { set; get; }
        public string Status { set; get; }
        public Brush BgColor { set; get; }
    }
    