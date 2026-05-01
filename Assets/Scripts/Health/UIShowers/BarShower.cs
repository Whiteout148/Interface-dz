using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarShower : HealthShower
{
    [SerializeField] private Slider _slider;

    public override void OnHealthChanged(float maxValue, float currentValue)
    {
        float percentValue = (currentValue / maxValue) * MaxPercent;

        _slider.value = percentValue;
    }
}
