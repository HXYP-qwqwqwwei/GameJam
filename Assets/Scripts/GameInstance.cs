using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[Serializable]
public class GameState
{
    public bool isValid = false;
    
}

public class GameInstance : MonoBehaviour
{
    public Inventory inventory;
    public GameData gameData;

    public List<GameObject> mainScenes;
    public GameObject inventoryObject;

    private int _currentSceneIndex;
    private InventoryView _inventoryView;
    
    public GameObject invSlotPrefab;

    private void Update()
    {
        if (inventory.SelectedSlotIndex != _inventoryView.selectedSlotIndex)
        {
            _inventoryView.selectedSlotIndex = inventory.SelectedSlotIndex;
            _inventoryView.UpdateInventory();
        }
    }


    private void Start()
    {
        _inventoryView = inventoryObject.GetComponent<InventoryView>();
        inventory.Clear();
        _inventoryView.inventory = inventory;
        inventory.SelectedSlotIndex = -1;
        _inventoryView.UpdateInventory();
    }

    public void NextScene()
    {
        GameObject currentScene = mainScenes[_currentSceneIndex];
        _currentSceneIndex = (_currentSceneIndex + 1) % mainScenes.Count;
        GameObject nextScene = mainScenes[_currentSceneIndex];
        currentScene.SetActive(false);
        nextScene.SetActive(true);
    }
    
    public void PrevScene()
    {
        GameObject currentScene = mainScenes[_currentSceneIndex];
        _currentSceneIndex = (_currentSceneIndex + 3) % mainScenes.Count;
        GameObject nextScene = mainScenes[_currentSceneIndex];
        currentScene.SetActive(false);
        nextScene.SetActive(true);
    }

    public InventoryView InventoryView => _inventoryView;
}
