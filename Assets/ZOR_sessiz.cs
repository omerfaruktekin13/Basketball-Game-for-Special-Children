using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ZOR_sessiz : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource[] audioo;
    [SerializeField]
    private Transform[] routes;

    private int routeToGo;

    private float tParam;

    private Vector2 catPosition;

    private float speedModifier;

    private bool coroutineAllowed;
    public GameObject carpi_panel, yandin_panel, gectin_panel, tekrar_panel;
    public Text score;
    int skor;
    private int kac_defa_calacak;
    public Button topat;
    public float sayac = 0f;
    public float sayacc = 0f;
    //[SerializeField]
    int[] saniyeler;
    int Lenght = 10;
    List<int> list = new List<int>();
    int[] bosluklar;
    float x, y;
    void Start()
    {

        carpi_panel.SetActive(false); yandin_panel.SetActive(false); gectin_panel.SetActive(false); tekrar_panel.SetActive(false);
        x = transform.position.x;
        y = transform.position.y;
        sayac = 0f;
        sayacc = 0f;
        skor = 0;
        kac_defa_calacak = 9;
        saniyeler = new int[kac_defa_calacak + 1];
        bosluklar = new int[10 - kac_defa_calacak];
        for (int i = 0; i <= kac_defa_calacak; i++)
        {
            saniyeler[i] = Random.Range(1, 8);
        }

        tParam = 0f;
        speedModifier = 1.2f;
        coroutineAllowed = true;
        GenerateRandom();

        for (int u = 0; u < bosluklar.Length; u++)
        {
            bosluklar[u] = Random.Range(1, 10);
        }

        for (int r = 0; r < bosluklar.Length; r++)
        {
            for (int k = 0; k < 10; k++)
            {

                if (k == bosluklar[r])
                {
                    continue;
                }
                else
                {
                    audioo[list[k]].PlayDelayed((10 * k) + saniyeler[k]);
                }
            }
        }
        topat.onClick.AddListener(taskonclick);
        topat.onClick.AddListener(kell);
    }
    private void Update()
    {
        sayacc += Time.deltaTime;

        score.text = ("Score: " + skor.ToString());
        
        if (sayacc >= 100 && skor < 3) { yandin_panel.SetActive(true); }
        if (sayacc >= 100 && skor <= 7 && skor >= 3) { tekrar_panel.SetActive(true); }
        if (sayacc >= 100 && skor > 7) { gectin_panel.SetActive(true); }
    }
    // Update is called once per frame
    void taskonclick()
    {
        sayac = sayacc;
        if (sayac >= saniyeler[0] && sayac <= (saniyeler[0] + 3) || sayac >= (10 * 1 + saniyeler[1]) && sayac <= (10 * 1 + saniyeler[1] + 3)
            || sayac >= (10 * 2 + saniyeler[2]) && sayac <= (10 * 2 + saniyeler[2] + 3) || sayac >= (10 * 3 + saniyeler[3]) && sayac <= (10 * 3 + saniyeler[3] + 3)
            || sayac >= (10 * 4 + saniyeler[4]) && sayac <= (10 * 4 + saniyeler[4] + 3) || sayac >= (10 * 5 + saniyeler[5]) && sayac <= (10 * 5 + saniyeler[5] + 3)
            || sayac >= (10 * 6 + saniyeler[6]) && sayac <= (10 * 6 + saniyeler[6] + 3) || sayac >= (10 * 7 + saniyeler[7]) && sayac <= (10 * 7 + saniyeler[7] + 3)
            || sayac >= (10 * 8 + saniyeler[8]) && sayac <= (10 * 8 + saniyeler[8] + 3) || sayac >= (10 * 9 + saniyeler[9]) && sayac <= (10 * 9 + saniyeler[9] + 3))
        {
            routeToGo = 1;
            skor += 1;
        }
        else
        {
            routeToGo = 0;
        }
    }
    public void kell()
    {
        if (coroutineAllowed)
            StartCoroutine(GoByTheRoute(routeToGo));
    }
    private IEnumerator GoByTheRoute(int routeNumber)
    {
        coroutineAllowed = false;

        Vector2 p0 = routes[routeNumber].GetChild(0).position;
        Vector2 p1 = routes[routeNumber].GetChild(1).position;
        Vector2 p2 = routes[routeNumber].GetChild(2).position;
        Vector2 p3 = routes[routeNumber].GetChild(3).position;

        while (tParam < 1)
        {
            tParam += Time.deltaTime * speedModifier;

            catPosition = Mathf.Pow(1 - tParam, 3) * p0 + 3 * Mathf.Pow(1 - tParam, 2) * tParam * p1 + 3 * (1 - tParam) * Mathf.Pow(tParam, 2) * p2 + Mathf.Pow(tParam, 3) * p3;

            transform.position = catPosition;
            yield return new WaitForEndOfFrame();
        }

        tParam = 0f;
        coroutineAllowed = true;
        transform.position = new Vector2(x, y);

    }
    void GenerateRandom()
    {
        for (int j = 0; j < Lenght; j++)
        {
            int Rand = Random.Range(0, 10);
            while (list.Contains(Rand))
            {
                Rand = Random.Range(0, 10);
            }
            list.Add(Rand);
        }
    }
    public void carpi()
    {
        carpi_panel.SetActive(true);
    }
    public void devam_et_buton()
    {
        carpi_panel.SetActive(false);
    }
}
