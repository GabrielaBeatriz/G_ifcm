using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PegaMoeda : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("diamante1"))
        {
            Destroy(col.gameObject);
            FindObjectOfType<GameManage>().AdicionarDiamante();
        }
    }
}
