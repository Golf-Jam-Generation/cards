using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    [Header("--------- Audio Source ------------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("--------- Audio Clip ------------")]
    public AudioClip gameplay;
    public AudioClip menu;
    public AudioClip lose;
    public AudioClip victory;
    public AudioClip pcPoint;
    public AudioClip playerPoint;
    public AudioClip click;

    public static AudioManager instance;

    //Códigos Comentados son diferentes pruebas para llegar a la lógica propuesta

    /*private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }*/

    private void Start()
    {
        if(SceneManager.GetActiveScene().name == "Level")
        {
            musicSource.Pause();
            musicSource.clip = gameplay;
            musicSource.Play();
        }
        else if(SceneManager.GetActiveScene().name == "mainMenu" || SceneManager.GetActiveScene().name == "Instrucciones")
        {
            musicSource.Pause();
            musicSource.clip = menu;
            musicSource.Play();
        }
        else if (SceneManager.GetActiveScene().name == "Win")
        {
            musicSource.Pause();
            musicSource.clip = victory;
            musicSource.Play();
        }
        else if (SceneManager.GetActiveScene().name == "Lose")
        {
            musicSource.Pause();
            musicSource.clip = lose;
            musicSource.Play();
        }
        /*scene = FindAnyObjectByType<SceneManage>();
        string conection="hola";
        scene.button(conection);
        Debug.Log(conection);
        if (scene.button(conection)=="Level")
        {

        }*/

    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }

    public void PlayMusic(AudioClip clip)
    {
        musicSource.Pause();
        musicSource.clip = clip;
        musicSource.Play();
    }
    /*public void StopMusic(AudioClip clip)
    {
        musicSource.clip = clip;
        musicSource.Pause();
    }
   public void SwitchPlay()
    {
        if (musicSource.clip == menu)
        {
            musicSource.Stop();
            musicSource.clip = gameplay;
            musicSource.Play();
        }
        else if(musicSource.clip == gameplay)
        {
            musicSource.Stop();
            musicSource.clip = menu;
            musicSource.Play();
        }
        else
        {
            musicSource.Stop();
        }
    }*/
}
