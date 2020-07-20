using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text npcNameUI;
    public Text npcDialogueUI;
    public Animator dialogueBoxAnimator;
    public float waitBeforeDialogue = 0.3f;
    public GameObject soundManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.Return))
		{
            EndDialogue();
		} 
    }

    public void StartNPCDialogue(string npcName, string npcDialogue)
	{
        dialogueBoxAnimator.SetBool("isOpen", true);
        npcNameUI.text = "";
        npcDialogueUI.text = "";
        npcNameUI.text = npcName;
        soundManager.GetComponent<AudioManager>().NpcBlabla();
        StopAllCoroutines();
        StartCoroutine(StartWriting(npcDialogue));


	}

    public void StartObjectText(string objectSentence)
	{
        npcNameUI.text = "";
        npcDialogueUI.text = "";
        dialogueBoxAnimator.SetBool("isOpen", true);
        StopAllCoroutines();
        StartCoroutine(StartWriting(objectSentence));
	}

    IEnumerator StartWriting(string sentence)
	{ 
        
        yield return new WaitForSeconds(waitBeforeDialogue);
        StartCoroutine(TypeSentence(sentence));
        yield return null;
    }
    IEnumerator TypeSentence(string sentence)
	{
        npcDialogueUI.text = "";
        foreach (char letter in sentence.ToCharArray())
		{
            npcDialogueUI.text += letter;
            yield return null;
		}
	}

    public void EndDialogue()
	{
        dialogueBoxAnimator.SetBool("isOpen", false);
    }
}
