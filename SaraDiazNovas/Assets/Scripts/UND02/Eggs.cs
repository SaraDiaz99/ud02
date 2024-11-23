using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eggs : MonoBehaviour
{
    //Zona de propiedades
    public GameObject Egg;
    public Transform PosRotEgg;
    private float timeEgg = 2.0f;

    //Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {

            CreateEggs();

        }

    }

    private void CreateEggs()
    {

        GameObject cloneEgg = Instantiate(Egg, PosRotEgg.position, PosRotEgg.rotation);

        //Destruir el huevo cuando pasen 10 segundos
        Destroy(cloneEgg, timeEgg);
    }
}
