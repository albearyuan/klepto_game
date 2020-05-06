using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;
    public Text healthText;

    public PlayerController player;

    private bool isRespawning;
    private Vector3 respawnLocation;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;

        respawnLocation = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r")) {
            Respawn();
        }
    }

    public void DamagePlayer(int damage) {
        currentHealth -= damage;

        if (currentHealth <= 0) {
            Respawn();
        } else {
            healthText.text = "Health: " + currentHealth;
        }
    }

    public void Respawn() {
        GameObject playerObject = GameObject.Find("Player");
        CharacterController charController  = player.GetComponent<CharacterController>();

        charController.enabled = false;

        player.transform.position = respawnLocation;
        charController.enabled = true;
        currentHealth = maxHealth;
        healthText.text = "Health: " + currentHealth;
    }

    public void SetSpawnPoint() {
        respawnLocation = player.transform.position;
    }
}
