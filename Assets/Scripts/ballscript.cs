#if UNITY_EDITOR
using UnityEditor.Experimental.GraphView;
#endif
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.Audio;

public class ballscript : MonoBehaviour
{
    public Rigidbody2D ball;
    public GameObject gameoverpanel;
    public float speed;
    public float speedincrease = 1f;
    public float maxspeed = 50f;
    public AudioSource hitsound;
    private float lastHitTime = 0f;
    public float hitCooldown = 0.1f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("InvokeRepeating should start now...");

        float xDirection = Random.Range(0, 2) == 0 ? -speed : speed;

        // Randomly decide Y direction: up (speed) or down (-speed)
        float yDirection = Random.Range(0, 2) == 0 ? speed : -speed;

        ball.linearVelocity = new Vector2(xDirection, yDirection);


        InvokeRepeating("Increasespeed", 5f, 5f);

        ball.linearVelocity = new Vector2 (xDirection, yDirection).normalized * speedincrease;

        Increasespeed();
    }

    public void Increasespeed()
    {
        if(speed < maxspeed)
        {
            speed += speedincrease;
            ball.linearVelocity = ball.linearVelocity.normalized * speed;
            Debug.Log("Speed increased: " + speed);
        }
    }


    
   
    // Update is called once per frame
    void Update()
    {
        

      
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("right"))
        {
            Gameover();


        }
    }

    void Gameover()
    {
        gameoverpanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        string tag = collision.gameObject.tag; // Store the object's tag

        if (tag == "paddle" || tag == "right" || tag == "bound")     
        {
           if (Time.time - lastHitTime >= hitCooldown) // Prevents rapid sounds
           {
                    hitsound.PlayOneShot(hitsound.clip);
                    lastHitTime = Time.time;
           }
        }

        



    }
}

