using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScene : MonoBehaviour
{
    [SerializeField] private GameObject currentScene;
    public GameObject nextScene;

    public void SceneSwitcher()
    {
        currentScene.SetActive(false);
        nextScene.SetActive(true);
    }
}
