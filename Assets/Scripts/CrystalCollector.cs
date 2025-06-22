using UnityEngine;
using UnityEngine.UI;  // Для UI Text

public class CrystalCollector : MonoBehaviour
{
    public int crystalsCollected = 0;
    public Text crystalText;  // Прив'яжіть UI Text в інспекторі

    private void Start()
    {
        UpdateCrystalText();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Crystal"))  // Кристал повинен мати тег "Crystal"
        {
            crystalsCollected++;
            UpdateCrystalText();

            Destroy(other.gameObject);  // Знищуємо підібраний кристал
        }
    }

    void UpdateCrystalText()
    {
        crystalText.text = "Кристали: " + crystalsCollected.ToString();
    }
}
