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