using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class AudioParameterSlider : MonoBehaviour
{
    [SerializeField] private AudioMixer _mixer;
    [SerializeField] private string _parameterName;
    
    private Slider _slider;
    private const float MinDb = -80f;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
        _slider.onValueChanged.AddListener(HandleValueChanged);
    }

    private void HandleValueChanged(float value)
    {
        float dB = value > 0 ? Mathf.Log10(value) * 20 : MinDb;
        _mixer.SetFloat(_parameterName, dB);
    }

    public void SetValue(float value) => _slider.value = value;
    public float GetValue() => _slider.value;
}
