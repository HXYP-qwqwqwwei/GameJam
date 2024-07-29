using UnityEngine;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class InteractableItem: SceneItem
{
    public GameInstance gameInstance;
    public ItemType interactItemType;
    
    // change sprite
    public Sprite originalSprite;
    public Sprite interactiveSprite;
    
    // item spawning
    public ItemType spawnItem = ItemType.None;
    public GameObject pickableItemPrefab;
    public Vector3 spawnPosition;
    public Vector3 spawnRotation;

    private bool _isInteracted = false;

    private void Start()
    {
        if (originalSprite == null)
        {
            GetComponent<Image>().color = new Color(1, 1, 1, 0);
        }
        GetComponent<Image>().sprite = originalSprite;
    }

    public override void OnClick()
    {
        if (!_isInteracted && (interactItemType == ItemType.None || gameInstance.inventory.SelectedItem() == interactItemType))
        {

            if (interactiveSprite != null)
            {
                Image image = GetComponent<Image>();
                image.color = Color.white;
                image.sprite = interactiveSprite;
            }
            if (spawnItem != ItemType.None)
            {
                GameObject pickableItemIns = Instantiate(pickableItemPrefab, spawnPosition, Quaternion.Euler(spawnRotation));
                pickableItemIns.transform.SetParent(transform, false);
                PickableItem pickableItem = pickableItemIns.GetComponent<PickableItem>();
                pickableItem.instance = gameInstance;
                pickableItem.itemType = spawnItem;
                _isInteracted = true;
                gameInstance.inventory.SelectedSlotIndex = -1;
            }
        }
    }
}
