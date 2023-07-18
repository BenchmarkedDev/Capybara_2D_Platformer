using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour
{
    Rigidbody2D rb;
    private SpriteRenderer mySpriteRenderer;
    public Animator myAnimation;
    public float speed = 4f;
   
    
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

      
       

        /*
         The following code disables the players animation if both A & D (Left & Right) are not pressed, and enables it when either one of them are pressed. 
          This prevents the Player from looking like they are moving despite the sprite being completely idle.
         */

        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("Quit Clicked!");
        }
        
        if (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            

            myAnimation.gameObject.GetComponent<Animator>().enabled = false;
        }

        else
        {
            myAnimation.gameObject.GetComponent<Animator>().enabled = true;
        }


    

       

        /*
          The following code moves the sprite (The Capybara) horizontally, 
        at a speed of 3. Time.deltaTime makes it so that the speed will be 
        the same on each computer. The two 0's at the end of the code specify
        that we do not want to change anything on the Y and Z axis.
          
         */

        transform.Translate(Input.GetAxis("Horizontal") * 3 * Time.deltaTime, 0, 0);


        /* Flipping the character
         
          The following code will flip the sprite (The Capybara)
          if the player is moving right. If the player is moving 
          left, it will retain its default animation.

          IMPORTANT: the characterScale value must match the scale
          of the sprite in unity. The capybara sprite has an X scale of 1, 
          which is why I specify 1 in the code below. If the number was greater
          than 1, then the sprite would get stretched.
          
         */
        
        Vector3 characterScale = transform.localScale;

        if (Input.GetAxis("Horizontal") > 0)

        {
            characterScale.x = -1;
        }

        if (Input.GetAxis("Horizontal") < 0)

        {
            characterScale.x = 1;
        }

        transform.localScale = characterScale;
        

       
    }

}





