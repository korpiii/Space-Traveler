using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebrisManager : MonoBehaviour
{
    public string[] objectSencentes;
    int maxNumber;
    public string objectSentence;

    // Start is called before the first frame update
    void Start()
    {
        maxNumber = objectSencentes.Length;
        int randomNumber = Random.Range(0, maxNumber);
        objectSentence = objectSencentes[randomNumber];

    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
