using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class SuggestedScores
{
    private int[] roll;

    public void setroll(int[] roll)
    {
        this.roll = roll;
    }

    public string[] suggestion()
    {
        return new List<string>() { "AllOfAKind" }.ToArray();
    }
}

