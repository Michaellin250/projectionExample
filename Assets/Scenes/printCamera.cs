using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class printCamera : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    void Start()
    {
        Camera cam = Camera.main;
        transform.LookAt(Vector3.zero, Vector3.up);
        var matrix = transform.localToWorldMatrix;
        print("Model");
        print(matrix);
        print("View");
        print(cam.worldToCameraMatrix);
        print("Projection");
        print(GL.GetGPUProjectionMatrix(cam.projectionMatrix, false));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
