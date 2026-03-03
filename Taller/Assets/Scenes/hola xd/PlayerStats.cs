using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [Header("Health Settings")]
    [SerializeField] private float maxHealth = 100f;
    [SerializeField] private float currentHealth = 100f;

    [Header("Speed Settings")]
    [SerializeField] private float baseSpeed = 5f;
    private float speedMultiplier = 1f;

    [Header("Shield")]
    private bool isShieldActive = false;

    // --------------------
    // PROPIEDADES PÚBLICAS (solo lectura)
    // --------------------

    public float CurrentHealth => currentHealth;
    public float MaxHealth => maxHealth;
    public float CurrentSpeed => baseSpeed * speedMultiplier;
    public bool IsShieldActive => isShieldActive;

    // --------------------
    // MÉTODOS DEL MODELO
    // --------------------

    public void Heal(float amount)
    {
        if (amount <= 0f) return;

        currentHealth += amount;

        if (currentHealth > maxHealth)
            currentHealth = maxHealth;
    }

    public void SetSpeedMultiplier(float multiplier)
    {
        if (multiplier <= 0f) return;

        speedMultiplier = multiplier;
    }

    public void SetShield(bool active)
    {
        isShieldActive = active;
    }
}