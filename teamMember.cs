using System.Collections.Generic;
namespace ToDo_Uygulaması
{
    public class teamMember
    {
        public teamMember(string id, string name, string surname)
        {
            this.Id=id;
            this.Name=name;
            this.Surname=surname;
        }
        public string Id{get;set;}
        public string Name{get;set;}
        public string Surname{get;set;}
        public static void memberAdd()
        {
            members.m.Add(new teamMember("10","Muharrem","Tekin"));
            members.m.Add(new teamMember("11","Mert","GÜNGÖRDÜ"));
            members.m.Add(new teamMember("12","Aslı","TÜRKMEN"));
            members.m.Add(new teamMember("13","Cansu","GÜRAL"));
            members.m.Add(new teamMember("14","Eylül","GÜNEŞ"));
            members.m.Add(new teamMember("15","Mesut","ÇEVİK"));
            members.m.Add(new teamMember("16","Enis","KİRAZOĞLU"));
            members.m.Add(new teamMember("17","Dost","KAYAOĞLU"));
            members.m.Add(new teamMember("17","Hideo","KOJİMA"));
        }
    }
}