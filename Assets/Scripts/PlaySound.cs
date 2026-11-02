using UnityEngine;

public class PlaySound: MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;

    public void Play()
    {
        _audioSource.Play();
    }
}