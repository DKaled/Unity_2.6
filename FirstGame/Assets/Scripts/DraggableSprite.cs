using UnityEngine;
using UnityEngine.EventSystems;
using ActionHandler = SetAction;

public class DraggableSprite : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    private Canvas canvas;
    private CanvasGroup canvasGroup;

    void Awake()
    {
        canvas = GetComponentInParent<Canvas>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasGroup.alpha = 0.6f;
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
        GameObject.Find("ActionManager").GetComponent<ActionHandler>().NoAction(); // Verificar la acción actual al soltar el sprite
    }
}