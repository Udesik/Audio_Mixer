using UnityEngine;
using UnityEngine.UI;

public class AudioMuteToggle : MonoBehaviour
{
    [SerializeField] private AudioParameterSlider _masterSlider;
    [SerializeField] private Button _muteButton;

    private bool _isMuted;
    private float _preMuteVolume = 1f;

    private void Awake()
    {
        _muteButton.onClick.AddListener(Toggle);
    }

    private void Toggle()
    {
        _isMuted = !_isMuted;

        if (_isMuted)
        {
            _preMuteVolume = _masterSlider.GetValue();
            _masterSlider.SetValue(0);
        }
        else
        {
            _masterSlider.SetValue(_preMuteVolume);
        }
    }
}

