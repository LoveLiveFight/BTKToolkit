using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTKBasicTracker
{
    public class Retainer
    {
        string _name;
        int _level;
        Confidant _confidant;
        AttribValues _base;
        AttribValues _elixir;
        AttribValues _aura;
        AttribValues _con;
        List<BookValues> _books;

        public string Name { get => _name; set => _name = value; }
        public int Level { get => _level; set => _level = value; }
        public Confidant Confidant { get => _confidant; set => _confidant = value; }
        public AttribValues Base { get => _base; set => _base = value; }
        public AttribValues Elixir { get => _elixir; set => _elixir = value; }
        public AttribValues Aura { get => _aura; set => _aura = value; }
        public AttribValues Con { get => _con; set => _con = value; }
        internal List<BookValues> Books { get => _books; set => _books = value; }
    }
}
