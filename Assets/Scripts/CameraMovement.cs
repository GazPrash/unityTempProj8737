using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    Transform playerT;

    void Update()
    {
        transform.position = playerT.position;
    }
}
