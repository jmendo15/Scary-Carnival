using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class JugTrigger : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText;
    public GameObject winTextObject;


    private void Start()
    {
        score = 0;
        SetScoreText();
        winTextObject.SetActive(false);
    }

    void SetScoreText()
    {
        scoreText.text = "Score: " + score.ToString();

        if (score >= 6)
        {
            winTextObject.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("JugTrigger"))
        {
            score = score + 1;
            SetScoreText();

            Debug.Log(scoreText.text);
        }
    }
}
