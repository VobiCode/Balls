using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Super_Spawn : MonoBehaviour
{
    public GameObject st;
    public float timer;
    public float numb_timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > numb_timer)
        {
            Instantiate(st, new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10)), gameObject.transform.rotation);
            timer = 0;
            numb_timer = Random.Range(6f, 11f);
        }
        timer = timer + Time.deltaTime;
    }
}
    