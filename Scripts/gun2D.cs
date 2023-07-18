using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun2D : MonoBehaviour
{

    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;
    public KeyCode lastHitKey;
  
    private void Update()
    {


        /*
         The following code checks if A / D (Left / Right) have been pressed by the player, and then assigns the respective key to the variable 'lastHitKey'
         We then utilise this variable to allow our bullets to fire even when the player isn't moving. If the last hit key was A, the bullets will fire left.
         If the last hit key was D, the bullets will fire right.

        Note that we have to specify left with '-bulletSpawnPoint.right', as opposed to 'bulletSpawnPoint.left' since there is no .left command. (note the minus symbol (-) at the start) 
          
         */
        if (Input.GetKeyDown(KeyCode.D))
        {
            lastHitKey = KeyCode.D;
        }


        if (lastHitKey == KeyCode.D && Input.GetMouseButtonDown(0))

        {
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = bulletSpawnPoint.right * bulletSpeed;
        }



        if (Input.GetKeyDown(KeyCode.A))
        {
            lastHitKey = KeyCode.A;
        }


        if (lastHitKey == KeyCode.A && Input.GetMouseButtonDown(0))

        {
                var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
                bullet.GetComponent<Rigidbody2D>().velocity = -bulletSpawnPoint.right * bulletSpeed;
            }
        }

 
}


