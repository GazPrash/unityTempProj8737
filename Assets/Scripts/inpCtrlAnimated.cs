using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class inpCtrlAnimated : MonoBehaviour
{
    private PlayerInputCtrl pinp;
    public Vector2 currInp;
    public Vector3 currPosn;
    public bool idleState = true;
    CharacterController contrlCollider;

    [SerializeField]
    private float   pSpeed = 4f, 
                    Gravity = 0.5f, 
                    rotationFactor = 1f;
    // private float jumpForce = 5F;

    void Awake(){
        // used for instantiating useful objs, that are needed before the scene gets initl.
        pinp = new PlayerInputCtrl();
        pinp.Enable();
        contrlCollider = GetComponent<CharacterController> ();

        pinp.Motion.Run.started += handleMovement;
        pinp.Motion.Run.canceled += handleMovement;
        pinp.Motion.Run.performed += handleMovement;
    }

    void handleMovement(InputAction.CallbackContext context){
        currInp = context.ReadValue<Vector2> ();    
        currPosn.x = currInp.x;
        currPosn.z = currInp.y;
        idleState = (currInp.x == 0) && (currInp.y == 0);
    }

    void FixedUpdate()
    {
        handleRotation();
        handleGravity();
        Vector3 playerTransform = this.transform.TransformDirection(currPosn);
        contrlCollider.Move(playerTransform * Time.deltaTime * pSpeed);
    }

    void handleGravity(){
        if (contrlCollider.isGrounded){
            currPosn.y = 0;
        } else {
            currPosn.y -= Gravity;
        }

    }

    void handleRotation(){
        Vector3 playerPOV;
        playerPOV.x = currPosn.x;
        playerPOV.y = 0.0f;
        playerPOV.z = currPosn.z;
        var curRotation = this.transform.rotation;

        if (!idleState){
            Quaternion targetPOV = Quaternion.LookRotation(playerPOV);
            this.transform.rotation = Quaternion.Slerp(curRotation, targetPOV, rotationFactor);
        }
    }

    void OnDisable(){
        pinp.Disable();
    }
}
