using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.GraphicsBuffer;

public class SmoothlyBarShower : HealthShower
{
    [SerializeField] private Slider _slider;
    [SerializeField] private float _changeingSpeed;

    private float _targetValue;
    private float _changeingStep;
    private Coroutine _towardsCoroutine;

    private bool _isChangeing = false;

    public override void OnHealthChanged(float maxValue, float currentValue)
    {
        _targetValue = (currentValue / maxValue) * MaxPercent;

        if (!_isChangeing)
        {
            _towardsCoroutine = StartCoroutine(ChangeValueTowards());
        }
        else
        {
            StopCoroutine(_towardsCoroutine);
            _towardsCoroutine = StartCoroutine(ChangeValueTowards());
        }
    }

    private IEnumerator ChangeValueTowards()
    {
        _isChangeing = true;

        while (!Mathf.Approximately(_slider.value, _targetValue))
        {
            _slider.value = Mathf.MoveTowards(_slider.value, _targetValue, _changeingSpeed * Time.deltaTime);

            yield return null;
        }

        _isChangeing = false;
        _towardsCoroutine = null;
    }
}
