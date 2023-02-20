using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class ClickOnDuck : MonoBehaviour, IPointerClickHandler
{
    //reference to sprite render
    [SerializeField] private SpriteRenderer sr;
    [SerializeField] private float xSpeed;
    [SerializeField] private float ySpeed;
    [SerializeField] private ScoreCounter playerScore;
    private HealthController health;
    public int boundary = 20;

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Clicked");
    }

    public void RandomSpeed()
    {
        xSpeed = Random.Range(-2.01f, 2.01f);
        ySpeed = Random.Range(-2.01f, 2.01f);
    }
    void OnMouseDown()
    {
        
        playerScore.AddScore();
        Destroy(gameObject);
    }

    void Awake()
    {
    
    }
    // Start is called before the first frame update
    void Start()
    {
        playerScore = GameObject.Find("Score").GetComponent<ScoreCounter>();
        health = GameObject.Find("HealthController").GetComponent<HealthController>();

    }
    

    // Update is called once per frame
    void Update()
    {
        
        Vector3 velocity = new Vector3(xSpeed, ySpeed, 0);
        
        transform.Translate(velocity * Time.deltaTime);

        if (transform.position.x > boundary || transform.position.x < -boundary || transform.position.y > boundary || transform.position.y < -boundary)
        {
            health.playerHealth--;
            health.UpdateHealth();
            Destroy(gameObject);
        }
    }
}
