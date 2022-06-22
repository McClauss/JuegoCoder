using UnityEngine;

public class Bala : MonoBehaviour
{

    public GameObject prefabBala;

    public Transform posicionTorreta;

    void Start()
    {
        //Crearproyectil();
    }

    // Update is called once per frame
    void Update()
    {
        Crearproyectil();
    }

    void Crearproyectil(){
        if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate(prefabBala,posicionTorreta.position,transform.rotation);
        }
        //Instantiate(prefabBala,posicionTorreta.position,transform.rotation);
    }
}
