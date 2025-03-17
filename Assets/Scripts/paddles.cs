using UnityEngine;

public class paddles : MonoBehaviour
{
    public Rigidbody2D paddle;
    
    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        paddle = GetComponent<Rigidbody2D>();
        
    }
   
    //Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            
            paddle.linearVelocity = Vector2.up * speed;
    
        }
        else if (Input.GetKey(KeyCode.S))
        {
            
            paddle.linearVelocity = Vector2.down * speed;
        }
        else
        {
           paddle.linearVelocity = Vector2.zero;
        }
    }

    

}
