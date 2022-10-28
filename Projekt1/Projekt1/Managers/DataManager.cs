using Projekt1.Models;

namespace Projekt1.Managers;

public class DataManager
{
    private DataModel _cardData = new DataModel();

    public DataModel CardData => _cardData;
}