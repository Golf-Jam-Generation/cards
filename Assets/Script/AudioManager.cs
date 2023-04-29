using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("--------- Audio Source ------------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("--------- Audio Clip ------------")]
    public AudioClip gameplay;
    public AudioClip menu;

    private void Start()
    {
        musicSource.clip = menu;
        musicSource.Play();
    }
}
