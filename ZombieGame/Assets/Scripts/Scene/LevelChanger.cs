using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelChanger : MonoBehaviour
{
    private Animator anim;
    public int levelToLoad;

    public VectorValue PlayerStorage;
    public Vector3 position;

    private void Start()
    {
        anim.GetComponent<Animator>();
    }
    public void FadeToLevel()
    {
        anim.SetTrigger("fade");
    }
    public void OnFadeComplete()
    {
        PlayerStorage.InitialValue = position;
        SceneManager.LoadScene(levelToLoad);
    }


    void Update()
    {
        
    }
}
