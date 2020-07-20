using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinText : MonoBehaviour
{
    public Text winTextUI;
    public string winText;
    public float waitBeforeDialogue = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TypeSentence(winText));
    }



    IEnumerator TypeSentence(string sentence)
    {
        winTextUI.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            winTextUI.text += letter;
            yield return new WaitForSeconds(waitBeforeDialogue);
        }
    }

}
