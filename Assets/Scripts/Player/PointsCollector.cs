using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointsCollector : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool collectingIsEnabled;
    public TextMeshProUGUI ScoreTextBox;

    public int Score;

    // Start is called before the first frame update
    void Start()
    {
        collectingIsEnabled = false;
        rb = GetComponent<Rigidbody2D>();
        Score = 0;
        ScoreTextBox.SetText(Score.ToString());
        InvokeRepeating("UpdateScore", 1f, 1f);  //1s delay, repeat every 1s   
    }

    // Update is called once per frame
    void Update()
    {
    }

    void UpdateScore() 
    {
        if (this.collectingIsEnabled)
        {
            Score += 1;
            ScoreTextBox.SetText(Score.ToString());
        }
    }

    void FixedUpdate() 
    {
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Border")
        {
            this.collectingIsEnabled = true;
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if(col.gameObject.tag == "Border")
        {
            this.collectingIsEnabled = false;
        }
    }
}
