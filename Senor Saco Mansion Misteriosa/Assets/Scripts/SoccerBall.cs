using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoccerBall : MonoBehaviour
{
    // Create OnTriggerEnter event tha accepts excception collider other
    private void OnTriggerEnter(Collider other)
    {
        // Detect if object collided with ball is goal
        if (other.gameObject.tag == "Goal")
        {
            Debug.Log("Goal");
        }
    }
}
