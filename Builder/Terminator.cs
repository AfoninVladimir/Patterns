using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Terminator
{
    private List<object> parts = new List<object>();

    public void Add(string part)
    {
        this.parts.Add(part);
    }

    public string ListParts()
    {
        string str = "";
        int n = this.parts.Count;

        for (int i = 0; i < n; i++)
        {
            str += this.parts[i] + ", ";
        }

        str = str.Remove(str.Length - 2); // удаление последних ", "

        return "Комплектация: " + str + "\n";
    }
}
