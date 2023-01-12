using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private int score;

    public void AddScore()
    {
        score++;
    }

    public int GetScore()
    {
        return score;
    }
    void Start()
    {
        score = 0;
    }

}
