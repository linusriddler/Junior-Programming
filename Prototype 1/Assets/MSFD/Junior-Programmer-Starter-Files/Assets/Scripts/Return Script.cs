using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnScript : MonoBehaviour
{
    public void EndNew()
    {
        SceneManager.LoadScene(0);
    }
}
