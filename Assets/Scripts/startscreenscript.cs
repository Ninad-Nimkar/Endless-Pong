using UnityEngine;
using UnityEngine.SceneManagement;

public class startscreenscript : MonoBehaviour
{
    public GameObject startscreen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        Debug.Log("Start Scene Loaded Successfully");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Startgame()
    {
        Debug.Log("Play Button Clicked");
        SceneManager.LoadScene("Game scene");
    } 

    
}
