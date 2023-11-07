using UnityEngine;
using UnityEngine.UI;

namespace Heyipomoea
{
    /// <summary>
    /// 生成籃球
    /// </summary>
    public class SpawnBasketball : MonoBehaviour
    {
        [SerializeField, Header("籃球預製物")]
        private GameObject prefabBasketball;

        /// <summary>
        /// 生成籃球按鈕
        /// </summary>
        private Button btnSpawnBasketball;

        private void Awake()
        {
            btnSpawnBasketball = GameObject.Find("生成籃球按鈕").GetComponent<Button>();
            btnSpawnBasketball.onClick.AddListener(Spwan);
        }

        private void Spwan()
        {
            Instantiate(prefabBasketball, transform.position, Quaternion.identity);
        }
    }
}

