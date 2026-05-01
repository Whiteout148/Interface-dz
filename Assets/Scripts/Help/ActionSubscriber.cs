using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionSubscriber : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private HealthValueChanger _damager;
    [SerializeField] private HealthValueChanger _healther;
    [SerializeField] private TextShower _textShower;
    [SerializeField] private BarShower _barShower;
    [SerializeField] private SmoothlyBarShower _smoothlyShower;

    private void OnEnable()
    {
        _health.ValueChanged += _textShower.OnHealthChanged;
        _health.ValueChanged += _barShower.OnHealthChanged;
        _health.ValueChanged += _smoothlyShower.OnHealthChanged;
        _damager.HealthValueChanged += _health.ChangeValue;
        _healther.HealthValueChanged += _health.ChangeValue;
    }

    private void OnDisable()
    {
        _health.ValueChanged -= _textShower.OnHealthChanged;
        _health.ValueChanged -= _barShower.OnHealthChanged;
        _health.ValueChanged -= _smoothlyShower.OnHealthChanged;
        _damager.HealthValueChanged -= _health.ChangeValue;
        _healther.HealthValueChanged -= _health.ChangeValue;
    }
}
