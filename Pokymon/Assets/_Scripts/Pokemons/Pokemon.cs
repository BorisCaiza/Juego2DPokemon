using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon
{
   private PokemonBase _base;
   private int _level;
   private List<Move> _moves;

   public List<Move> Moves
   {
      get => _moves;
      set => _moves = value;
   }
//Vida actuial del pokemon
   private int _hp;

   private int HP
   {
      get => _hp;
      set => _hp = value;
   }

   public Pokemon(PokemonBase pokemonBase, int level)
   {
      _base = pokemonBase;
      _level = level;
      _hp = _base.MaxHp;
      _moves = new List<Move>();

      foreach (var lMove in _base.LearnableMoves)
      {
         if (lMove.Level <= level)
         {
            _moves.Add(new Move(lMove.Move));
         }

         if (_moves.Count >= 4)
         {
            break;
         }
      }
   }

   public int MaxHp => Mathf.FloorToInt((_base.MaxHp * _level) / 100.0f)+10;
   public int Attack => Mathf.FloorToInt((_base.Attack * _level) / 100.0f)+2;
   public int Defense => Mathf.FloorToInt((_base.Defense * _level) / 100.0f)+2;
   public int spAttack => Mathf.FloorToInt((_base.SpAttack * _level) / 100.0f)+2;
   public int spDefense => Mathf.FloorToInt((_base.SpDefense * _level) / 100.0f)+2;
   public int Speed => Mathf.FloorToInt((_base.Speed * _level) / 100.0f)+2;
}
