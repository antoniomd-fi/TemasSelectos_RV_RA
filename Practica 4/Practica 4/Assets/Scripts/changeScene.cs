using UnityEngine;
using UnityEngine.SceneManagement;

namespace DefaultNamespace
{
    public class changeScene : MonoBehaviour
    {
        public void scene(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}