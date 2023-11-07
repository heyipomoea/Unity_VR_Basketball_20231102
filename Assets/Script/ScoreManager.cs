using TMPro;
using UnityEngine;

namespace Heyipomoea
{
    public class ScoreManager : MonoBehaviour
    {
        private string nameBasketball = "籃球";
        private TextMeshProUGUI textScore;
        private int score;
        private int scoreBasketball = 2;

        private void Awake()
        {
            textScore = GameObject.Find("分數文字").GetComponent<TextMeshProUGUI>();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.name.Contains(nameBasketball))
            {
                score += scoreBasketball;
                textScore.text = "SCORE:"+score.ToString();
            }
        }
    }
}

