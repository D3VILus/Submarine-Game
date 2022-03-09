using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnMovement: MonoBehaviour
{
    float Vspeed, Hspeed, Zspeed;



    // Start is called before the first frame update
    void Start()
    {
        Hspeed = 1;
        Vspeed = 1;
        Zspeed = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {

            gameObject.transform.position = new Vector3(transform.position.x - (Hspeed), transform.position.y, transform.position.z);
        }
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.position = new Vector3(transform.position.x + (Hspeed), transform.position.y, transform.position.z);
        }
        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.position = new Vector3(transform.position.x, transform.position.y + (Vspeed), transform.position.z);
        }
        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.position = new Vector3(transform.position.x, transform.position.y - (Vspeed), transform.position.z);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - (Zspeed));
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + (Zspeed));
        }
    }
}
