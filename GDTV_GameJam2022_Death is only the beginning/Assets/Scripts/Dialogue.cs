using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textComponent;
    [SerializeField] float textSpeed;
    [TextArea(3, 10)]
    [SerializeField] string[] lines;
    public bool dialogueEnded;

    private int index;
    
    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = string.Empty;
        StartDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        PressToContinue();
    }

    private void PressToContinue()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];

            }
        }
    }

    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
        dialogueEnded = false;
    }

    IEnumerator TypeLine()
    {
        yield return new WaitForSeconds(1f);

        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            dialogueEnded = true;
            textComponent.gameObject.SetActive(false);
            //gameObject.SetActive(false);
        }
    }
}
