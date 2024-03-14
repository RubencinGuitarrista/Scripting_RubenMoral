using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTrigger : MonoBehaviour
{
    // Creamos esta variable para multiplicar la velocidad del jugador con el turbo del Speed Trigger
    public float speedFactor = 2.5f;


    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().runSpeed *=  speedFactor;
    }

    
    void OnTriggerExit(Collider other)
    {
          other.GetComponent<FirstPersonMovement>().runSpeed /= speedFactor;
    }
}
