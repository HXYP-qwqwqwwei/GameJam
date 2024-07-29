using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Computer : MonoBehaviour
{
    public GameObject endingScene;
    private bool _redPlug = false;
    private bool _bluePlug = false;

    public void OnRedUsbPlug()
    {
        _redPlug = true;
        if (_bluePlug)
        {
            SwitchToEnding();
        }
    }

    public void OnBlueUsbPlug()
    {
        _bluePlug = true;
        if (_redPlug)
        {
            SwitchToEnding();
        }
    }

    private void SwitchToEnding()
    {
        endingScene.SetActive(true);
    }
}
