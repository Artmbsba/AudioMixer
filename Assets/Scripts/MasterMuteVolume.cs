using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Toggle))]
public class MasterMuteVolume : MonoBehaviour
{
    private Toggle _toggle;
    private int _numberForOnAudio = 1;
    private int _numberForOffAudio = 0;

    private void Awake()
    {
        _toggle = GetComponent<Toggle>();
    }

    private void Update()
    {
        if (_toggle.isOn)
            AudioListener.volume = _numberForOnAudio;
        else
            AudioListener.volume = _numberForOffAudio;
    }
}