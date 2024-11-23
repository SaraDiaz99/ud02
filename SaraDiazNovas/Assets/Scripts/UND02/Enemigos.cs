using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigos : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider infoAccess)
    {

        if (infoAccess.CompareTag("AttackZombie"))
        {

            Destroy(this.gameObject);

        }

    }

}
