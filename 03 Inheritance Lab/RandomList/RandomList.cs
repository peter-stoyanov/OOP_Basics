using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class RandomList : ArrayList
{
    private Random rnd;

    public RandomList()
    {
        this.rnd = new Random();
    }
    
    /// <summary>
    /// Removes random element from the list
    /// </summary>
    /// <returns></returns>
    public string RandomString()
    {
        int indexToRemove = rnd.Next(0, base.Count - 1);

        var returned = this[indexToRemove];

        base.RemoveAt(indexToRemove);

        return returned.ToString();

    }
}
