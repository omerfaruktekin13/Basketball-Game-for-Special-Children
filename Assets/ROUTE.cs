using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ROUTE : MonoBehaviour
{
    [SerializeField]
    private Transform[] controlPoints;

    private Vector2 gizmosPosition;

    private void OnDrawGizmos()
    {
        for (float t=0; t<=1; t += 0.05f)
        {
            gizmosPosition = Mathf.Pow(1 - t, 3) * controlPoints[0].position
                + 3 * Mathf.Pow(1 - t, 2) * t * controlPoints[1].position
                + Mathf.Pow(t, 3) * controlPoints[3].position;
            Gizmos.DrawSphere(gizmosPosition, 0.25f);
        }

        Gizmos.DrawLine(new Vector2(controlPoints[0].position.x, controlPoints[0].position.y), new Vector2(controlPoints[1].position.x, controlPoints[1].position.y));

        Gizmos.DrawLine(new Vector2(controlPoints[2].position.x, controlPoints[2].position.y), new Vector2(controlPoints[3].position.x, controlPoints[3].position.y));
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        
    }
    public void yeni_bolum_k1()
    {
        SceneManager.LoadScene("o1");
    }
    public void yeni_bolum_k2()
    {
        SceneManager.LoadScene("o2");
    }
    public void yeni_bolum_k3()
    {
        SceneManager.LoadScene("o3");
    }
    public void yeni_bolum_o1()
    {
        SceneManager.LoadScene("z1");
    }
    public void yeni_bolum_o2()
    {
        SceneManager.LoadScene("z2");
    }
    public void yeni_bolum_o3()
    {
        SceneManager.LoadScene("z3");
    }
    public void yeni_bolum_z1()
    {
        SceneManager.LoadScene("k2");
    }
    public void yeni_bolum_z2()
    {
        SceneManager.LoadScene("k3");
    }
    public void tekrarla_k1()
    {
        SceneManager.LoadScene("k1");
    }
    public void tekrarla_k2()
    {
        SceneManager.LoadScene("k2");
    }
    public void tekrarla_k3()
    {
        SceneManager.LoadScene("k3");
    }
    public void tekrarla_o1()
    {
        SceneManager.LoadScene("o1");
    }
    public void tekrarla_o2()
    {
        SceneManager.LoadScene("o2");
    }
    public void tekrarla_o3()
    {
        SceneManager.LoadScene("o3");
    }
    public void tekrarla_z1()
    {
        SceneManager.LoadScene("z1");
    }
    public void tekrarla_z2()
    {
        SceneManager.LoadScene("z2");
    }
    public void tekrarla_z3()
    {
        SceneManager.LoadScene("z3");
    }
    public void eski_k2()
    {
        SceneManager.LoadScene("z1");
    }
    public void eski_k3()
    {
        SceneManager.LoadScene("z2");
    }
    public void eski_o1()
    {
        SceneManager.LoadScene("k1");
    }
    public void eski_o2()
    {
        SceneManager.LoadScene("k2");
    }
    public void eski_o3()
    {
        SceneManager.LoadScene("k3");
    }
    public void eski_z1()
    {
        SceneManager.LoadScene("o1");
    }
    public void eski_z2()
    {
        SceneManager.LoadScene("o2");
    }
    public void eski_z3()
    {
        SceneManager.LoadScene("o3");
    }
    public void ana_menu()
    {
        SceneManager.LoadScene("anaekran");
    }
}
