using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    public float Speed;
    public float Max_size;
    public float Min_size;
    public float shaurma;
    bool IsGrow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.localScale.y > Max_size)
        {
            IsGrow = false;
        }
        if (gameObject.transform.localScale.y < Min_size)
        {
            IsGrow = true;
        }
        if(IsGrow == true)
        {
            gameObject.transform.localScale = gameObject.transform.localScale + new Vector3(1, 1, 1) * Time.deltaTime * Speed;
        }
        if (IsGrow == false)
        {
            gameObject.transform.localScale = gameObject.transform.localScale - new Vector3(1, 1, 1) * Time.deltaTime * Speed;
        }
        gameObject.transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * shaurma);
        if (gameObject.transform.position.y < -2.6)
        {
            Destroy(gameObject);
        }
    } 
}
  