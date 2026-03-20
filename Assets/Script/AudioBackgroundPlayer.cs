using UnityEngine;
using UnityEngine.Audio;

[RequireComponent(typeof(AudioSource))]
public class AudioBackgroundPlayer : MonoBehaviour
{
    [SerializeField] private AudioClip _musicClip;
    [SerializeField] private AudioMixerGroup _outputGroup;
    [SerializeField] private bool _playOnAwake = true;

    private AudioSource _source;

    private void Awake()
    {
        _source = GetComponent<AudioSource>();
        
        _source.clip = _musicClip;
        _source.outputAudioMixerGroup = _outputGroup;
        _source.loop = true;
        _source.playOnAwake = _playOnAwake;

        if (_playOnAwake && !_source.isPlaying)
        {
            _source.Play();
        }
    }

    public void SetMusic(AudioClip newClip)
    {
        _source.Stop();
        _source.clip = newClip;
        _source.Play();
    }
}