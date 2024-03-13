using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardCollection : MonoBehaviour
{
    [SerializeField] MonsterCard monsterCard;
    
    private void Update(){
        if (Input.GetKeyDown(KeyCode.Space)){
            AddMonsterCard();
        }
    }

    private void AddMonsterCard(){
        Instantiate(monsterCard, transform);
    }
}
