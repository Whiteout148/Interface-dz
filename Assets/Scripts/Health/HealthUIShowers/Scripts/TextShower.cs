using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditorInternal;
using UnityEngine;

public class TextShower : HealthShower
{
    [SerializeField] private TextMeshProUGUI _text;

    public override void OnHealthChanged(float maxValue, float currentValue)
    {
        float percentValue = (currentValue / maxValue) * MaxPercent;

        _text.text = "Health count: " + currentValue + "/" + maxValue + " Percent:" + percentValue;
    }
}
