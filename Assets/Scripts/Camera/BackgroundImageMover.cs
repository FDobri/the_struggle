using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundImageMover : MonoBehaviour
{
    public float offset;
    public float speed;

    private float _initialValue;
    private float _maximumValue;
    private float _minimumValue;
    private float _currentValue;

    private bool _moveRight = true;

    private RectTransform imagePosition;

    // Start is called before the first frame update
    void Start()
    {
        imagePosition = gameObject.GetComponent<RectTransform>();
        _initialValue = imagePosition.rect.x;
        _maximumValue = _initialValue + offset;
        _minimumValue = _initialValue - offset;
        _currentValue = _initialValue;
    }

    // Update is called once per frame
    void Update()
    {
        if (_moveRight) // GO RIGHT
        {
            if (_currentValue > _maximumValue)
            {
                _moveRight = false;
            }
            _currentValue += speed;
        }
        else // GO LEFT
        {
            if (_currentValue < _minimumValue)
            {
                _moveRight = true;
            }
            _currentValue -= speed;
        }

        imagePosition.localPosition = new Vector3(_initialValue - _currentValue, 0);
    }
}
