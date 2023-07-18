using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperJumpPad : MonoBehaviour
{
    private float bounce = 15f;
    public AudioSource audioPlayer;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        /*
         The following code will cause the player (via the compare tag command) to
          be shot-up into the air upon colission with this object. It will also cause
           our sound effect to play at the same time.
         
         */
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bounce, ForceMode2D.Impulse);
            audioPlayer.Play();
        }


    }


}

