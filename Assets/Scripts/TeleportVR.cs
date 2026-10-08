using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit; // Necesario para las interacciones de XR

public class TeleportVR : MonoBehaviour
{
    // Asigna la posición de destino (un Empty GameObject en la escena)
    public Transform teleportDestination;

    // Asigna el XR Rig que quieres mover (puedes asignarlo desde el inspector o obtenerlo en el Start)
    public GameObject xrRig;

    // Método que se llama cuando el XR Rig entra en el trigger
    private void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto que entró es el XR Rig
        if (other.gameObject == xrRig)
        {
            // Mueve el XR Rig a la posición de teletransporte
            xrRig.transform.position = teleportDestination.position;
        }
    }
}
