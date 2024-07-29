using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Computer : MonoBehaviour
{
    public GameInstance gameInstance;
    public GameObject endingScene;
    private bool _redPlug = false;
    private bool _bluePlug = false;

    public void OnRedUsbPlug()
    {
        if (gameInstance.inventory.SelectedItem() == ItemType.RedUsbDisk)
        {
            _redPlug = true;
            if (_bluePlug)
            {
                SwitchToEnding();
            }
        }
    }

    public void OnBlueUsbPlug()
    {
        if (gameInstance.inventory.SelectedItem() == ItemType.BlueUsbDisk)
        {
            _bluePlug = true;
            if (_redPlug)
            {
                SwitchToEnding();
            }
        }
    }

    private void SwitchToEnding()
    {
        endingScene.SetActive(true);
    }
}
