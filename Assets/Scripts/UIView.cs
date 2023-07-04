using UnityEngine;

public class UIView: MonoBehaviour
{
    [SerializeField] RectTransform _mainMenu;
    [SerializeField] RectTransform _carMovementUI;

    private void Awake()
    {
        StartGameButtonHandler.OnButtonPressed += TurnOnCarMovementUI;
    }

    private void TurnOnCarMovementUI()
    {
        _mainMenu.Deactivate();
        _carMovementUI.Activate();
    }
}
