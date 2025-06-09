using UnityEngine;

public class ApplyCollisionRules : MonoBehaviour
{
    public Transform player;                // Referência ao jogador
    public float triggerDistance = 1.0f;    // Distância de ativação
    public Transform spawnPoint;

    private CharacterController controller;

    void Start()
    {
        if (player != null)
        {
            controller = player.GetComponent<CharacterController>();
        }
    }

    void Update()
    {
        if (player != null && controller != null)
        {
            float distance = Vector3.Distance(transform.position, player.position);

            if (distance <= triggerDistance)
            {
                Debug.Log("encostou");

                // Desativa temporariamente o CharacterController
                controller.enabled = false;

                // Teleporta o jogador
                player.position = spawnPoint.position;

                // Reativa o CharacterController
                controller.enabled = true;
            }
        }
    }
}
