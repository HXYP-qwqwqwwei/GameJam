using System.Collections.Generic;
using UnityEngine;

public class InventoryView : MonoBehaviour
{
    public GameObject invSlotPrefab;
    public Inventory inventory;

    public int selectedSlotIndex = -1;

    private List<GameObject> _imageObjects;
    private GameObject _content;
    private RectTransform _contentTransform;
    private readonly List<GameObject> _availableSlots = new ();
    
    public void InitInvSlots()
    {
        GameObject viewport = transform.GetChild(0).gameObject;
        _content = viewport.transform.GetChild(0).gameObject;
        _contentTransform = _content.GetComponent<RectTransform>();
        
        for (int i = 0; i < 8; ++i)
        {
            GameObject invSlot = Instantiate(invSlotPrefab, new Vector3(), new Quaternion());
            invSlot.GetComponent<ItemSlot>().SetSlotIndex(i);
            invSlot.transform.SetParent(_content.transform, false);
            invSlot.SetActive(false);
            _availableSlots.Add(invSlot);
        }
        
        UpdateInventory();

    }

    public void UpdateInventory()
    {
        for (int i = inventory.Count; i < 8; ++i)
        {
            _availableSlots[i].SetActive(false);
        }
        
        const float deltaHeight = 200.0f;
        float contentHeight = deltaHeight * inventory.Count;
        _contentTransform.sizeDelta = new Vector2(1, contentHeight);
        
        float heightOffset = -contentHeight + deltaHeight / 2;
        for (int i = 0; i < inventory.Count; ++i)
        {
            GameObject invSlot = _availableSlots[i];
            invSlot.transform.SetParent(_content.transform, false);
            invSlot.transform.SetLocalPositionAndRotation(new Vector3(100, heightOffset, 0), new Quaternion());
            ItemSlot slot = invSlot.GetComponent<ItemSlot>();
            slot.SetSlotIndex(i);
            if (i == selectedSlotIndex)
            {
                slot.SetColor(new Color(.5f, .5f, 0.5f));
            }
            else
            {
                slot.SetColor(new Color(1.0f, 1.0f, 1.0f));
            }
            heightOffset += deltaHeight;
            invSlot.SetActive(true);
        }
    }
}
