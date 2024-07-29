using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class InventoryView : MonoBehaviour
{
    private List<GameObject> _imageObjects;
    private GameObject _content;
    private RectTransform _contentTransform;
    public GameObject invSlotPrefab;
    public Inventory inventory;

    public int selectedSlotIndex = -1;
    // private readonly List<GameObject> _invSlots = new();
    //
    private readonly List<GameObject> availableSlots = new ();
    
    // Start is called before the first frame update
    void Start()
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
            availableSlots.Add(invSlot);
        }
        
        UpdateInventory();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateInventory()
    {
        for (int i = inventory.Count; i < 8; ++i)
        {
            availableSlots[i].SetActive(false);
        }
        
        const float deltaHeight = 200.0f;
        float contentHeight = deltaHeight * inventory.Count;
        _contentTransform.sizeDelta = new Vector2(1, contentHeight);
        
        float heightOffset = -contentHeight + deltaHeight / 2;
        for (int i = 0; i < inventory.Count; ++i)
        {
            GameObject invSlot = availableSlots[i];
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
