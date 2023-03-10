using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueSystem : MonoBehaviour
{
    // public string gameScene = "Opening2";

    public Text txtName;
    public Text txtSentence;

    Queue<string> sentences = new Queue<string>();

    public Animator anim;

    public GameObject image;

    public void Begin(Dialogue info)
    {
        anim.SetBool("isOpen", true);

        sentences.Clear();

        txtName.text = info.name;

        foreach (var sentence in info.sentences)
        {
            sentences.Enqueue(sentence);
        }

        Next();
    }

    public void Next()
    {
        if (sentences.Count == 0)
        {
            End();
            return;
        }

        // txtSentence.text = sentences.Dequeue();
        txtSentence.text = string.Empty;
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentences.Dequeue()));
    }

    IEnumerator TypeSentence(string sentence)
    {
        foreach (var letter in sentence)
        {
            txtSentence.text += letter;
            yield return new WaitForSeconds(0.03f);
        }
    }

    private void End()
    {
        anim.SetBool("isOpen", false);

        txtSentence.text = string.Empty;

        image.GetComponent<FadeScript>().fadeout();
        StartCoroutine(nextScene());

        // Invoke("nextScene", 0.5f);

        //SceneManager.LoadScene("Opening2");
        // GetComponent<FadeScript>().Fade();
    }

    IEnumerator nextScene()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Opening2");
    }
}