using UnityEngine;
using TMPro;

public class BallKiller : MonoBehaviour
{
    public TMP_Text scoreText;
    private int ballsKilled = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.CompareTag("Ball"))
        {
            Destroy(other.gameObject);
            ballsKilled++;
            scoreText.text = "Balls killed: " + ballsKilled.ToString();
        }
    }
}
