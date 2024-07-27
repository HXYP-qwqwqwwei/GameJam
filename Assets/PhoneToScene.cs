using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneToScene : MonoBehaviour
{
    [SerializeField] private GameObject mainScene;    
    [SerializeField] private GameObject firstSceneOverlook;
    
    public void SwitchAngle()
    {
        mainScene.SetActive(false);
        firstSceneOverlook.SetActive(true);
    }
}
