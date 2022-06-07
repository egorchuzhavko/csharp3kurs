using z1;

Republic rep = new Republic("Республика Беларусь", "Белорусский рубль", "Зубр", "Президентская", "Президент");
Monarchy mon = new Monarchy("ОАЭ", "Дихрам ОАЭ", "Сокол", "Федеративная монархия", "Халифа ибн Заид Аль Нахайян");
Kingdom kingdom = new Kingdom("Великобритания", "Фунт стерлингов", "Биг Бен", "Елизавета II");
RB rb = new RB(9.3);
Republic rep1 = new Republic("Республика 1", "Валюта 1", "Символ 1", "Презид.", "Президент");
Republic rep2 = new Republic("Республика 2", "Валюта 2", "Символ 2", "Презид.", "Президент");
List<State> states = new List<State>();
states.Add(rep);
states.Add(kingdom);
states.Add(rb);
states.Add(mon);
states.Add(rep1);
states.Add(rep2);
foreach(var state in states)
{
    Console.WriteLine(state.ToString());
}
Console.WriteLine();
Republic.ShowCountOfRepublics();
Console.WriteLine();
string res = String.Empty;
string n = kingdom.Name;
string kn = kingdom.King;
kingdom.InfoAboutKingDom(ref n, ref kn, out res);
Console.WriteLine(res);