using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    //Zona de propiedades
    public GameObject Flower;
    public Transform PosRotFlower;
    private float timeFlower = 2.0f;
    private float thrustY = 100f;
    private float thrustZ = 400f;

    //Update is called once per frame
    void Update()
    {

            CreateFlower();

       
    }

    private void CreateFlower()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {


            GameObject cloneFlower = Instantiate(Flower, PosRotFlower.position, PosRotFlower.rotation);

            //El componente "rigidbody" con el que voy a trabajar es el de los clones de las flores
            Rigidbody rbFlower = cloneFlower.GetComponent<Rigidbody>();

            //"Vector3"para hacer referencia al eje Y global de la escena
            rbFlower.AddForce(Vector3.up * thrustY);
            //"transform.forward" para hacer referencia al eje Z de "PostRotFlower"
            rbFlower.AddForce(transform.forward * thrustZ);
            //Destruir la flor cuando pasen 2 segundos
            Destroy(cloneFlower, timeFlower);
            
        }
    }
}