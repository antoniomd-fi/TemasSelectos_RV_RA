using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class resetButton : MonoBehaviour
{
    public Button reset;
    // Start is called before the first frame update
    void Start()
    {
        reset = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        reset.onClick.AddListener(resetGame);
    }

    public void resetGame()
    {
        SceneManager.LoadScene("Laberinto");
    }
}
