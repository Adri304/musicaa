using UnityEngine;

public class Cancion: IContenidoAudio
{
    public string titulo;
    public string artista;
    public AudioClip clip;
    public Sprite caratula;


    public Cancion(string titulo, string artista, AudioClip clip, Sprite caratula)
    {
        this.titulo = titulo;
        this.artista = artista;
        this.clip = clip;
        this.caratula = caratula;
    }

    public string GetInfo()
    {
    
    return titulo + " - " + artista;
    
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
