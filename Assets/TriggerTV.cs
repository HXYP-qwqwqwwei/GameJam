using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTV : MonoBehaviour
{
    public GameObject tvOn;

    private void Start()
    {
        tvOn.SetActive(true);
    }
}
