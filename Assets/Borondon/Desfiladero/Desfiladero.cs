using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desfiladero : MonoBehaviour
{

    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {

            player.GetComponent<TestPlayer>().movimientohorizontal = true;

            player.transform.Rotate(new Vector3(0,90,0));

            Debug.Log("dentro");

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            player.transform.Rotate(new Vector3(0, -90, 0));

            player.GetComponent<TestPlayer>().movimientohorizontal = false;
            player.GetComponent<Animator>().SetBool("DesfiladeroCamOn", false);

        }
    }
}
