using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.PlayerLoop;

public class scoringsystem : MonoBehaviour
{
    public int score = 1;   
    public TextMeshProUGUI scoretext;
    

    void Start()
    {
        Updatescoretext();
        InvokeRepeating("IncreaseScore", 1f, 1f);
    }

    // Update is called once per frame
    void IncreaseScore()
    {
        score += 1;
        Updatescoretext();

        
    }


    public void Updatescoretext()
    {
        scoretext.text = "Score:" + score;
    }
}

