using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManage : MonoBehaviour
{
    private AudioManager music;

    [SerializeField] GameObject panelSounds;

    [SerializeField] GameObject[] gemaPlayer;

    [SerializeField] GameObject[] gemaEnemy;

    [SerializeField] GameObject losePage, winPage;

   // [SerializeField] Button credits, menu, restart;
    [SerializeField] Button buttonPlayer, buttonEnemy;

    private void Start()
    {
        music = FindObjectOfType<AudioManager>();
    }
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
            music.PlayMusic(music.victory);
        }
        else
        {
            losePage.SetActive(true);
            music.PlayMusic(music.lose);
        }
    }

    public void SoundOptions()
    {
        if (panelSounds.activeInHierarchy)
        {
            panelSounds.SetActive(false);
    }
        else
        {
            panelSounds.SetActive(true);
        }
    }

}
