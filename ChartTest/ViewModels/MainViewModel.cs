using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ChartTest
{
  public class MainViewModel : BaseViewModel
  {
    private TrendViewModel _trendViewModel = new TrendViewModel();
    private HomeViewModel _homeViewModel = new HomeViewModel();

    private BaseViewModel _viewModel;

    public BaseViewModel ViewModel
    {
      get { return _viewModel; }
      set { SetProperty(ref _viewModel, value); }
    }

    public ICommand GoToHome { get; set; }
    public ICommand GoToTrends { get; set; }

    public MainViewModel()
    {
      ViewModel = _homeViewModel;

      GoToHome = new RelayCommand(ExecuteGoToHome);
      GoToTrends = new RelayCommand(ExecuteGoToTrends);
    }

    private void ExecuteGoToHome(object parameter)
    {
      ViewModel = _homeViewModel;
    }

    private void ExecuteGoToTrends(object parameter)
    {
      ViewModel = _trendViewModel;
    }
  }
}
