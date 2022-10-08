namespace WinForms_5;

public static class ExtensionMethods
{

    public static double GetNumberFromString(this string str)
    {
        double result = 0;
        bool isDot = false;

        foreach (var item in str)
        {
            if (char.IsDigit(item))
            {
                result = result * 10 + Convert.ToDouble(item.ToString());
                if (isDot)
                    result /= 10;
                isDot = false;
            }
            else if (item == '.')
                isDot = true;
        }

        return result;
    }

}