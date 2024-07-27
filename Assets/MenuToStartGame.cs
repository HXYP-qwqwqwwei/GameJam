using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuToStartGame : MonoBehaviour
{
    //[SerializeField] private GameObject startMenu;
    //[SerializeField] private GameObject gameScene;

    public void SceneSwitcher()
    {
        SceneManager.LoadScene("GameScene");
    }
}
