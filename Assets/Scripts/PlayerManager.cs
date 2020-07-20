using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public GameObject dialogueManager;
    public GameObject soundManager;
    public float waitTime = 1f;
    public Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "debris")
        {
            soundManager.GetComponent<AudioManager>().ObjectPickUp();
            string debrisSentence = collision.gameObject.GetComponent<DebrisManager>().objectSentence;
            dialogueManager.GetComponent<DialogueManager>().StartObjectText(debrisSentence);
            Destroy(collision.gameObject);



        }
        if (collision.tag == "meteorite")
        {
            soundManager.GetComponent<AudioManager>().PlayerDeath();
            Invoke("Restart", waitTime);
            rigidbody.constraints = RigidbodyConstraints2D.FreezeAll;
        }

        if(collision.name == "Earth")
		{
            soundManager.GetComponent<AudioManager>().PlayerWins();
            Invoke("ChangeToWinScreen", waitTime);
        }


    }

    private void ChangeToWinScreen()
    {
        SceneManager.LoadScene("Win");
    }
    private void Restart()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
