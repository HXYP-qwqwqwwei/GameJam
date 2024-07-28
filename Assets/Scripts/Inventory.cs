using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(fileName = "Save", menuName = "ScriptableObjects/Inventory", order = 1)]
public class Inventory : ScriptableObject
{
    public GameData gameData;
    
    [SerializeField]
    private int selectedItem = -1;
    
    [SerializeField]
    private List<GameItem> items = new ();

    public void AddItem(ItemType itemType)
    {
        items.Add(gameData.GetItem(itemType));
    }

    public GameItem GetItem(int index)
    {
        return index >= items.Count ? gameData.GetItem(ItemType.Air) : items[index];
    }

    public int Count => items.Count;

    public int SelectedSlotIndex
    {
        get => selectedItem;
        set => selectedItem = value;
    }

    public ItemType SelectedItem()
    {
        return selectedItem == -1 ? ItemType.Air : items[selectedItem].type;
    }

    public void Clear()
    {
        items.Clear();
    }
}
