using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthValueChanger : MonoBehaviour
{
    [SerializeField] private float _value;
    [SerializeField] private Button _button;

    public event Action<float> HealthValueChanged;

    private void OnEnable()
    {
        _button.onClick.AddListener(ChangeHealthValue);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(ChangeHealthValue);   
    }

    public void ChangeHealthValue()
    {
        HealthValueChanged?.Invoke(_value);
    }
}
