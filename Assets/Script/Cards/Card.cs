using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public int attack;
    public bool isFaceUp= false;
    public bool isSelected =false;


    public void AssignAttack(int atk){
        attack = atk;
    }

    public IEnumerator RotateCard(){
        Transform childCard = this.gameObject.transform.GetChild(0);
        int angle =0;
        float zRotation = childCard.rotation.eulerAngles.z;
        isSelected = true;
        while (angle<180){
            childCard.Rotate(new Vector3(0,0,2), Space.Self);
            angle +=2;
            yield return new WaitForFixedUpdate();
        }
        yield return new WaitForSeconds(3);
        isFaceUp = true;
    }


}
