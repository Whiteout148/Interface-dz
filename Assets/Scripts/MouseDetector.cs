using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseDetector : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public event Action CursorEntered;
    public event Action CursorExited;

    public void OnPointerEnter(PointerEventData eventData)
    {
        CursorEntered?.Invoke();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        CursorExited?.Invoke(); 
    } 
}
