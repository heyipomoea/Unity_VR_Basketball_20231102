using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Heyipomoea
{
    /// <summary>
    /// 場景系統
    /// </summary>
    public class SceneSystem : MonoBehaviour
    {
        private Button btnReplay, btnQuit;

        private void Awake()
        {
            btnReplay = GameObject.Find("重新開始按鈕").GetComponent<Button>();
            btnQuit = GameObject.Find("離開遊戲按鈕").GetComponent<Button>();

            btnQuit.onClick.AddListener(() => Application.Quit());
            btnReplay.onClick.AddListener(() =>
            {
                string currentScene = SceneManager.GetActiveScene().name;
                SceneManager.LoadScene(currentScene);
            });
        }
    }
}

