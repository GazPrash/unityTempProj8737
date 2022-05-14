using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animeStateCtrl : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animeComp;

    void Start()
    {
        animeComp = GetComponent<Animator> (); 
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKey("w")) || 
            (Input.GetKey("a")) ||       
            (Input.GetKey("s")) ||
            (Input.GetKey("d"))){
            animeComp.SetInteger("MotionState", 2);
        } else {
            animeComp.SetInteger("MotionState", 1);
        }
        
    }
}
