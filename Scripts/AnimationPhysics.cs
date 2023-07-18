using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPhysics : MonoBehaviour
{

    public Rigidbody2D[] rigidBodies;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Rigidbody2D rb in rigidBodies)
        {
            rb.isKinematic = false;
        }
    }
}
