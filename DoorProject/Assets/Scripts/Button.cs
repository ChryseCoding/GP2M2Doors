using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public GameObject Door;
    public GameObject Player;
    public GameObject button;
    public GameObject button2;
    public GameObject button3;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "correct")
        {
            Destroy(Door);
            Destroy(button);
            Destroy(button2);
            Destroy(button3);

            
        }
        else if (collision.gameObject.tag == "wrong")
        {
            Die();
            Destroy(button);
            Destroy(button2);
            Destroy(button3);
            StartCoroutine(delay());
            
        }
    }

    private void Die()
    {
        Destroy(Player);
    }

    private IEnumerator delay()
    {
        yield return new WaitForSeconds(3);
        Restart();
    }

    private void Restart()
    {
        SceneManager.LoadScene("Dead");

    }
}
