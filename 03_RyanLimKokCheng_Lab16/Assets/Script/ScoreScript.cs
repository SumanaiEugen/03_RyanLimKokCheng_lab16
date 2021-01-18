using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text Scoretext;
    public static ScoreScript instance;
    float Score = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void addscore()
    {
        Score++;
        Scoretext.GetComponent<Text>().text = "Score : " + Score;
    }
}
