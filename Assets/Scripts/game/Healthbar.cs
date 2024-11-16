using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Healthbar : MonoBehaviour
{
    public Scrollbar healthBar; // Reference to the Scrollbar UI element
    public GameObject spike; // Reference to the Spike GameObject
    public float maxHealth = 100f;
    private float currentHealth;
    private Coroutine damageCoroutine;

    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthBar();
    }

    void Update()
    {
        // Remove or comment out the code that decreases health over time
        // if (currentHealth > 0)
        // {
        //     currentHealth -= Time.deltaTime * 10f;
        //     UpdateHealthBar();
        // }
    }

    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        if (currentHealth < 0)
        {
            currentHealth = 0;
        }
        UpdateHealthBar();
        Debug.Log("Health decreased. Current health: " + currentHealth);
    }

    public void Heal(float amount)
    {
        currentHealth += amount;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        UpdateHealthBar();
    }

    private void UpdateHealthBar()
    {
        healthBar.size = currentHealth / maxHealth;
    }

    private IEnumerator DamageOverTime(float amount, float interval)
    {
        while (true)
        {
            TakeDamage(amount);
            yield return new WaitForSeconds(interval);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter called with: " + other.gameObject.name);
        if (other.gameObject == spike)
        {
            Debug.Log("Player collided with spike");
            if (damageCoroutine == null)
            {
                damageCoroutine = StartCoroutine(DamageOverTime(10f, 2f));
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("OnTriggerExit called with: " + other.gameObject.name);
        if (other.gameObject == spike)
        {
            Debug.Log("Player exited spike collision");
            if (damageCoroutine != null)
            {
                StopCoroutine(damageCoroutine);
                damageCoroutine = null;
            }
        }
    }
}