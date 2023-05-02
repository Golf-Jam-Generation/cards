using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManage : MonoBehaviour
{
    private SceneManage scene;
    private AudioManager music;
    
    [SerializeField] GameObject panelSounds;

    [SerializeField] GameObject[] gemaPlayer;

    [SerializeField] GameObject[] gemaEnemy;
    /*
    [SerializeField] GameObject losePage, winPage;

    [SerializeField] Button credits, menu, restart;
    [SerializeField] Button buttonPlayer, buttonEnemy;*/

    private void Start()
    {
        scene = FindAnyObjectByType<SceneManage>();
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
            scene.ChangeScence("Win");
            music.PlayMusic(music.victory);
        }
        else
        {
            scene.ChangeScence("Lose");
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
