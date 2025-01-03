using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float startHealth;
    public float currentHealth;
    private Animator Animation;
    private bool dead;

    public Vector3 PlayerRespawn;
    public LevelManager GameLevelManager;

    [System.Obsolete]
    void Start()
    {
        PlayerRespawn = transform.position;
        GameLevelManager = FindObjectOfType<LevelManager>();
    }

    private void Awake()
    {
        currentHealth = startHealth;
        Animation = GetComponent<Animator>();
    }

    public void Healthloose(float Damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - Damage, 0, startHealth);

        if(currentHealth > 0)
        {
            
            
           

        }
        else
        {
            if (!dead)
            {
                Animation.SetTrigger("Die");                            
                GetComponent<PlayerMovement>().enabled = true;
                dead = true;
                SceneManager.LoadScene("Retry screen");
            }
            
            
        }
    }
}