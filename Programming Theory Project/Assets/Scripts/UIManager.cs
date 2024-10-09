using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] TMP_InputField InputField;
    [SerializeField] TMP_Text textoBienvenida;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        if (GameManager.Instance == null)
        {
            LoadMenuScene();
        }
        else
        {
            if (textoBienvenida != null)
            {
                textoBienvenida.text = "Bienvenidx, "+GameManager.Instance.PlayerName;
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadMainScene()
    {
        if(InputField !=null && InputField.text!="")
        {
            GameManager.Instance.PlayerName = InputField.text;
            SceneManager.LoadScene(1);
        }
    }

    public void LoadMenuScene()
    {
        SceneManager.LoadScene(0);

    }

    public void ExitApplication()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

}
