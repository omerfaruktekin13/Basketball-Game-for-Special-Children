using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class anaekran : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void yukle()
    {
        SceneManager.LoadScene("k1");
    }
    public void yuklek2()
    {
        SceneManager.LoadScene("k2");
    }
    public void yuklek3()
    {
        SceneManager.LoadScene("k3");
    }
    public void yukleo1()
    {
        SceneManager.LoadScene("o1");
    }
    public void yukleo2()
    {
        SceneManager.LoadScene("o2");
    }
    public void yukleo3()
    {
        SceneManager.LoadScene("o3");
    }
    public void yuklez1()
    {
        SceneManager.LoadScene("z1");
    }
    public void yuklez2()
    {
        SceneManager.LoadScene("z2");
    }
    public void yuklez3()
    {
        SceneManager.LoadScene("z3");
    }
    public void sil()
    {
        PlayerPrefs.DeleteAll();
    }
}
