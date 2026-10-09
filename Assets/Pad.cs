using UnityEngine;
using UnityEngine.UI;

public class PadNumericoVR : MonoBehaviour
{
    [Header("Código correcto")]
    public string codigoCorrecto = "777";

    [Header("Texto donde aparece el código")]
    public Text textoCodigo;

    [Header("Panel del pad")]
    public GameObject panelPad;

    [Header("Panel de videos (otro objeto)")]
    public GameObject panelVideos;

    private string codigoIngresado = "";

    void Start()
    {
        if (panelVideos != null)
            panelVideos.SetActive(false);

        ActualizarTexto();
    }

    // =========================
    // BOTONES NUMÉRICOS
    // =========================

    public void Boton(string number)
    {
        AgregarNumero(number);
    }

    // =========================
    // AGREGAR NÚMERO
    // =========================

    void AgregarNumero(string numero)
    {
        codigoIngresado += numero;

        ActualizarTexto();
    }


    // =========================
    // BORRAR
    // =========================

    public void Borrar()
    {
        codigoIngresado = "";

        ActualizarTexto();
    }


    // =========================
    // ENTER / CONFIRMAR
    // =========================

    public void Confirmar()
    {
        if (codigoIngresado == codigoCorrecto)
        {
            AbrirPanelVideos();
        }
        else
        {
            Debug.Log("Código incorrecto");

            codigoIngresado = "";

            ActualizarTexto();
        }
    }


    // =========================
    // ABRIR PANEL DE VIDEOS
    // =========================

    void AbrirPanelVideos()
    {
        if (panelPad != null)
            panelPad.SetActive(false);

        if (panelVideos != null)
            panelVideos.SetActive(true);
    }


    // =========================
    // MOSTRAR CÓDIGO
    // =========================

    void ActualizarTexto()
    {
        if (textoCodigo != null)
        {
            textoCodigo.text = codigoIngresado;
        }
    }
}