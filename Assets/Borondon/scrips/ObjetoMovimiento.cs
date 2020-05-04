using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoMovimiento : MonoBehaviour
{
    public float speed = 5.0f;
    public float x, y;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, y * Time.deltaTime * speed);

    }
}
