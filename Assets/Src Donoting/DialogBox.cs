using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogBox : MonoBehaviour
{
    public Transform box;
    public GameObject DialogGroup;
    
    void OpenDialogue(){
        DialogGroup.LeanScale(Vector3.one,0.5f);
    }
    void Start()
    {
        DialogGroup.transform.localScale = Vector3.zero;
    }
}
