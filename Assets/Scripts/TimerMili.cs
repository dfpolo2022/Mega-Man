using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerMili : MonoBehaviour
{
    public Text UItexto;

    private int cont = 0;

    private void Awake()
    {
        InvokeRepeating("Cronometro", 0f, 0.01f);
    }

    void Cronometro()
    {
        if (cont == 99)
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
