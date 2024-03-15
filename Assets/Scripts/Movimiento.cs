using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.transform.position += Vector3.up*5;

        }else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            this.transform.position += Vector3.down*5;

        }else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

            this.transform.position += Vector3.left*5;

        }else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.transform.position += Vector3.right*5;
        }
    }
}
