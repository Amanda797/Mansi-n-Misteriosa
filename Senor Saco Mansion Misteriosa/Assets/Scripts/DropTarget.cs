using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// requires a collider (Collider 2D)
public class DropTarget : MonoBehaviour
{
    //This entire class doesn't do anything
    //It is just a "tag" to let other scripts know this is a drop target
    //You use "GetComponent <DropTarget>()" and check if the result is null to see
    //if an object is a drop target
}
