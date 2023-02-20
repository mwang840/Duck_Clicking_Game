using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthController : MonoBehaviour
{
    // Start is called before the first frame update
    public int playerHealth;
    [SerializeField] private Image[] hearts;

   

    void Start()
    {
        UpdateHealth();
    }

    public void UpdateHealth()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i >= playerHealth)
            {
                hearts[i].color = Color.black;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
