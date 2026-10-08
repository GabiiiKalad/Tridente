using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mosca : MonoBehaviour
{
    [SerializeField] private GameObject Estructuraa;
    [SerializeField] private GameObject Estructura;


    public void Menu()
    {

        Estructura.SetActive(false);
        Estructuraa.SetActive(true);



    }
    public void Reanudar()
    {

        Estructura.SetActive(true);
        Estructuraa.SetActive(false);

    }
}