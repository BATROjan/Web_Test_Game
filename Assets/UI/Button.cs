using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Button : MonoBehaviour, IPointerClickHandler
{
    public Action OnClick;
    public Image Image => image;

    [SerializeField] private Image image;
    
    public void OnPointerClick(PointerEventData eventData) 
    {
        OnClick?.Invoke();
    }
}