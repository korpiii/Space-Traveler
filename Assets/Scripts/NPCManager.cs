using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCManager : MonoBehaviour
{
    public string npcName;
    public string npcDialogue;
    public GameObject dialogueManager;
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
		if(collision.tag == "Player")
		{
            dialogueManager.GetComponent<DialogueManager>().StartNPCDialogue(npcName, npcDialogue);
        }
	}
}
