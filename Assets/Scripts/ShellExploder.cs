using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellExploder : MonoBehaviour {
    string shellFragmentsTag = "shell_frag";

    public void ExplodeShell(GameObject shelledStructure)
    {
        foreach (Transform child in shelledStructure.transform)
        {
            Debug.Log(child.tag);
        }
    }
}
