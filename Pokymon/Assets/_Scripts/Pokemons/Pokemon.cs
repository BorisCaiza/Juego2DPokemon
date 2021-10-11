using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon
{
   private PokemonBase _base;
   private int _level;

   public Pokemon(PokemonBase pokemonBase, int level)
   {
      _base = pokemonBase;
      _level = level;
   }

   public int MaxHp => Mathf.FloorToInt((_base.MaxHp * _level) / 100.0f)+10;
   public int Attack => Mathf.FloorToInt((_base.Attack * _level) / 100.0f)+2;
   public int Defense => Mathf.FloorToInt((_base.Defense * _level) / 100.0f)+2;
   public int spAttack => Mathf.FloorToInt((_base.SpAttack * _level) / 100.0f)+2;
   public int spDefense => Mathf.FloorToInt((_base.SpDefense * _level) / 100.0f)+2;
   public int Speed => Mathf.FloorToInt((_base.Speed * _level) / 100.0f)+2;
}
