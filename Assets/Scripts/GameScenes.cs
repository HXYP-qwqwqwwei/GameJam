using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScenes : MonoBehaviour
{
    public List<GameObject> mainScenes;

    private int _currentSceneIndex;

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
}
