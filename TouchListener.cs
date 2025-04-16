using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class TouchListener : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler
{
    public UnityEvent TouchEvent;

    public void OnPointerDown(PointerEventData eventData)
    {
        TouchEvent.Invoke();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (!eventData.eligibleForClick) return;
        if (eventData.delta == Vector2.zero) return;
        TouchEvent.Invoke();
    }
}
