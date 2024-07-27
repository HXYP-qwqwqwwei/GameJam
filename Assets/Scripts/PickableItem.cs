using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickableItem : SceneItem
{
    private Image _image;
    public ItemType itemType;
    public Inventory inventory;
    public GameData gameData;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Image>().sprite = gameData.GetItem(itemType).sprite;
    }

    void OnClick()
    {
        inventory.AddItem(itemType);
        Destroy(gameObject);
    }
}
