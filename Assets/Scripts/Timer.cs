using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text UItexto;
    
    private int cont = 0;

    private void Awake()
    {
        InvokeRepeating("Cronometro", 0f, 1f);
    }

    void Cronometro()
    {
        
            if (cont == 60)
            {
                cont = 0;
            }
            else
            {
                cont++;
            }
            UItexto.text = cont.ToString();
        
        
    }
}
