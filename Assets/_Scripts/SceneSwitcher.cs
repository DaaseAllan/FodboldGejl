using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour {

    public Animator Animator;
    private string scene_name;

    public void FadeScene (string scenename)
    {
        scene_name = scenename;
        Animator.SetTrigger("FadeOut");
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(scene_name);
    }
}
