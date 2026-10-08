using UnityEngine;
using UnityEngine.Video;

public class DetectaZonaAudioVideo : MonoBehaviour
{
    [Header("Objeto que debe entrar en esta zona")]
    public GameObject objetoQueEntra;

    [Header("Audio")]
    public AudioSource audioSource;

    [Header("Video (en otro objeto)")]
    public VideoPlayer videoPlayer;
    public VideoClip videoAlEntrar;

    private Collider zona;
    private Collider colliderObjeto;
    private bool estabaDentro = false;
    private bool pausadoPorZona = false;

    void Start()
    {
        zona = GetComponent<Collider>();
        if (objetoQueEntra != null)
            colliderObjeto = objetoQueEntra.GetComponentInChildren<Collider>();

        if (zona == null || colliderObjeto == null)
            Debug.LogWarning("Falta un Collider en la zona o en el objeto que entra.", this);
    }

    void Update()
    {
        if (zona == null || colliderObjeto == null) return;

        bool estaDentro = zona.bounds.Intersects(colliderObjeto.bounds);

        if (estaDentro && !estabaDentro) Entrar();
        else if (!estaDentro && estabaDentro) Salir();

        estabaDentro = estaDentro;
    }

    void Entrar()
    {
        // Audio: continúa si estaba pausado, o empieza
        if (audioSource != null)
        {
            if (pausadoPorZona) audioSource.UnPause();
            else audioSource.Play();
        }
        pausadoPorZona = false;

        // Video: se reproduce mientras esté dentro
        if (videoPlayer != null)
        {
            if (videoAlEntrar != null && videoPlayer.clip != videoAlEntrar)
                videoPlayer.clip = videoAlEntrar;

            videoPlayer.Play();
        }
    }

    void Salir()
    {
        // Audio: pausa
        if (audioSource != null)
        {
            audioSource.Pause();
            pausadoPorZona = true;
        }

        // Video: se detiene al salir
        if (videoPlayer != null)
            videoPlayer.Pause();
    }
}