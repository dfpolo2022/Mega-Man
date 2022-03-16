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
        UItexto.text = cont.ToString();
    }


}
