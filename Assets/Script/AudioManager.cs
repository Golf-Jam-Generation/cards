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

    //C�digos Comentados son diferentes pruebas para llegar a la l�gica propuesta

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
            musicSource.Stop();
            musicSource.clip = gameplay;
            musicSource.Play();
        }
        else if(SceneManager.GetActiveScene().name == "mainMenu" || SceneManager.GetActiveScene().name == "Instrucciones")
        {
            musicSource.Stop();
            musicSource.clip = menu;
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
    public void StopMusic(AudioClip clip)
    {
        musicSource.clip = clip;
        musicSource.Stop();
    }
    /*public void PlayGameplay(AudioClip clip)
    {
        musicSource.clip = gameplay;
        musicSource.Play();
    }

    public void PlayMenu(AudioClip clip)
    {
        musicSource.clip = menu;
        musicSource.Play();
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
