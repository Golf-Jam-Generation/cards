using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManage : MonoBehaviour
{

    [SerializeField] GameObject[] gemaPlayer;

    [SerializeField] GameObject[] gemaEnemy;

    [SerializeField] GameObject losePage, winPage;

   // [SerializeField] Button credits, menu, restart;
    [SerializeField] Button buttonPlayer, buttonEnemy;
  

    public void Score(int score, string character)
    {
        if (character == "player")
        {
            gemaPlayer[score-1].SetActive(true);
        }
        else if (character == "enemy")
        {
            gemaEnemy[score - 1].SetActive(true);
        }
    }

    public void WinLose(int playerScore, int pcScore)
    {
        if (playerScore > pcScore)
        {
            winPage.SetActive(true);
        }
        else
        {
            losePage.SetActive(true);
        }
    }

}
