using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class GameInstance : MonoBehaviour
{
    public Inventory inventory;
    public GameData gameData;

    public List<GameObject> mainScenes;
    public GameObject inventoryObject;

    private int _currentSceneIndex;
    private InventoryView _inventoryView;
    
    

    private void Start()
    {
        _inventoryView = inventoryObject.GetComponent<InventoryView>();
        _inventoryView.inventory = inventory;
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
