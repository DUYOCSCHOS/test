using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MonsterCard : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Monster monster;
    [SerializeField] Transform parent;
    [SerializeField] Transform canvas;

    CanvasGroup canvasGroup;

    private void Awake(){
        parent = transform.parent;
        canvas = transform.root;
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = false;
        canvasGroup.alpha = 0.6f;
        transform.SetParent(canvas, true);
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position += (Vector3)eventData.delta / canvas.GetComponent<Canvas>().scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = true;
        canvasGroup.alpha = 1;
        transform.SetParent(parent, true);
    }
}
