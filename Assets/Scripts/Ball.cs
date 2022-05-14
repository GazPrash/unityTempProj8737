using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    Vector3 velo;

    void Start()
    {
        // int SPEED = 5;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        GetComponent<Rigidbody> ().velocity += velo;
    }

}
