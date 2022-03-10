using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{

    public GameObject Circle;
    public float frequency;
    public int startTime;

    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("SpawnCircle", startTime, frequency);

    }

    // Update is called once per frame
    void SpawnCircle()
    {
        Instantiate(Circle, transform.position, Quaternion.identity);
    }
}
