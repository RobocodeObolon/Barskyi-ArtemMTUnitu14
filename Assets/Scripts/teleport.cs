using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    public Transform teleportTarget; // ���� ������������� ������

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // ��������, �� �� �������
        {
            other.transform.position = teleportTarget.position;

        }

    }
}