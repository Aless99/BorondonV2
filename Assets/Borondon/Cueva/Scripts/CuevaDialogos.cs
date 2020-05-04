using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CuevaDialogos : MonoBehaviour
{

    public GameObject panelDialogo;
    public string textoDialogo;
    public GameObject player;

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

            panelDialogo.SetActive(true);

            GameObject.Find("TextCharla").GetComponent<Text>().text=textoDialogo;

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {

            panelDialogo.SetActive(false);


        }
    }

}
