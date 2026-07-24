using Unity.VisualScripting;
using UnityEngine;

public class FallingClockTriggers : MonoBehaviour
{
    public LogicScriptFallingClocks logic;
    public float timeBetweenTriggers = 0.3f; 
    private float timeSinceIncTrigger;
    private float timeSinceDecTrigger;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScriptFallingClocks>();
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceIncTrigger += Time.deltaTime;
        timeSinceDecTrigger += Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        // 6 - Increment layer
        // 7 - Decrement layer
        if (collision.gameObject.layer == 6 && timeSinceIncTrigger > timeBetweenTriggers) {
            Debug.Log($"Avoided Clock Collision: +1 score . Time since last trigger{timeSinceIncTrigger}");
            timeSinceIncTrigger = 0;
            logic.addScore();
        }
        else if (collision.gameObject.layer == 7 && timeSinceDecTrigger > timeBetweenTriggers) {
            Debug.Log("Clock Collision: -2 score");
            timeSinceDecTrigger = 0;
            logic.removeScore(2);
        }
    }

}
