using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramovement : MonoBehaviour
{
    public Transform player; // Reference to the player's transform

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            // Follow the player's x position
            transform.position = new Vector3(player.position.x, transform.position.y, transform.position.z);
        }
    }
}