using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManage : MonoBehaviour
{   int diamantes = 0;

    public TextMeshProUGUI contador;
    public void AdicionarDiamante(){
        diamantes++;
        contador.text = "diamantes: " + diamantes;
    } 
    
    


}
