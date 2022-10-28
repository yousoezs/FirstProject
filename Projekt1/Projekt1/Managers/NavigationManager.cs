using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Projekt1.Managers;

public class NavigationManager
{
	private ObservableObject _currentViewModel;

	public ObservableObject CurrentViewModel
	{
		get { return _currentViewModel; }
        set
        {
            _currentViewModel = value;
            OnCurrentViewModelChanged();
        }
    }

    public void OnCurrentViewModelChanged()
    {
        CurrentViewModelChanged?.Invoke();
    }

    public event Action CurrentViewModelChanged;
}
