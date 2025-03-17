using UnityEngine;

public class gamepausescript : MonoBehaviour
{
    public GameObject playbutton;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 0f;
        playbutton.SetActive(true);
    }
    public void Startgame()
    {
        Time.timeScale = 1f;
        playbutton.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
