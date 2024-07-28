using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour
{
    public GameObject currentScene;

    public void OnClick()
    {
        currentScene.SetActive(false);
        Destroy(gameObject);
    }
}
