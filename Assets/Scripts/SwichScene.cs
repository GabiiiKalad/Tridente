using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class SwichScene : MonoBehaviour
{
    public InputActionProperty leftSwitch;
    public InputActionProperty rightSwitch;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float triggerValueleft = leftSwitch.action.ReadValue<float>();
        float triggerValueright = rightSwitch.action.ReadValue<float>();
        if (triggerValueleft > 0 && SceneManager.GetActiveScene().buildIndex > 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
        if (triggerValueright > 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
