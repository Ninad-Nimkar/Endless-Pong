using UnityEngine;
using UnityEngine.SceneManagement;

public class restartscript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void restartgame()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
        PlayerPrefs.GetInt("gamestarted", 0);

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
