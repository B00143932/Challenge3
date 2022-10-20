using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{

    private Rigidbody playerRb;
    public float jumpForce ;
    public float gravitymodifier;
    // Start is called before the first frame update
    void Start()
    {
       playerRb = GetComponent<Rigidbody>();
       Physics.gravity *= gravitymodifier;
    }

    public bool isOnGround = true;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround){
        playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        isOnGround = false;
        }   
    }
   private void OnCollisionEnter(Collision collision){
          isOnGround = true;
   }
}
