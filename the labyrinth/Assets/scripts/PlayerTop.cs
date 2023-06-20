using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTop : MonoBehaviour
{
    public int velocidade;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //pegando input do teclado
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");


        float angulo = Mathf.Atan2(y , x ) * Mathf.Rad2Deg +90;
        transform.rotation = Quaternion.Euler(0,0,angulo);

        //imprimindo valores no console
        //Debug.Log("Horizontal: " + x); 
        //Debug.Log("Vertical: " + y);

        Vector3 inputTeclado = new Vector3(x, y, 0);
        transform.position += inputTeclado * velocidade * Time.deltaTime;

    }
}
