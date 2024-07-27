using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowGame : MonoBehaviour
{
    [SerializeField] private GameObject settingsMyself;
    
    public void SettingsToGame()
    {
        settingsMyself.SetActive(false);
    }
}
