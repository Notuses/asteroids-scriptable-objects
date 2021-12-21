using UnityEngine;

public class OutsideScreen : MonoBehaviour
{
    private Camera cam;


    private void Start()
    {
        cam = Camera.main;
    }
    
    public void ScreenWrap(Transform trans)
    {
        var viewportPosition = cam.WorldToViewportPoint(trans.position);
        var newPosition = trans.position;

        if (viewportPosition.x > 1)
        {
            newPosition.x = -newPosition.x + .5f;
        }
        else if (viewportPosition.x < 0)
        {
            newPosition.x = -newPosition.x - .5f;
        }
        else if (viewportPosition.y > 1)
        {
            newPosition.y = -newPosition.y + .5f;
        }
        else if (viewportPosition.y < 0)
        {
            newPosition.y = -newPosition.y - .5f;
        }
        trans.position = newPosition;
    }
}
