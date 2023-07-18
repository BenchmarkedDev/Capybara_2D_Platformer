using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    
    public float life = 3;
    
    

    private void Awake()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Destroy(this.gameObject, 0.7f);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
        Destroy(this.gameObject);
    }

}
