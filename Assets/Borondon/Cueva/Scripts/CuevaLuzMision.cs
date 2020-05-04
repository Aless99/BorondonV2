using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuevaLuzMision : MonoBehaviour
{

    public GameObject player;
    public GameObject luzMision;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject == player)
        {
            luzMision.SetActive(true);


        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {

            luzMision.SetActive(false);


        }
    }



}



