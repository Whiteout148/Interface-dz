using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionSubscriber : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private HealthValueChanger _damager;
    [SerializeField] private HealthValueChanger _healther;

    private void OnEnable()
    {
        _damager.HealthValueChanged += _health.ChangeValue;
        _healther.HealthValueChanged += _health.ChangeValue;
    }

    private void OnDisable()
    {
        _damager.HealthValueChanged -= _health.ChangeValue;
        _healther.HealthValueChanged -= _health.ChangeValue;
    }
}
