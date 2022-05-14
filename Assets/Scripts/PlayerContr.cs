using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContr : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    Vector3 vel;

    [SerializeField]
    KeyCode incre, decre;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // var currVel = GetComponent<Rigidbody> ().velocity;
        // currVel += vel;
        var player = GetComponent<Rigidbody> ();

        if (Input.GetKey(incre)){
            player.velocity += vel;
        }
        if (Input.GetKey(decre)){
            player.velocity -= vel;
        }
    }
}
