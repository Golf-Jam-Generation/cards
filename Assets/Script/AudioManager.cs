using UnityEngine;

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
    /*private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }*/

    private void Start()
    {
        musicSource.clip = menu;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
    public void PlayGameplay(AudioClip clip)
    {
        musicSource.clip = gameplay;
        musicSource.Play();
    }

    public void PlayMenu(AudioClip clip)
    {
        musicSource.clip = menu;
        musicSource.Play();
    }
}
