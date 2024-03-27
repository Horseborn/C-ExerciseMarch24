namespace CSharpTutorialMarch24.GetPower;

public static class GetPower
{
    public static int GetPow(int baseNum, int powNum)
    {
        int results = 1;
        for (int i = 0; i < powNum; i++)
        {
            results = results * baseNum;
        }
        return results;
    }
}