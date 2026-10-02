using UnityEngine;

public class Podcast : IContenidoAudio
{
    public string titulo;
    public string programa;
    public AudioClip clip;
    public Sprite caratula;


    public Podcast(string titulo, string programa, AudioClip clip, Sprite caratula)
    {
        this.titulo = titulo;
        this.programa = programa;
        this.clip = clip;
        this.caratula = caratula;
    }

    public string GetInfo()
    {

        return titulo + " - " + programa;

    }

    public AudioClip GetClip()
    {
        return clip;
    }

    public Sprite GetCaratula()
    {
        return caratula;
    }
}
