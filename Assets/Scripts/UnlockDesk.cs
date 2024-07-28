using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class UnlockScene : MonoBehaviour
{
    public List<GameObject> digitObjects;

    public GameObject targetScene;

    private List<ChangeableDigit> _digits;
    // Start is called before the first frame update
    void Start()
    {
        _digits = new();
        foreach (GameObject digitObject in digitObjects)
        {
            _digits.Add(digitObject.GetComponent<ChangeableDigit>());
        }
    }

    public void OnClick()
    {
        if (_digits[0].Number == 1)
        {
            if (_digits[1].Number == 5)
            {
                if (_digits[2].Number == 0)
                {
                    if (_digits[3].Number == 0)
                    {
                        targetScene.SetActive(true);
                    }
                }
            }
        }
    }
}
