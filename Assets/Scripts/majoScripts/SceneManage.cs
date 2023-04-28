using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SceneManage : MonoBehaviour
{
    

    //Codigo de cambio de escena🔁
    public void button(string Scena)
    {
        SceneManager.LoadScene(Scena);
    }
    //Boton de pausa 🛑
    public void Stop() 
    {
        Time.timeScale = 0;
        Debug.Log("Pausado");
    }
    //Boton de continuar ⏩
    public void Continue()
    {
        Time.timeScale = 1;
        Debug.Log("Continuado");
    }
    //Boton de Reiniciar 🔁
    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log("Reiniciado");
    }
}