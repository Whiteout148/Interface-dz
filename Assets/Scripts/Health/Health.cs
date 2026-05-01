using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] private float _maxCount;

    private float _count;

    public event Action<float, float> ValueChanged;

    private void Awake()
    {
        _count = 0;
    }

    public void ChangeValue(float value)
    {
        if (_count + value >= _maxCount)
        {
            _count = _maxCount;
        }
        else if (_count + value <= 0f)
        {
            _count = 0f;
        }
        else
        {
            _count += value;
        }
        
        ValueChanged?.Invoke(_maxCount, _count);
    }
}
