using UnityEngine;

public class Proyectil : MonoBehaviour
{

    public float speed = 0.09f;
    public Vector3 direccion=new Vector3(0.01f,0,0);

    void Update()
    {
        //transform.position += new Vector3(0.01f,0,0)*speed;
        transform.position += direccion*speed;    
    }
}
