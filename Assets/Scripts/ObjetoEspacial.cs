using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoEspacial : MonoBehaviour
{
    public float speed;
    public float speedMercury;
    public float speedVenus;
    public float speedTierra;
    public float speedMarte;
    public float speedJupiter;
    public float speedSaturno;
    public float speedUrano;
    public float speedNeptuno;

    // Start is called before the first frame update
    void Start()
    {
        speed = 0.25f;
        speedMercury = 0.3f;
        speedTierra = 0.20f;
        speedMarte = 0.18f;
        speedJupiter = 0.15f;
        speedSaturno = 0.21f;
        speedUrano = 0.19f;
        speedNeptuno = 0.15f;
    }

    // Update is called once per frame
    void Update()
    {
        Rotation();
        
        
    }



    void Rotation()
    {
        
        if (this.name == "EmptyMercury")
        {
            this.transform.rotation *= Quaternion.Euler(0, speedMercury, 0);
        }
        if (this.name == "Sun")
        {
            this.transform.rotation *= Quaternion.Euler(0, speed, 0);
        }
        if (this.name == "EmptySaturno")
        {
            this.transform.rotation *= Quaternion.Euler(0, speedSaturno, 0);
        }
        if (this.name == "EmptyTierra")
        {
            this.transform.rotation *= Quaternion.Euler(0, speedTierra, 0);
        }
        if (this.name == "EmptyJupiter")
        {
            this.transform.rotation *= Quaternion.Euler(0, speedJupiter, 0);
        }
        if (this.name == "EmptyNeptuno")
        {
            this.transform.rotation *= Quaternion.Euler(0, speedNeptuno, 0);
        }
        if (this.name == "EmptyMarte")
        {
            this.transform.rotation *= Quaternion.Euler(0, speedMarte, 0);
        }
        if (this.name == "EmptyUrano")
        {
            this.transform.rotation *= Quaternion.Euler(0, speedUrano, 0);
        }

    }
    
    void transformElipse()
    {
        //this.transform.position = new Vector3(Mathf.Pow(Mathf.Pow(majorAxis, 2) * Mathf.Pow(Mathf.Cos(Time.deltaTime*speed), 2), 1 / 2),0, Mathf.Pow(Mathf.Pow(minorAxis, 2) * Mathf.Pow(Mathf.Cos(Time.deltaTime*speed), 2), 1 / 2));
        //this.transform.position = new Vector3(majorAxis * Mathf.Cos(angle), 0, minorAxis * Mathf.Sin(angle));
    }
}
