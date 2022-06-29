using UnityEngine;

public class UsoIf : MonoBehaviour
{
    int vidaJugador = 25;
    public float speed=2;
    public float tiempo=10f;
    public float tiempoRestante;
    GameObject proyectilPrefab; 

    void Start()
    {
        ResetearTemporizador();//funcion para resetear el contador de tiempo
        /*
        if(vidaJugador<=0){
            Debug.Log("El jugador ha Muerto ");
        }
        else
        {
            Debug.Log("El jugador sigue vivo ");
        }*/
    }

    void Update()
    {
        MovimientoJugador();
        Temporizador();//llama el temporizador en cada frame
        Disparar();
    }

    void ResetearTemporizador(){
        tiempoRestante = tiempo;
    }

    void Temporizador(){
        tiempoRestante -= Time.deltaTime;//Contador en descenso, por ejemplo para una bomba
        if (tiempoRestante<=0){
            Debug.Log(" Tiempo Agotado");
            ResetearTemporizador();
        }
        
        
    }

    void Disparar(){
        if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate(proyectilPrefab, transform.position,transform.rotation);
        }
    }

    void MovimientoJugador(){

    float hor= Input.GetAxis("Horizontal");//Lee el input que corresponda al eje X. Bien venga de joistick,control, teclado (AWSD o flechas), etc. GetAxisRaw mueve de 0 a 1, es decir mas rapido o para saltar por ejemplo
    float ver= Input.GetAxis("Vertical");//Lee el input que corresponda al eje Y Bien venga de joistick,control, teclado (AWSD o flechas), etc.

    Debug.Log("Horizontal" + hor);
    Debug.Log("Vertical" + ver);

    //transform.Translate(new Vector3(hor,0,ver));
    transform.Translate(new Vector3(hor,0,ver)*speed*Time.deltaTime);

    /*FORMA DETECCION DEL INPUT OPCION 1
    *********************************************************************************************
         //Para mover objeto al presionar la tecla W o flecha arriba (Lo muve hacia atras al adelante)
        if(Input.GetKey(KeyCode.W)){
            transform.Translate(new Vector3(0,0,0.01f));
        }
        //Para mover objeto al presionar la tecla S (Lo muve hacia atras al atras)
        if(Input.GetKey(KeyCode.S)){
            transform.Translate(new Vector3(0,0,-0.01f));
        }
        //Para mover objeto al presionar la tecla A (Lo muve hacia atras al izquierda)
        if(Input.GetKey(KeyCode.A)){
            transform.Translate(new Vector3(-0.01f,0,0));
        }
        //Para mover objeto al presionar la tecla D (Lo muve hacia atras al derecha)
        if(Input.GetKey(KeyCode.D)){
            transform.Translate(new Vector3(0.01f,0,0));
        }*/

        /* 
            //Si presioné X tecla
            if(Input.GetKey(KeyCode.Space)){
                Debug.Log("Ha presionado Espacio");
            }
            //Si solté X tecla se soltó
            if(Input.GetKeyUp(KeyCode.Space)){
                Debug.Log("Ha soltado Espacio");
            }
       */

        /*
            //Para mover objeto al presionar la tecla W (Lo muve hacia atras al adelante)
            if(Input.GetKey(KeyCode.UpArrow)){
                transform.Translate(new Vector3(0,0,0.01f));
            }
            //Para mover objeto al presionar la tecla S (Lo muve hacia atras al atras)
            if(Input.GetKey(KeyCode.DownArrow)){
                transform.Translate(new Vector3(0,0,-0.01f));
            }
            //Para mover objeto al presionar la tecla A (Lo muve hacia atras al izquierda)
            if(Input.GetKey(KeyCode.LeftArrow)){
                transform.Translate(new Vector3(-0.01f,0,0));
            }
            //Para mover objeto al presionar la tecla D (Lo muve hacia atras al derecha)
            if(Input.GetKey(KeyCode.RightArrow)){
                transform.Translate(new Vector3(0.01f,0,0));
            }
        */
               
        /*la del profe
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0,0,0.1f));
        }

        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0,0,-0.1f));
        }

        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-0.1f,0,0));
        }

         if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(0.1f,0,0));
        }

        */
    }
}
