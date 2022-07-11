using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SimpleMvvm;

public class MainViewModel : ViewModelBase
{
	private int count = 0;
	private string label = "";

	public string Label
	{
		get { return label; }
		set { SetPropertyChanged(ref label, value); }
	}

	public MainViewModel()
	{
		Label = "Clicked 0 times";
	}

	public void ButtonClicked()
	{
		count++;
		Label = $"Clicked {count} times";
    }
}

public class ViewModelBase : INotifyPropertyChanged
{
	public event PropertyChangedEventHandler? PropertyChanged;

	public void SetPropertyChanged<T>(ref T param, T rawParam, [CallerMemberName] string? propertyName = null)
	{
		param = rawParam;
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
