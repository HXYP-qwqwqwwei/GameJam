using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SceneSwitcher : MonoBehaviour
{
    public GameObject nextScene;

    public GameObject backButtonPrefab;

    public bool createBackButton = false;
    
    public void OnClick()
    {
        nextScene.SetActive(true);
        if (createBackButton)
        {
            GameObject backButtonObj = Instantiate(backButtonPrefab, new Vector3(-500, 300, 0), new Quaternion());
            backButtonObj.GetComponent<BackButton>().currentScene = nextScene;
            backButtonObj.transform.SetParent(nextScene.transform, false);
        }
    }
}
