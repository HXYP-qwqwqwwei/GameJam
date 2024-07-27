using System;
using UnityEngine;

public enum ItemType
{
    Air,
    TestItem,
}

[Serializable]
public class GameItem
{
    public ItemType type;
    public Sprite sprite;
}

public class ItemSlot
{
    public GameItem Item;
    public int Count;
}