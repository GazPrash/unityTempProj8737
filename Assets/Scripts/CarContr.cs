using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarContr : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    Vector3 veloc;

    // KeyCodes
    [SerializeField]
    KeyCode accl, deaccl;

    // Update is called once per frame
    void FixedUpdate()
    {
        var carComp = GetComponent<Rigidbody> ();

        if (Input.GetKey(accl)){
            carComp.velocity += veloc;
        }
        if (Input.GetKey(deaccl)){
            carComp.velocity -= veloc;
        }
    }
}
