using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerMinutes : MonoBehaviour
{
    public Text UItexto;

    private int cont = 0;

    private void Awake()
    {
        InvokeRepeating("Cronometro", 60f, 60f);
    }

    void Cronometro()
    {
        cont++;
        if (cont > 9)
        {
            UItexto.text = cont.ToString();
        }
        else
        {
            UItexto.text = "0"+ cont.ToString();
        }
        
    }


}
