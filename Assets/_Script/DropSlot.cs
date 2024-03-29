using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropSlot : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData){
        if (eventData.pointerDrag != null){
            eventData.pointerDrag.transform.position = transform.position;
            Instantiate(eventData.pointerDrag.GetComponent<MonsterCard>().monster, transform.position, Quaternion.identity);
            Destroy(eventData.pointerDrag);
        }
    }
}
