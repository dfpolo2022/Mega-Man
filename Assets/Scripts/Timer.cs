using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text UItexto;
    public static Timer instanciar;
    
    private int cont = 0;
    public bool timerOn = true;

    private void Awake()
    {
        instanciar = this;

        if (timerOn)
        {
            InvokeRepeating("Cronometro", 0f, 1f);
        }
        else
        {
            finTiempo();
        }
        
    }

    void Cronometro()
    {
        
            if (cont == 59)
            {
                cont = 0;
            }
            else
            {
                cont++;
            }
            if (cont > 9)
            {
                UItexto.text = cont.ToString();
            }
            else
            {
                UItexto.text = "0" + cont.ToString();
            }        
    }

    public void finTiempo()
    {
        timerOn = false;
    }

}
