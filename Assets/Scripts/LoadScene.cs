using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
using System.Threading.Tasks;

public class LoadScene : MonoBehaviour
{
    [SerializeField] private string _sceneName;

    private void OnMouseDown()
    {
        Camera.main.DOOrthoSize(0.1f, 2f).OnComplete(() => LoadAsyncScene());
    }

    public async void LoadAsyncScene()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(_sceneName);
        
        while (!asyncLoad.isDone)
        {
            await Task.Yield();
        }
    }
}