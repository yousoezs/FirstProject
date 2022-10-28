using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Projekt1.Managers;

namespace Projekt1.ViewModels;

public class UnoViewModel : ObservableObject
{
    private NavigationManager _navigationManager;
    private DataManager _dataManager;

    #region Commands
    public IRelayCommand GenerateCardCommand { get; }

    public IRelayCommand NavigateEscCommand { get; }
    #endregion

    #region Constructor

    public UnoViewModel(NavigationManager navigationManager)
    {
        _navigationManager = navigationManager;
        //_dataManager = dataManager;

        NavigateEscCommand =
            new RelayCommand(() => _navigationManager.CurrentViewModel = new MainWindowModel(navigationManager));
    }

    #endregion  
}