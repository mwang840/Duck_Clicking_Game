using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject duck;
    [SerializeField] private Vector2 spawnPosition;
    public void SpawnDuck()
    {
        GameObject duckling = Instantiate(duck, spawnPosition, Quaternion.identity);
        duckling.GetComponent<ClickOnDuck>().RandomSpeed();
    }
    void Start()
    {
        InvokeRepeating(nameof(SpawnDuck), 5, 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
