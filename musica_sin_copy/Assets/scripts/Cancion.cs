using UnityEngine;

public class Cancion
{
    public string titulo;
    public string artista;
    public AudioClip clip;


    public Cancion(string titulo, string artista, AudioClip clip)
    {
        this.titulo = titulo;
        this.artista = artista;
        this.clip = clip;
    }

    public string Info() { 
    
    return titulo + " - " + artista;
    
    }

}
