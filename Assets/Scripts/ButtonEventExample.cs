using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
[RequireComponent(typeof(PlaySound))]
public class ButtonEventExample : MonoBehaviour
{
    private Button _button;
    private PlaySound _sound;

    private void OnEnable()
    {
        _button.onClick.AddListener(HandleButtonClick);
    }

    private void Awake()
    {
        _button = GetComponent<Button>();
        _sound = GetComponent<PlaySound>();
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(HandleButtonClick);
    }

    private void HandleButtonClick()
    {
        _sound.Play();
    }
}