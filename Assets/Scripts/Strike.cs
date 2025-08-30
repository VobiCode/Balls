using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strike : MonoBehaviour
{
    public GameObject Power_Boost_Pref;
    GameObject Power_Boost_Clone;
    bool Boost;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name != "Island")
        {
            if (Boost == true)
            {
                collision.gameObject.GetComponent<Rigidbody>().AddForce((collision.gameObject.transform.position - gameObject.transform.position) * 50000);
                Boost = false;
            }
            else
             {
                collision.gameObject.GetComponent<Rigidbody>().AddForce((collision.gameObject.transform.position - gameObject.transform.position) * 10000);
            }
        }
 
    }
    
    // Start is called before the first frame update
    void Start() 
    { 
         
    } 
     
    // Update is called once per frame 
    void Update() 
    { 
       
        if(Boost == true)
        {
            if(Power_Boost_Clone == null)
            {
                Power_Boost_Clone = Instantiate(Power_Boost_Pref);
            }
           
            Power_Boost_Clone.transform.position = gameObject.transform.position;
        }
        else
        {
            if(Power_Boost_Clone != null)
            {
              Destroy(Power_Boost_Clone);
            }  
        
        }

    }
     
    private void OnTriggerEnter(Collider other)
    {
        Boost = true;
        Destroy(other.gameObject);
    }
}
     
     