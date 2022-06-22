using UnityEngine;

public class Bala : MonoBehaviour
{

    public GameObject prefabBala;

    public Transform posicionTorreta;
    public Transform posicionTorretaJ;
    public Transform posicionTorretaK;
    public Transform posicionTorretaL;

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
        if(Input.GetKeyDown(KeyCode.J)){
            Instantiate(prefabBala,posicionTorretaJ.position,transform.rotation);
        }
        if(Input.GetKeyDown(KeyCode.K)){
            Instantiate(prefabBala,posicionTorretaK.position,transform.rotation);
        }
        if(Input.GetKeyDown(KeyCode.L)){
            Instantiate(prefabBala,posicionTorretaL.position,transform.rotation);
        }
        //Instantiate(prefabBala,posicionTorreta.position,transform.rotation);
    }
}
