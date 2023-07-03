using UnityEngine;

public class ScreenOrientationHandler: MonoBehaviour
{
    private void Awake()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }
}
