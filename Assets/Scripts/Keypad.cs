using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keypad : MonoBehaviour
{
    [SerializeField] private Text Ans;
    [SerializeField] private Animator Puerta;

    private string Answer = "777";
    public void Number(int Number)
    {
        Ans.text += Number.ToString();
    }
    public void Ejecutar()
    {
        if (Ans.text == Answer)
        {
            Ans.text = "CORRECTO";
            Puerta.SetBool("Open", true);

        }
        else
        {
            Ans.text = "INCORRECTO";
            StartCoroutine("ClearText");
        }

    }
    
    IEnumerator ClearText()
    {

        yield return new WaitForSeconds(.5f);

        Ans.text = "";
       
        
    }
}