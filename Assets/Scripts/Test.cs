using UnityEngine;

public class Test : MonoBehaviour
{


    public GameObject objetoAInstanciar;
    public Vector3 posicion;
    //public Transform lugarSpawn;

    void Start()
    {
            //Instantiate(objetoAInstanciar);/*Instancia el Prefab en donde esta ubicado por defecto el Prefab*/
            //Instantiate(objetoAInstanciar,transform.position,transform.rotation);/*Intancia el Prefab en la posición del objeto que lo llama*/
            //Instantiate(objetoAInstanciar,new Vector3(3,3,1),transform.rotation);/*Intancia el Prefab en la posición indicada explicitamente*/
            Instantiate(objetoAInstanciar,posicion,transform.rotation);/*Intancia el Prefab en la posición indicada definida en la variable tipo Vector3*/
            //Instantiate(objetoAInstanciar,lugarSpawn.position,transform.rotation);/*Intancia el Prefab en la otro GameObject(Ejemplo en un Objeto Vacio)*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
