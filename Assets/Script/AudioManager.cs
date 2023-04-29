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

    private void Start()
    {
        musicSource.clip = menu;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}
