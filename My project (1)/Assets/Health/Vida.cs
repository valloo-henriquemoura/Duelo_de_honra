using UnityEngine;
using UnityEngine.UI;

public class Vida : MonoBehaviour
{
    [Header("Health Settings")]
    public float maxHealth = 30f;
    private float currentHealth;

    [Header("UI Settings")]
    public Image healthBar; // Refer�ncia � barra de vida (UI)

    void Start()
    {
        // Configura a vida inicial
        currentHealth = maxHealth;
        UpdateHealthBar();
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;

        // Garante que a vida n�o fique negativa
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

    // M�todo chamado quando o personagem morre
    private void Die()
    {
        Debug.Log($"{gameObject.name} morreu!");
        // Adicione l�gica de morte aqui trocando a anima��o
        Destroy(gameObject); // Remove o personagem da cena
    }
}

