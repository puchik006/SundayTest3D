using UnityEngine;
using UnityEngine.UI;

public class CarColorChanger: MonoBehaviour
{
    [SerializeField] private Button _tapZone;
    [SerializeField] private Material _material;

    private void Awake()
    {
        _material.color = Color.white;
        _tapZone.Add(ChangeCarColorRandomly);
    }

    private void ChangeCarColorRandomly()
    {
        Color randomColor = new Color(Random.value, Random.value, Random.value);
        _material.color = randomColor;
    }
}
