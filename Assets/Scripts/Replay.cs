using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Replay : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    KeyCode Restart;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(Restart)){
            var currScene = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currScene);
        }
        
    }
}
