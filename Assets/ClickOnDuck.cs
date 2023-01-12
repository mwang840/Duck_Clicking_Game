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
    }
    

    // Update is called once per frame
    void Update()
    {
        
        Vector3 velocity = new Vector3(xSpeed, ySpeed, 0);
        
        transform.Translate(velocity * Time.deltaTime);
    }
}
