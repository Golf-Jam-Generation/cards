using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    [SerializeField]
    int attack;
    public bool isFaceUp;
    private bool selected;


    public void AssignAttack(int atk){
        attack = atk;
    }

    IEnumerator RotateCard(){
        int angle =0;
        float zRotation = transform.rotation.eulerAngles.z;
        while (angle<180){
            transform.Rotate(new Vector3(0,0,1), Space.Self);
            Debug.Log(angle);
            angle ++;
            yield return new WaitForFixedUpdate();
        }
        isFaceUp = true;
        
    }

    // void OnMouseDown(){
    //     StartCoroutine(RotateCard());
    // }


}
