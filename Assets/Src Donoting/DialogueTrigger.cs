using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueTrigger : MonoBehaviour
{
    public Message[] messages;
    private int index;
    public Actor[] actors;
    

    public void StartDialogue() {
        FindObjectOfType<DialogueManager>().Opendialogue(messages, actors);
    }
}
[System.Serializable]
    public class Message{
        public int actorId; //ตัวละคร
        public string message; //ข้อความ
    }
    [System.Serializable]
    public class Actor {
    public Sprite sprite;
}