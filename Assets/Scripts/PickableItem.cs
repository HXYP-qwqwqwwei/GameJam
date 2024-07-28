using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickableItem : SceneItem
{
    private Image _image;
    public ItemType itemType;
    public GameInstance instance;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Image>().sprite = instance.gameData.GetItem(itemType).sprite;
    }

    void OnClick()
    {
        instance.inventory.AddItem(itemType);
        instance.InventoryView.UpdateInventory();
        Destroy(gameObject);
    }
}
