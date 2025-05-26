using UnityEngine;

public class SideToSideMovement : MonoBehaviour
{
    public float speed = 2f;             // Velocidade do movimento
    public float distance = 3f;          // Distância máxima para cada lado

    private Vector3 startPosition;       // Posição inicial do objeto

    void Start()
    {
        startPosition = transform.position;  // Salva a posição inicial
    }

    void Update()
    {
        // Calcula o novo valor X usando seno para movimento suave de vai-e-volta
        float xOffset = Mathf.Sin(Time.time * speed) * distance;

        // Aplica o deslocamento mantendo Y e Z fixos
        transform.position = new Vector3(startPosition.x + xOffset, startPosition.y, startPosition.z);
    }
}