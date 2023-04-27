using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Position on the grid
    [SerializeField]
    Transform[] cardPos = new Transform[6];
    // Cards to spawn (Prefabs)
    [SerializeField]
    GameObject[] cards;

    // Cards with attack to show
    GameObject[] cardsOnTable = new GameObject[6];

    bool onGame;
    int turn;

    void Start(){
        setTable();
    }

# region Set Table and Attak
    void setTable(){
        // instantiate the cards in the cardsOnTable array
        for (int i = 0; i < cardsOnTable.Length; i++)
        {
            cardsOnTable[i] = Instantiate(cards[Random.Range(0, cards.Length)], cardPos[i].position, Quaternion.identity) ;
        }
        // set the attack for each card
        setAtk();

        onGame=true;
    }

    void setAtk(){
        // Assigns attack to each card in the table
        foreach (GameObject cardOnTable in cardsOnTable)
        {
            Card cardToSetAttack;
            cardToSetAttack = cardOnTable.GetComponent<Card>();
            cardToSetAttack.AssignAttack(Random.Range(2,7));
        }
    }

# endregion


    IEnumerator Turn(){
        
        



        yield return true;
    }


}
