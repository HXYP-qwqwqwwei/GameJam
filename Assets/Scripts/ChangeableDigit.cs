using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeableDigit : MonoBehaviour
{
    public List<Sprite> sprites;

    private Image _image;

    private int _currentNumber = 0;
    // Start is called before the first frame update

    private void Start()
    {
        _image = GetComponent<Image>();
    }

    private void Update()
    {
        _image.sprite = sprites[_currentNumber];
    }

    public void IncreaseNumber()
    {
        _currentNumber = (_currentNumber + 1) % sprites.Count;
    }

    public void DecreaseNumber()
    {
        _currentNumber = (_currentNumber + sprites.Count - 1) % sprites.Count;
    }

    public int Number => _currentNumber;
}
