using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameToSettings : MonoBehaviour
{
    public void SceneSwitcher()
    {
        SceneManager.LoadScene("GameSettingsScene");
    }
}
