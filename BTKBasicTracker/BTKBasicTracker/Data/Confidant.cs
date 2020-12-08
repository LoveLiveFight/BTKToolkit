using System.Collections.Generic;

namespace BTKBasicTracker
{
    public class Confidant
    {
        string _name;
        int _intimacy;
        int _charm;
        int _exp;
        List<Skill> _skills;

        public string Name { get => _name; set => _name = value; }
        public int Intimacy { get => _intimacy; set => _intimacy = value; }
        public int Charm { get => _charm; set => _charm = value; }
        public int Exp { get => _exp; set => _exp = value; }
        internal List<Skill> Skills { get => _skills; set => _skills = value; }
    }
}