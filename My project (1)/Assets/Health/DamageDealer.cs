using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    public float damage = 10f; // Dano causado por ataque

    void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica se o objeto que colidiu tem o script CharacterHealth
        CharacterHealth targetHealth = other.GetComponent<CharacterHealth>();
        if (targetHealth != null)
        {       
            Debug.Log("Atualizando barra de vida");
            // Aplica dano ao personagem
            targetHealth.TakeDamage(damage);
        }
    }
}
