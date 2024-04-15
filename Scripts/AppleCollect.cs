using UnityEngine;
using UnityEngine.UI;

public class AppleCollect : MonoBehaviour
{
    private int pickCounter = 0;

    [SerializeField] private Text pickablesText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ( collision.gameObject.CompareTag("Pickables"))
        {
            Destroy(collision.gameObject);
            pickCounter++;
            pickablesText.text = "Pickables: " + pickCounter;
        }
    }
   

}
