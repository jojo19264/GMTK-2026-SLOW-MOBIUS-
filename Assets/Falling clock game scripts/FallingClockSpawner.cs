using UnityEngine;
using System.Collections.Generic;

public class FallingClockSpawner : MonoBehaviour
{
    public GameObject fallingClock;
    public float spawnRate = 1;
    public float maxXOffset = 8;
    public float maxYOffset = 8;
    public int maxRandomNumOfClocks = 3;
    public float minDistanceBetweenClocks = 2;
    private float timer = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int numOfClocks = 1;
        if (timer < spawnRate) {
            timer += Time.deltaTime;
        }
        else {
            numOfClocks = Random.Range(1, maxRandomNumOfClocks+1);
            List<float> xOffsets = new List<float>();
            for (int i = 0; i < numOfClocks; i++) {
                float xOffset = Random.Range(-maxXOffset, maxXOffset);
                float distance = 0;
                bool invalidDistance = true;

                if (xOffsets.Count == 0) { invalidDistance = false; }

                for (int j = 0; j < xOffsets.Count; j++) {
                    distance = Mathf.Abs(xOffsets[j] - xOffset);
                    if (distance >= minDistanceBetweenClocks) {
                        invalidDistance = false;
                    }
                    else {
                        invalidDistance = true;
                        break;
                    }
                }
                if(invalidDistance) { break; }

                float yOffset = Random.Range(transform.position.y, transform.position.y + maxYOffset);

                Instantiate(fallingClock, new Vector3(xOffset, yOffset, 0), transform.rotation);
                xOffsets.Add(xOffset);
                timer = 0;
            }
        }
    }
}
