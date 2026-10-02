public interface IMotorAudio
{
    void Cargar(IContenidoAudio contenido);
    void Reproducir();
    void Pausar();
    float Duracion();
    float Tiempo { get; set; }
}
