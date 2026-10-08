using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public Animator Sombra;

    private void OnTriggerEnter(Collider other)
    {
        Sombra.Play("Sombra");
    }
}
