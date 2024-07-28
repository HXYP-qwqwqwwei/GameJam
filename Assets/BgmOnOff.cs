using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class BgmOnOff : MonoBehaviour
{
    public Toggle musicToggle;
    public AudioSource bgm;

    void Start()
    {
        musicToggle.onValueChanged.AddListener(delegate
        {
            ToggleValueChanged(musicToggle);
        });
    }

    void ToggleValueChanged(Toggle change)
    {
        if (change.isOn)
        {
            bgm.Play();
        }
        else
        {
            bgm.Pause();
        }
    }
}
