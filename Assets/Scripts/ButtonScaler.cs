using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScaler : MonoBehaviour
{
    [SerializeField] private float _factorToScale;
    [SerializeField] private RectTransform _transform;
    [SerializeField] private MouseDetector _mouseDetector;

    private Vector2 _baseScale;

    private void Awake()
    {
        _baseScale = transform.localScale;
    }

    private void OnEnable()
    {
        _mouseDetector.CursorEntered += OnCursorIn;
        _mouseDetector.CursorExited += OnCursorOut;
    }

    private void OnDisable()
    {
        _mouseDetector.CursorEntered -= OnCursorIn;
        _mouseDetector.CursorExited -= OnCursorOut;
    }

    private void OnCursorIn()
    {
        _transform.localScale = transform.localScale * _factorToScale;
    }

    private void OnCursorOut()
    {
        _transform.localScale = _baseScale;
    }
}
