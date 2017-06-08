using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadFeatures : MonoBehaviour
{

    public Text info;
    public Slider JinDu;
    private AsyncOperation async;  //异步对象
    private int progress = 0;  //读取场景的进度
	void Start ()
	{
	    StartCoroutine(LoadScene(name));
	}

    IEnumerator LoadScene(string name)
    {
        async = SceneManager.LoadSceneAsync("Main");
        yield return async;  //读取完毕后返回，系统会自动进入c场景
    }
    void Update ()
	{
	    JinDu.value = async.progress;
        info.text = "已加载:" + JinDu.value*100+"%";
	}

    void OnGUI()  //因为在异步读取场景，所以这里可以刷新UI
    {
      //  ABC();
    }

    void ABC(Texture2D[] tex)
    {
        
    }
}
