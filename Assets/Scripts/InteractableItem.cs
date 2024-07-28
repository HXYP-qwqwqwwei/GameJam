using System;
using UnityEngine;
using UnityEngine.UI;

public class InteractableItem: SceneItem
{
    public GameInstance gameInstance;
    public ItemType interactItemType;
    public Sprite originalSprite;
    public Sprite interactiveSprite;

    private void Start()
    {
        GetComponent<Image>().sprite = originalSprite;
    }

    public override void OnClick()
    {
        if (gameInstance.inventory.SelectedItem() == interactItemType)
        {
            GetComponent<Image>().sprite = interactiveSprite;
        }
    }
}
