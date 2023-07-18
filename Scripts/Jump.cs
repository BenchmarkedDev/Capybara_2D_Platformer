using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpForce = 10f;
    public bool isJumping;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
         The following if statements make it so that the player can only perform
         a jump when it is coliding with the ground, preventing spam jumps.


          Hitting the ground will cause isJumping to change to false, which will
          then allow the player to jump again.
         
         */
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
           
            rb.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
           
            
        }
    }



}
