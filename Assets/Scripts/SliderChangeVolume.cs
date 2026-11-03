using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

[RequireComponent(typeof(Shader))]
public class SliderChangeVolume : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _mixer;
    [SerializeField] private string _mixerName;

    private Slider _slider;

    private void OnEnable()
    {
        _slider.onValueChanged.AddListener(ChangeVolume);
    }

    private void Awake()
    {
        _slider = GetComponent<Slider>();
    }

    private void OnDisable()
    {
        _slider.onValueChanged.RemoveListener(ChangeVolume);
    }

    private void ChangeVolume(float volume)
    {
        _mixer.audioMixer.SetFloat(_mixerName, ValueToVolume(volume));
    }

    private float ValueToVolume(float volume)
    {
        float minNumberForLog10 = 0.0001f;
        float maxNumberForLog10 = 1f;
        float convertNumberToDecibels = 20f;

        volume = Mathf.Clamp(volume, minNumberForLog10, maxNumberForLog10);

        return Mathf.Log10(volume) * convertNumberToDecibels;
    }
}