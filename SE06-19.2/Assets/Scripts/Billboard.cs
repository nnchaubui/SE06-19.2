using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    Camera camera;
    // Update is called once per frame
    void Update()
    {
        if (camera == null)
        {
            camera = FindObjectOfType<Camera>();
        }
        if (camera == null)
        {
            return;
        }
        transform.LookAt(camera.transform);
        transform.Rotate(90f, 0.0f, 0.0f) ;
    }
}
