using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoccerPlayer : MonoBehaviour
{
    public float horialAxis, speed;
    private Rigidbody2D rb_soccerPlayer;

    // Start is called before the first frame update
    void Start()
    {
        rb_soccerPlayer = GetComponent<Rigidbody2D>();
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }

   private void FixedUpdate()
    {
        // rb_soccerPlayer.velocity = new Vector2(Time.deltaTime * speed * horialAxis, rb_soccerPlayer, velocity.y);
    }

    public void Move(int value)
    {
        horialAxis = value;
    }
    public void StopMove()
    {
        horialAxis = 0;
    }
}
