using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowGameSettings : MonoBehaviour
{
    [SerializeField] private GameObject gameSettings;
    
    public void GameToSettings()
    {
        gameSettings.SetActive(true);
    }
}
