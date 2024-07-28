using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{
    private Image _image;
    private Color _color;
    public int slotIndex;
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
        _image.color = _color;
    }

    public void SetSlotIndex(int index)
    {
        slotIndex = index;
    }
    
    public void OnClick()
    {
        if (inventory.SelectedSlotIndex == slotIndex)
        {
            inventory.SelectedSlotIndex = -1;
        }
        else
        {
            inventory.SelectedSlotIndex = slotIndex;
        }
    }

    public void SetColor(Color color)
    {
        _color = color;
    }
}
