using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastFall : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool fallExploit = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        /*
          The following code sets the gravity of the players rigidbody to 5 when "S" is 
          pressed, and reverts the gravity back to 1 when any other key besides S is
          pressed. This allows us to effectively have a downward smash, so players can
          fall much faster when they hit S while falling.
            
         */
       

        if (Input.anyKey && !Input.GetKey(KeyCode.S))
        {
            rb.gravityScale = 1;
        }

        if (Input.GetKeyDown(KeyCode.S) && fallExploit)
        {
            rb.gravityScale = 3;
            fallExploit = false;
        }

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        fallExploit = true;
    }
}
