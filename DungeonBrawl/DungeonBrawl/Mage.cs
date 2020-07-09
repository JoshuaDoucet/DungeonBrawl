//Mage is a derived class of Character

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonBrawl
{
    public class Mage : Character
   {
      public Mage()
      : base((int)CHAR_TYPES.MAGE, //type number
           CHAR_NAMES[(int)CHAR_TYPES.MAGE], //type name
           2, //strength
           6, //inteligence
           80, //totalHP
           6, //totalSp
           7, //speed
           true, //isAlive
           true, //isHerp
           "UNKNOWN", //char imaage file name
           4, // physical def
           8, //magical def
           (int)DMG_TYPES.MAGIC) // damge type
      {
      }
   }
}