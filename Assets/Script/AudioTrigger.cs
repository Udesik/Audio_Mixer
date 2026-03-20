using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioTrigger : MonoBehaviour
{
    private AudioSource _source;

    private void Awake()
    {
        _source = GetComponent<AudioSource>();
    }

    public void Play() => _source.Play();
}

