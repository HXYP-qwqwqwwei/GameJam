using System;
using UnityEngine;

public enum ItemType
{
    None,
    Spade,
    RedUsbDisk,
    BlueUsbDisk,
    StorageKey
}

[Serializable]
public class GameItem
{
    public ItemType type;
    public Sprite sprite;
}