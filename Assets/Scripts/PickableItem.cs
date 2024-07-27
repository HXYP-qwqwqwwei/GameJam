using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableItem : SceneItem
{
    public ItemType itemType;
    public Inventory inventory;
    // Start is called before the first frame update

    void OnClick()
    {
        inventory.AddItem(itemType);
        Destroy(gameObject);
    }
}
