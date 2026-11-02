using UnityEngine;
using UnityEngine.Audio;

public class PanelSettingAudio : MonoBehaviour
{
    [SerializeField] AudioMixerGroup _mixer;

    public void ToggleMusic(bool enable)
    {
        float minNumberVolume = 0f;
        float maxNumberVolume = 1f;

        if (enable)
            _mixer.audioMixer.SetFloat("MasterVolume", ValueToVolume(maxNumberVolume));
        else
            _mixer.audioMixer.SetFloat("MasterVolume", ValueToVolume(minNumberVolume));
    }

    public void ChangeMasterVolume(float volume)
    {
        _mixer.audioMixer.SetFloat("MasterVolume", ValueToVolume(volume));
    }

    public void ChangeButtonVolume(float volume)
    {
        _mixer.audioMixer.SetFloat("ButtonVolume", ValueToVolume(volume));
    }

    public void ChangeBackgroungVolume(float volume)
    {
        _mixer.audioMixer.SetFloat("BackgroungVolume", ValueToVolume(volume));
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