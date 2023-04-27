using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SceneManage : MonoBehaviour
{
    


    public void button(string Scena)
    {
        SceneManager.LoadScene(Scena);
    }


}
