using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{
    private Image _image;
    public int slotIndex;
    public GameData gameData;
    public Inventory inventory;
    private bool _isSelected = false;
    private GameObject _movingSlot;
    
    // Start is called before the first frame update
    void Start()
    {
        _image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        _image.sprite = inventory.GetItem(slotIndex).sprite;
    }

    public void SetSlotIndex(int index)
    {
        slotIndex = index;
    }
    
    
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _isSelected = true;
        }

        if (Input.GetMouseButtonUp(0))
        {
            _isSelected = false;
        }
    }
}
