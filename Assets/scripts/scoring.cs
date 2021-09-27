using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoring : MonoBehaviour
{

    public static scoring instance;
    public Text score;
    int scoreStart = 0;
    string target;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        score.text = scoreStart.ToString();
        AddScore(target);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void AddScore(string target)
    {
        if (target == "1P")
        {
            scoreStart += 1;
            score.text = scoreStart.ToString();
        }
        else if (target == "3P")
        {
            scoreStart += 3;
            score.text = scoreStart.ToString();
        }
        else if (target == "5P")
        {
            scoreStart += 5;
            score.text = scoreStart.ToString();
        }
        else if (target == "7P")
        {
            scoreStart += 7;
            score.text = scoreStart.ToString();
        }
        else if(target == "10P")
        {
            scoreStart += 10;
            score.text = scoreStart.ToString();
        }

    }
}
