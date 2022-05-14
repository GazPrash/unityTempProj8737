using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector2 camDir;

    [SerializeField]
    public float sensitivity;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        camDir.x += Input.GetAxis("Mouse X") * sensitivity;
        camDir.y += Input.GetAxis("Mouse Y") * sensitivity;
        transform.localRotation = Quaternion.Euler(camDir.y, camDir.x, 0);
    }
}
