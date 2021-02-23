using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Question1()
    {
        SceneManager.LoadScene("Question1");
    }
    public void Question2()
    {
        SceneManager.LoadScene("Question2");
    }
    public void Question3()
    {
        SceneManager.LoadScene("Question3");
    }
    public void Question4()
    {
        SceneManager.LoadScene("Question4");
    }
    public void Question5()
    {
        SceneManager.LoadScene("Question5");
    }
    public void SpringBalance()
    {
        SceneManager.LoadScene("SpringBalance");
        GameObject.Find("Steps Tab").GetComponent<Tajurbah_Gah.StepsLabelController>().UpdateStep(0, false);
    }
    public void Help2()
    {
        SceneManager.LoadScene("Help2");
    }
    public void Help3()
    {
        SceneManager.LoadScene("Help3");
    }
    public void Help4()
    {
        SceneManager.LoadScene("Help4");
    }
    public void Help5()
    {
        SceneManager.LoadScene("Help5");
    }
}
