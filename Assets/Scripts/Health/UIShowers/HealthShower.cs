using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public abstract class HealthShower : MonoBehaviour
{
    protected const float MaxPercent = 100f;

    public abstract void OnHealthChanged(float maxValue, float currentValue);
}
