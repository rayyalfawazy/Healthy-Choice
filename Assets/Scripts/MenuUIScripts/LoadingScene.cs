using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScene : MonoBehaviour
{
    public GameObject loadingScreen;
    string targetScene;
    [Range(0, 5)] public float delay;

    private void Start()
    {
        StopAllCoroutines();
    }

    public void LoadScene(string sceneName)
    {
        targetScene = sceneName;
        StartCoroutine(LoadSceneAsync());
    }

    private IEnumerator LoadSceneAsync()
    {
        loadingScreen.SetActive(true);
        yield return new WaitForSeconds(delay);

        AsyncOperation operation = SceneManager.LoadSceneAsync(targetScene);
        operation.allowSceneActivation = false;

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            if (progress >= 1f)
            {
                operation.allowSceneActivation = true;
                DOTween.KillAll();
            }
            yield return null;
        }

        loadingScreen.SetActive(false);
    }
}
