using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public Rigidbody rigbod;
    public GameObject GamObj;
    // Start is called before the first frame update
    void Start()
    {
        rigbod = gameObject.GetComponent<Rigidbody>();
        GamObj = GameObject.Find("Centre");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       if(Input.GetKey(KeyCode.W)) 
        {
            rigbod.AddForce(GamObj.transform.forward*400);
        } 
       if(Input.GetKey(KeyCode.S)) 
        {
            rigbod.AddForce(GamObj.transform.forward * -400);
        }
       if(gameObject.transform.position.y < -10)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
           
        }
    }
} 
           

