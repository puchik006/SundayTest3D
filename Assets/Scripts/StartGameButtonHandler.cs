using System;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class StartGameButtonHandler : MonoBehaviour
{
    public static Action OnButtonPressed;
    private Button _button;

    private void Awake()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(() => OnButtonPressed?.Invoke());
    }
}
