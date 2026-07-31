using NUnit.Framework;
using UnityEngine;
using GenericList = System.Collections.Generic.List<Cancion>;

public class Reproductot : MonoBehaviour
{
   public AudioSource audioSource;
   public GenericList canciones = new GenericList();
   public int indiceActual = 0;


    public AudioClip clip1;
    public AudioClip clip2;
    public AudioClip clip3;

    void Start()
    {
        
        canciones.Add(new Cancion("johnnybacon156-fah-469417", "Davo", clip1));
        canciones.Add(new Cancion("idoberg-relaxing-guitar-loop-v5-245859", "La cobra", clip2));
        canciones.Add(new Cancion("diamond_tunes-cinematic-sound-effect-327618", "Messi", clip3));
        
        audioSource = GetComponent<AudioSource>();
        CargarCancion(0);
    }


    void CargarCancion(int indice)
    {
        
        
            audioSource.clip = canciones[indiceActual].clip;
            audioSource.Play();
            indiceActual = indice;
        
    }

    void Reproducir()
    {
        audioSource.Play();
    }

    public void Pausar()
    {
        audioSource.Pause();
    }

    public void Siguiente()
    {
        if (indiceActual < canciones.Count - 1)
        {
            
            CargarCancion(indiceActual+1);
            Reproducir();
            indiceActual +=1;
        }
        else
        {
            CargarCancion(0);
            Reproducir();
            indiceActual = 0;
        }
    }

    public void Anterior()
    {
        if (indiceActual > 0)
        {
            CargarCancion(indiceActual - 1);
            Reproducir();
            indiceActual -= 1;
        }
        else
        {
            CargarCancion(canciones.Count - 1);
            Reproducir();
            indiceActual = canciones.Count - 1;
        }
    }


}
