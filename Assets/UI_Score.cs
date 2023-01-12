using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Score : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private ScoreCounter score;
    [SerializeField] private Text scoreTrackerText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreTrackerText.text = score.GetScore().ToString();

    }
}
