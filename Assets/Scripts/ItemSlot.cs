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

}
