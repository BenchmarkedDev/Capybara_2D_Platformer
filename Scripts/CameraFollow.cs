using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float followSpeed = 2f; // Specified speed at which the camera moves with the Player.
    public Transform player, cameraAngle; // Specifies the number of different objects for the camera to follow (useful for cutscenes or zooming in/out)
    public bool playerActive = true; // While this is active, the camera will follow the player. If set to false, it'll follow the other gameObject.
  

    // Update is called once per frame
    void LateUpdate()
    {

        /*
         The following code makes the camera follow the player, rather than stay
         stationary. (Though I'd be lying if I said I fully understood how the code
         below works at this point... I'll get there one day)
          
         */

        // If boolean is true, the camera will follow the Player.

        if (playerActive)
        {
            Vector3 newPos = new Vector3(player.position.x, player.position.y, -10f);
            transform.position = Vector3.Slerp(transform.position, newPos, followSpeed * Time.deltaTime);
        }

        // If the boolean is false, the camera will follow a specified gameObject.

        if (!playerActive)
        {
            Vector3 newPos = new Vector3(cameraAngle.position.x, cameraAngle.position.y, -10f);
            transform.position = Vector3.Slerp(transform.position, newPos, followSpeed * Time.deltaTime);
        }
    }

}
