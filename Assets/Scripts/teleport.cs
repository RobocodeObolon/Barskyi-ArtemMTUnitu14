using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    public Transform teleportTarget; // Куди телепортувати гравця

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Перевірка, чи це гравець
        {
            other.transform.position = teleportTarget.position;

        }

    }
}