using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;

namespace ChartTest
{
  public class TrendViewModel : BaseViewModel
  {

    public SeriesCollection Series { get; set; } = new SeriesCollection
    {
      new LineSeries
      {
          Title = "Series 1",
          Values = new ChartValues<double> { 4, 6, 5, 2 ,4 }
      }
    };

    private AxesCollection _yAxes;

    public AxesCollection YAxes
    {
      get { return _yAxes; }
      set { _yAxes = value; OnPropertyChanged(); }
    }

    public TrendViewModel()
    {
      YAxes = new AxesCollection
      {
        new Axis { Title = "Y Axis 1", Foreground = Brushes.Gray },
        new Axis { Title = "Y Axis 2", Foreground = Brushes.Red },
        new Axis { Title = "Y Axis 3", Foreground = Brushes.Brown }
      };
    }
  }
}
