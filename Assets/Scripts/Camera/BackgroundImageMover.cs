﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundImageMover : MonoBehaviour
{
    public float offset;
    public float speed;
    public bool moveVertically;
    public bool useResetPosition;

    private float _initialValueX;
    private float _maximumValueX;
    private float _minimumValueX;
    private float _currentValueX; 
    
    private float _initialValueY;
    private float _maximumValueY;
    private float _minimumValueY;
    private float _currentValueY;

    private bool _moveDirection = true;

    private RectTransform imagePosition;

    // Start is called before the first frame update
    void Start()
    {
        imagePosition = gameObject.GetComponent<RectTransform>();
        
        // HORIZONTAL MOVEMENT
        _initialValueX = imagePosition.rect.x;
        _maximumValueX = _initialValueX + offset;
        _minimumValueX = _initialValueX - offset;
        _currentValueX = _initialValueX;

        // VERZICAL MOVEMENT
        _initialValueY = imagePosition.rect.y;
        _maximumValueY = _initialValueY + offset;
        _minimumValueY = _initialValueY - offset;
        _currentValueY = _initialValueY;

    }

    // Update is called once per frame
    void Update()
    {
        if (moveVertically)
        {
            if (_moveDirection) // GO UP
            {
                if (_currentValueY > _maximumValueY)
                {
                    _moveDirection = false;
                }
                _currentValueY += speed;
            }
            else // GO DOWN
            {
                if (_currentValueY < _minimumValueY)
                {
                    _moveDirection = true;
                }
                _currentValueY -= speed;
            }

            imagePosition.localPosition = new Vector3(0, _initialValueY - _currentValueY);
        }
        else
        {
            if (_moveDirection) // GO RIGHT
            {
                if (_currentValueX > _maximumValueX)
                {
                    _moveDirection = false;
                }
                _currentValueX += speed;
            }
            else // GO LEFT
            {
                if (_currentValueX < _minimumValueX)
                {
                    _moveDirection = true;
                }
                _currentValueX -= speed;
            }

            imagePosition.localPosition = new Vector3(_initialValueX - _currentValueX, 0);
        }
    }
}
