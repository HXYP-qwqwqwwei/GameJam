using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneToOverlook : MonoBehaviour
{
    [SerializeField] private GameObject currentScene;
    [SerializeField] private GameObject nextScene;

    public void SwitchAngle()
    {
        currentScene.SetActive(false);
        nextScene.SetActive(true);
    }
}
