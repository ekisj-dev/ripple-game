using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{

    public GameObject obj;

    public float secondsPerSpawn;

    private float secondsSinceSpawn = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        secondsSinceSpawn += Time.deltaTime;

        if (secondsSinceSpawn > secondsPerSpawn)
        {
            GameObject.Instantiate(obj, this.gameObject.transform);
            secondsSinceSpawn = 0.0f;
        }
    }
}
