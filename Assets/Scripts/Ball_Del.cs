using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody RigBod;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        RigBod = gameObject.GetComponent<Rigidbody>();
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (gameObject.transform.position.y < -3)
        {
            Destroy(gameObject);
        }
        RigBod.AddForce((Player.transform.position - gameObject.transform.position) * 54);


    } 
} 
    
       