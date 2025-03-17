using UnityEngine;

public class aiscript : MonoBehaviour
{
    public Rigidbody2D ai;
    public Rigidbody2D ball;
    public float offset = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ai = GetComponent<Rigidbody2D>();
        ball = GameObject.Find("ball").GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newposition = new Vector2(ai.position.x, ball.position.y + offset);

        ai.MovePosition(newposition);
    }
}
