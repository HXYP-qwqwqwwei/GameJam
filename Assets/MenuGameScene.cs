using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuToSettings : MonoBehaviour
{
    public void SceneSwitcher()
    {
        SceneManager.LoadScene("MenuSettingsScene");
    }
}
