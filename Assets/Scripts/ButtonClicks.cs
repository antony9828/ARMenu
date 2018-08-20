using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClicks : MonoBehaviour {

    public void ChangeScene()
    {
        SceneManager.LoadScene("CameraScene");
    }

    public void Enlarge()
    {
        GameObject objects = GameObject.FindGameObjectWithTag("Sushi");
        objects.transform.localScale *= 2;
    }

}
