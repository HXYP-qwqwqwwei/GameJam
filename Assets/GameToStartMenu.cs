using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameToStartMenu : MonoBehaviour
{
    public void SceneSwitcher()
    {
        SceneManager.LoadScene("StartMenuScene");
    }
}
