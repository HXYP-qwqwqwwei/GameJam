using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuToStartGame : MonoBehaviour
{
    //[SerializeField] private GameObject startMenu;
    //[SerializeField] private GameObject gameScene;

    public void SceneLoader()
    {
        SceneManager.LoadScene("GameScene");
    }
}
