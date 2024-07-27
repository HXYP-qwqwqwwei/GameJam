using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Save", menuName = "ScriptableObjects/Save", order = 1)]
public class Inventory : ScriptableObject
{
    public GameData gameData;
    
    private List<GameItem> _items = new ();

    public void AddItem(ItemType itemType)
    {
        _items.Add(gameData.GetItem(itemType));
    }
}
