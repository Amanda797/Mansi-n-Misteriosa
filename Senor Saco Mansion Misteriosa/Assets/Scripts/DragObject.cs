using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// This requires a collider 2D AND a rigidbody
[RequireComponent(typeof(Collider2D))]
[RequireComponent(typeof(Rigidbody2D))]

public class DragObject : MonoBehaviour
{
    // Attempting to add sound to dragging object (Spanish word)
    public AudioClip mySound;
    public AudioSource audioSource;

    private bool isDragging;
    private Vector3 startLocation;
    private float zDepth = 5;
    private GameObject currentAnswer;
    public GameObject correctAnswer;

    // Start is called before the first frame update
    void Start()
    {
        //Attempting to add sound
        audioSource = GetComponent<AudioSource>();

        // Save our start location
        startLocation = transform.position;

        // We are NOT dragging at start
        isDragging = false;

        // Make sure our collider is a trigger
        GetComponent<Collider2D>().isTrigger = true;

        // Make sure our rigidbody is Kinematic (so it doesn't move by physics, just does collisions)
        GetComponent<Rigidbody2D>().isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        // If we are dragging
        if (isDragging)
        {
            // Move to the mouse location
            transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, zDepth));
        }
    }

    private void OnMouseDown()
    {
        // On MouseDown, Start Dragging
        isDragging = true;
    }
    private void OnMouseUpAsButton()
    {
        // On MouseUp Stop Dragging
        isDragging = false;

        // Check if current answer is correct answer
        if (currentAnswer == correctAnswer)
        {
            // Disable this object
            currentAnswer.SetActive(false);
            transform.position = correctAnswer.transform.position;
            

            // Do our correct stuff
            Debug.Log("Correct");
            this.enabled = false;
        }
        else if (currentAnswer == null)
        {
            // Check if our answer is "null" -- we aren't over anything
            // Do our no answer stuff
            Debug.Log("No Answer");
            // Go back to start
            transform.position = startLocation;
        }
        else
        {
            // Do our wrong answer stuff
            Debug.Log("Wrong");
            // Go back to start
            transform.position = startLocation;

        }

        

        // We are no longer over a target
        currentAnswer = null;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Whenever we enter a dropTarget with a drag object
        // Save the "DropTarget" that we collided with/entered
        DropTarget collisionDropTarget = collision.gameObject.GetComponent<DropTarget>();
        // So long as it exists (is not null)
        if (collisionDropTarget != null)
        {
            // Save that this is the current drop target
            currentAnswer = collisionDropTarget.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        // Whenever we leave a trigger
        // Forget that we have a current drop target
        currentAnswer = null;
    }

    // Attempting to add sound
    private void OnMouseEnter()
    {
        Debug.Log("Play_Audio");
        audioSource.PlayOneShot(mySound);
    }

}







