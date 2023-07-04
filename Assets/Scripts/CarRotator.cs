using UnityEngine;

public class CarRotator: MonoBehaviour
{
    [SerializeField] private Transform _car;
    [SerializeField] private float _rotationSpeed = 40f;

    private void Awake()
    {
        StartGameButtonHandler.OnButtonPressed += () => _rotationSpeed = 0f;
    }

    private void Update()
    {
        Quaternion currentRotation = _car.rotation;
        Quaternion desiredRotation = Quaternion.Euler(0f, _rotationSpeed * Time.deltaTime, 0f) * currentRotation;
        _car.rotation = desiredRotation;
    }
}
