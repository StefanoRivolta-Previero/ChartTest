using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ChartTest
{
  public abstract class BaseViewModel : INotifyPropertyChanged
  {

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName = null)
    {
      if (PropertyChanged != null)
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected virtual bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = "")
    {
      if (EqualityComparer<T>.Default.Equals(storage, value))
        return false;
      storage = value;
      this.OnPropertyChanged(propertyName);
      return true;
    }

  }
}
