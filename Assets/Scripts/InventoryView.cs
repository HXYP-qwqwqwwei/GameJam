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

    private readonly List<GameObject> _invSlots = new();
    
    // Start is called before the first frame update
    void Start()
    {
        // GetComponent<ScrollView>().transform;
        GameObject viewport = transform.GetChild(0).gameObject;
        _content = viewport.transform.GetChild(0).gameObject;
        _contentTransform = _content.GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateInventory(inventory);
    }

    void UpdateInventory(Inventory inventory)
    {
        foreach (GameObject slot in _invSlots)
        {
            Destroy(slot);
        }
        _invSlots.Clear();
        
        const float deltaHeight = 200.0f;
        float contentHeight = deltaHeight * inventory.Count;
        _contentTransform.sizeDelta = new Vector2(1, contentHeight);
        
        float heightOffset = -contentHeight / 2.0f + 100.0f;
        for (int i = 0; i < inventory.Count; ++i)
        {
            GameObject invSlot = Instantiate(invSlotPrefab, new Vector3(0, heightOffset, 0), new Quaternion());
            invSlot.GetComponent<Image>().sprite = this.inventory.GetItem(i).sprite;
            invSlot.transform.SetParent(_content.transform, false);
            heightOffset += deltaHeight;
            _invSlots.Add(invSlot);
        }
    }
}
