using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balll_Spawn : MonoBehaviour
{
    public GameObject st;
    public float timer;
    public float numb_timer;
    public int Bad_Players_Count;
    // Start is called before the first frame update
    void Start()
    {

    }
     
    // Update is called once per frame
    void Update()
    {
        //if (timer > numb_timer)
        //{
        //    Instantiate(st, new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10)), gameObject.transform.rotation);
        //    timer = 0;
        //    numb_timer = Random.Range(3f, 5f);
        //}
        //timer = timer + Time.deltaTime;
        if (GameObject.FindGameObjectsWithTag("Teg").Length == 0)
        {
            for (int i = 0; i < Bad_Players_Count; i++)
            {
                Instantiate(st, new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10)), gameObject.transform.rotation);
            }
            Bad_Players_Count++;
        }
    }   
} 
       
  

 
 


