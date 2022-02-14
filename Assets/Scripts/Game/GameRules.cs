using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameRules : MonoBehaviour
{
   [SerializeField] private ScoreCounter score;
   [SerializeField] private Text text;


   private float GetValue()
   {
      float value = string.IsNullOrEmpty(text.text) ? 0 : float.Parse(text.text);

      value = value > score.Score ? score.Score : value;
      value = value < 0 ? 0 : value;

      return value;
   }

   public void Item1()
   {
      score.Add(GetValue() * 2);
   }
   public void Item2()
   {
      score.Add(GetValue());
   }
   public void Item3()
   {
      score.TakeAway(GetValue());
   }
}
