using UnityEngine;
using UnityEngine.Events;

public class HealthBehaviour : MonoBehaviour
{   
    public int maxHealth, startHealth;

    public int currentHealth { get; private set; }

    public UnityEvent<int> healthChanged;
    public UnityEvent playerDamaged;

    private void Start()
    {
        currentHealth = startHealth;
    }

    public void TakeDamage(int damage)
    {
        TestEvent();
        ModifyHealth(-damage);
        
    }

    private void TestEvent()
    {
        Debug.Log("Ca marche");
        playerDamaged.Invoke();
    }
    public void Heal(int health)
    {
        ModifyHealth(health);
    }

    private void ModifyHealth(int modifier)
    {
        currentHealth = Mathf.Clamp(currentHealth + modifier, 0, maxHealth);
        healthChanged.Invoke(currentHealth);
    }
}
