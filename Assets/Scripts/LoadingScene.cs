using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScene : MonoBehaviour
{
    [SerializeField] GameObject loadingScreen;
    [SerializeField] GameObject levelSelector;

    [SerializeField] Slider loadingSlider;

    public void LoadScene(int sceneId)
    {
        levelSelector.SetActive(false);
        loadingScreen.SetActive(true);

        StartCoroutine(LoadSceneAsync(sceneId));
    }

    IEnumerator LoadSceneAsync(int sceneId)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneId);
        loadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progressValue = Mathf.Clamp01(operation.progress / 0.9f);
            loadingSlider.value = progressValue; 
            yield return null;
        }
    }
}
