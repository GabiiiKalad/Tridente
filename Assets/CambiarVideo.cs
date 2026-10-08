using UnityEngine;
using UnityEngine.Video;

public class SelectorVideosVR : MonoBehaviour
{
    [Header("VideoPlayer específico")]
    public VideoPlayer videoPlayer;

    [Header("Videos")]
    public VideoClip video1;
    public VideoClip video2;
    public VideoClip video3;
    public VideoClip video4;


    // =========================
    // BOTÓN VIDEO 1
    // =========================

    public void BotonVideo1()
    {
        CambiarVideo(video1);
    }


    // =========================
    // BOTÓN VIDEO 2
    // =========================

    public void BotonVideo2()
    {
        CambiarVideo(video2);
    }


    // =========================
    // BOTÓN VIDEO 3
    // =========================

    public void BotonVideo3()
    {
        CambiarVideo(video3);
    }


    // =========================
    // BOTÓN VIDEO 4
    // =========================

    public void BotonVideo4()
    {
        CambiarVideo(video4);
    }


    // =========================
    // CAMBIAR VIDEO
    // =========================

    void CambiarVideo(VideoClip nuevoVideo)
    {
        if (nuevoVideo == null)
        {
            Debug.LogWarning("No hay un video asignado.");
            return;
        }

        videoPlayer.Stop();

        videoPlayer.clip = nuevoVideo;

        videoPlayer.Play();
    }
}