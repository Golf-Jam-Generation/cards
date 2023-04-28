using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManage : MonoBehaviour
{
    [SerializeField] GameObject gemaPlayer1;
    [SerializeField] GameObject gemaPlayer2;
    [SerializeField] GameObject gemaPlayer3;

    [SerializeField] GameObject gemaEnemy1;
    [SerializeField] GameObject gemaEnemy2;
    [SerializeField] GameObject gemaEnemy3;


    [SerializeField] Button buttonPlayer, buttonEnemy;
  
    public void Point()
    {
        gemaPlayer1.SetActive(true);
        gemaPlayer2.SetActive(true);
        gemaPlayer3.SetActive(true);



    }
    public void Point2()
    {
        gemaEnemy1.SetActive(true);
        gemaEnemy2.SetActive(true);
        gemaEnemy3.SetActive(true);
    }

}
