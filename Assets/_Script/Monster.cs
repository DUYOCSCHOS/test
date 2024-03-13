using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Monster : MonoBehaviour
{
    [SerializeField] float speed;

    private void Update(){
        Walk();
    }

    private void Walk(){
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
