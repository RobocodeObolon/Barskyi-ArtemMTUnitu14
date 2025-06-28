using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bonus : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("crystal")){
            score++;
            Destroy(other.gameObject);
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        scoreText.text = "crystal: " + score;
    }
}
