using UnityEngine;
using UnityEngine.UI;

public class CharacterHealth : MonoBehaviour
{
    [Header("Health Settings")]
    public float maxHealth = 100f;
    private float currentHealth;

    [Header("UI Settings")]
    public Image healthBar; // Referência à barra de vida (UI)

    void Start()
    {
        // Configura a vida inicial
        currentHealth = maxHealth;
        UpdateHealthBar();
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;

        // Garante que a vida não fique negativa
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

        // Atualiza a barra de vida
        UpdateHealthBar();

        // Verifica se o personagem morreu
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    // Atualiza a barra de vida com base na vida atual
    private void UpdateHealthBar()
    {
        if (healthBar != null)
        {
            healthBar.fillAmount = currentHealth / maxHealth;
        }
    }

    // Método chamado quando o personagem morre
    private void Die()
    {
        Debug.Log($"{gameObject.name} morreu!");
        // Adicione lógica de morte aqui trocando a animação
        Destroy(gameObject); // Remove o personagem da cena
    }
}
