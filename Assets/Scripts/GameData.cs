using System;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "GameData", menuName = "ScriptableObjects/GameData", order = 1)]
public class GameData: ScriptableObject
{
    [SerializeField]
    public List<GameItem> registeredItem;

    bool SameItemPredicate(GameItem item1, GameItem item2)
    {
        return item1.type == item2.type;
    }
    
    public GameItem GetItem(ItemType type)
    {
        return registeredItem.Find(item => item.type == type);
    }
}
