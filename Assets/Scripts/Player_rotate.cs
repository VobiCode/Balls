using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_rotate : MonoBehaviour
{
    public float power;
    // Start is called before the first frame update
    void Start()
    {
        power = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) == true)
        {
            gameObject.transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * power);
        }
        if (Input.GetKey(KeyCode.D) == true)
        {
            gameObject.transform.Rotate(new Vector3(0, -1, 0) * Time.deltaTime * power);
        }
    }
}
      