using System.Drawing;

namespace CSharpTutorialMarch24;

public static class MadLib
{
    public static string MadLibSetter(string color, string pluralNoun, string celebrity)
    {
        return $"Roses are {color} \n{pluralNoun} are blue \nI love {celebrity}";
    }
}