using System.Collections;
using System.Collections.Generic;
using Assignment;
using UnityEngine;

public class Wrapper : MonoBehaviour
{
    [SerializeField] private GameEventWrapper _outsideScreen;
    private Camera cam;
    private void Start()
    {
        cam = Camera.main;
    }
    
    private void LateUpdate()
    {
        var viewportPosition = cam.WorldToViewportPoint(transform.position);
        
        if (viewportPosition.x > 1 || viewportPosition.y > 1 || viewportPosition.x < 0 || viewportPosition.y < 0)
        {
            Debug.Log("EVENT RAISED");
            _outsideScreen.Raise(transform);
        }
    }
}
