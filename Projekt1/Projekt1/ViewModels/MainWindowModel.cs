using System.Reflection;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Projekt1.Managers;
using Projekt1.Models;

namespace Projekt1.ViewModels;

public class MainWindowModel : ObservableObject
{
    #region Fields

    private DataModel _dataModel;
    private NavigationManager _navigationManager;

    #endregion

    #region Prop

    private ObservableObject CurrentViewModel => _navigationManager.CurrentViewModel;

    #endregion

    #region Commands

    public IRelayCommand NavigateUnoCommand { get; }

    public IRelayCommand NavigatePokerCommand { get; }

    public IRelayCommand NavigateGameCommand { get; }

    #endregion
    public MainWindowModel(NavigationManager navigationManager)
    {
        _navigationManager = navigationManager;

        _navigationManager.CurrentViewModelChanged += CurrentViewModelChanged;

        NavigateUnoCommand = new RelayCommand(() => _navigationManager.CurrentViewModel = new UnoViewModel(navigationManager));
    }

    private void CurrentViewModelChanged()
    {
        OnPropertyChanged(nameof(CurrentViewModel));
    }

}