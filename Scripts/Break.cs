using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody2D rb;
    public Object destroyableBlock;
    public AudioSource breakSound;
    void Start()
    {
       
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "NewCapybara" && rb.gravityScale > 1)
        {
            breakSound.Play();
            rb.gravityScale = 1;
            Destroy(destroyableBlock);
        }
    }
}
