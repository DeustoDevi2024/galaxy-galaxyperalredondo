using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoEspacial : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Rotation();
        if (this.name != "Sun") {
            this.transform.position += Vector3.up;
        }

    }



    void Rotation()
    {
        this.transform.rotation *= Quaternion.Euler(0, 1, 0);
    }
}
