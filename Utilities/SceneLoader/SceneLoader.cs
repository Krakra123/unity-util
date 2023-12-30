using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadScene(string _name)
    {
        SceneManager.LoadScene(_name);
    }
}
