using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField]
    public int sceneIndex;

    public Animator transition;

    public float transitionTime = 1f;

    public void GotoScene()
    {
        // FindObjectOfType<AudioManager>().Play("startButton2");
        StartCoroutine(LoadLevel(sceneIndex));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelIndex);
    }

    // public void QuitGame()
    // {
    //     Debug.Log("QuitGame");
    //     Application.Quit();
    // }



}
