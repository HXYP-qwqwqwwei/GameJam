using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMenuSettings : MonoBehaviour
{
    [SerializeField] private GameObject menuSettings;

    public void menuToSettings()
    {
        menuSettings.SetActive(true);
    }
}
