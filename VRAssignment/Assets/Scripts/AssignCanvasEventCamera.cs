using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignCanvasEventCamera : MonoBehaviour
{
    public Canvas canvas;

    // Start is called before the first frame update
    void Start()
    {
        Canvas canvas = GetComponent<Canvas>();
        if (canvas && canvas.worldCamera == null)
        {
            canvas.worldCamera = Camera.main;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
